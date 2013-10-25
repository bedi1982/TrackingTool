using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tracking.Tool;
using Tracking.Model;
using System.Windows.Forms;

namespace Tracking.Controler
{
    class Centro_de_CustoDAO
    {
        public static bool AdicionaCentroDeCusto(CentroDeCusto centro_de_custo)
        {
            banco db = SingletonObjectContext.Instance.Context;
            try
            {
                db.CentrosDeCusto.Add(centro_de_custo);
                db.SaveChanges();
                MessageBox.Show("Centro de Custo Cadastrado!");
            }
            catch
            {
                MessageBox.Show("Falha ao Cadastrar Centro de Custo!");
            }
            return true;
        }

        public static CentroDeCusto Procurar_CDC_por_nome(CentroDeCusto centro_de_custo)
        {
            banco db = SingletonObjectContext.Instance.Context;

            CentroDeCusto encontrado = new CentroDeCusto();
            encontrado = null;

            try
            {
                foreach (CentroDeCusto x in db.CentrosDeCusto)
                {
                    // TODO Está case senstive
                    if (x.nome.ToUpper().Contains(centro_de_custo.nome.ToUpper()) && x.status == true)
                    {
                        encontrado = x;
                        break;
                    }

                }

                if (encontrado != null)
                {
                    return encontrado;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static double valor_total_em_todos_osCDC ()
        {
            banco db = SingletonObjectContext.Instance.Context;
            double total = 0;
            foreach (CentroDeCusto x in db.CentrosDeCusto)
            {
                // TODO Está case senstive
                if (x.status == true)
                {
                    total += x.saldo;
                }
            }
            return total;
        }


        public static bool AdicionaValorAoCDC(CentroDeCusto centro_de_custo)
        {
            banco db = SingletonObjectContext.Instance.Context;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
            return true;
        }

        //A função de remover não remove, apenas inativa//
        public static CentroDeCusto Remove_CDC(CentroDeCusto centrodecusto)
        {
            banco db = SingletonObjectContext.Instance.Context;

            foreach (CentroDeCusto x in db.CentrosDeCusto)
            {
                if (x.id.Equals(centrodecusto.id))
                {
                    centrodecusto = x;
                    break;
                }
            }
            centrodecusto.status = false;
            db.SaveChanges();
            MessageBox.Show("Centro de Custo Removido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        public static void EditarCentro(CentroDeCusto centro)
        {
            banco db = SingletonObjectContext.Instance.Context;

            try
            {
                db.SaveChanges();
            }

            catch
            {
                MessageBox.Show("Erro");
            }

        }


        public static CentroDeCusto Procurar_Centro(CentroDeCusto centro_de_custo)
        {
            banco db = SingletonObjectContext.Instance.Context;

            
             foreach (CentroDeCusto x in db.CentrosDeCusto)
                {
                    // TODO Está case senstive
                    if (x.nome.ToUpper().Contains(centro_de_custo.nome.ToUpper()))
                    {
                        
                        return x;
                    }

                }

             return null;
        }
    }
}