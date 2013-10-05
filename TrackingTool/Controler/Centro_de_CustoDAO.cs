using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackingTool6.db;
using TrackingTool6.Model;
using System.Windows.Forms;

namespace TrackingTool6.Controler
{
    class Centro_de_CustoDAO
    {
        public static bool AdicionaCentroDeCusto(CentroDeCusto centro_de_custo)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
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
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

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


        public static bool AdicionaValorAoCDC(CentroDeCusto centro_de_custo)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

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
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

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
            MessageBox.Show("Centro de Custo Removido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }
}