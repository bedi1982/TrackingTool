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
                MessageBox.Show("Adicionado ao Banco");
            }
            catch
            {
                MessageBox.Show("Nao adicionou");
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

        public static IOrderedEnumerable<CentroDeCusto> BuscaCentrosDeCustos()
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                IOrderedEnumerable<CentroDeCusto> CC = db.CentrosDeCusto.ToList().OrderBy(x => x.nome);
                return CC;
            }
            catch
            {
                return null;
            }
        }
    }
}
