using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tracking.Tool;
using Tracking.Model;
using System.Windows.Forms;

namespace Tracking.Controler
{
    class LojaDAO
    {

        public static bool AdicionaLojaEF(Loja loja)
        {
            banco db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Lojas.Add(loja);
                db.SaveChanges();
                MessageBox.Show("Loja inclusa com sucesso!");
                return true;
            }
            catch
            {
                MessageBox.Show("Nao adicionou");
                return false;
            }

            
        }

        public static Loja Procurar_Loja_por_nome(Loja loja)
        {
            banco db = SingletonObjectContext.Instance.Context;

            foreach (Loja x in db.Lojas)
            {
                // TODO Está case senstive
                if (x.nome.ToUpper().Contains(loja.nome.ToUpper()) && x.status == true)
                {
                    return x;
                }
            }
            return null;
        }
        public static Loja Procurar_Loja_por_codigo_hiperfarma(Loja loja)
        {
            banco db = SingletonObjectContext.Instance.Context;
            Loja encontrado = new Loja();
            encontrado = null;


            try
            {
                foreach (Loja x in db.Lojas)
                {
                    if (x.codigo_hiperfarma.Equals(loja.codigo_hiperfarma) && x.status == true)
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

        //A função de remover não remove, apenas inativa//
        public static Loja Remove_Loja(Loja loja)
        {
            banco db = SingletonObjectContext.Instance.Context;

            foreach (Loja x in db.Lojas)
            {
                if (x.id.Equals(loja.id))
                {
                    loja = x;
                    break;
                }
            }
            loja.status = false;
            db.SaveChanges();
            MessageBox.Show("Loja Removida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        public static void EditarLoja(Loja loja)
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
    }
}
