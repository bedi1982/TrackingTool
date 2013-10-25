using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tracking.Tool;
using Tracking.Model;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Tracking.View;

namespace Tracking.Controler
{
    class ContaReceberDAO
    {

        public static bool AdicionaContaReceber(ContaReceber conta_receber)
        {
            banco db = SingletonObjectContext.Instance.Context;
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
            banco db = SingletonObjectContext.Instance.Context;

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
            banco db = SingletonObjectContext.Instance.Context;

            foreach (ContaReceber x in db.ContaReceber)
            {
                
                if (x.id.Equals(contareceber.id))
                {
                    return x;
                }
            }
            return null;
        }

        //Essa retorna o valor todo que a hiperF tem a receber
        public static double Retorna_a_receber_total()
        {
            banco db = SingletonObjectContext.Instance.Context;
            double total = 0;

            foreach (ContaReceber x in db.ContaReceber)
            {
                if (x.status == false)
                {
                    total += x.valor ;
                }
            }
            return total;
        }

        public static void AlterarValor(ContaReceber conta)
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

        public static bool ExcluirContaReceber(ContaReceber conta_receber)
        {
            banco db = SingletonObjectContext.Instance.Context;

            try
            {
                db.ContaReceber.Remove(conta_receber);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Erro");
            }

            return true;

        }

    }
}
