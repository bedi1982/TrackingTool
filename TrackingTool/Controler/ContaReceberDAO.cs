using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackingTool6.db;
using TrackingTool6.Model;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using TrackingTool6.View;

namespace TrackingTool6.Controler
{
    class ContaReceberDAO
    {

        public static bool AdicionaContaReceber(ContaReceber conta_receber)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.ContaReceber.Add(conta_receber);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Não adicionou");
            }
            return true;
        }


        public static bool ReceberConta(ContaReceber contareceber)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

            try
            {
                contareceber.status = true;
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Erro");
            }

            return true;
        }


        public static ContaReceber Procurar_Conta_por_id(ContaReceber contareceber)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

            foreach (ContaReceber x in db.ContaReceber)
            {
                
                if (x.id.Equals(contareceber.id))
                {
                    return x;
                }
            }
            return null;
        }

        public static void AlterarValor(ContaReceber conta)
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
        }

    }
}
