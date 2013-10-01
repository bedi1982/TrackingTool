using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackingTool6.Model;
using TrackingTool6.db;
using System.Windows.Forms;

namespace TrackingTool6.Controler
{
    class Contas_PagarDAO
    {
        public static void AdicionaContaPagar(ContasPagar contaPagar)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.ContasPagares.Add(contaPagar);
                db.SaveChanges();
                MessageBox.Show("Adicionado ao Banco");
            }
            catch
            {
                MessageBox.Show("Nao adicionou");
            }
            
        }

        public static IOrderedEnumerable<ContasPagar> Search(Fornecedor fornecedor)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            ////List<ContasPagar> listaConta = new List<ContasPagar>();

            //foreach (ContasPagar x in db.ContasPagares)
            //{
            //    // TODO Está case senstive
            //    if (x.forn.nome.ToUpper().Contains(forn.nome.ToUpper()))    
            //    {
            //        listaConta.Add(x);
            //    }
            //}
            //return null;

            try
            {
                IOrderedEnumerable<ContasPagar> contas = db.ContasPagares.Where(x => x.forn.nome.Equals(fornecedor.nome)).ToList().OrderBy(x => x.emissao);
                return contas;
            }
            catch
            {
                return null;
            }
        }
        
    }
}
