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
    class ContaPagarDAO
    {
       public static bool AdicionaContaPagar(ContaAPagar conta_pagar)
        {
            banco db = SingletonObjectContext.Instance.Context;
            try
            {
                db.ContaAPagar.Add(conta_pagar);
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("Não Adicionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

       public static double Retorna_a_pagar_total()
       {
           banco db = SingletonObjectContext.Instance.Context;
           double total = 0;

           foreach (ContaAPagar x in db.ContaAPagar)
           {
               if (x.status == false)
               {
                   total += x.valor;
               }
           }
           return total;
       }

       public static ContaAPagar Procurar_Conta_por_id(ContaAPagar conta)
       {
           banco db = SingletonObjectContext.Instance.Context;

           foreach (ContaAPagar x in db.ContaAPagar)
           {

               if (x.id.Equals(conta.id))
               {
                   return x;
               }
           }
           return null;
       }


       public static bool ExcluirContaPagar(ContaAPagar conta_pagar)
       {
           banco db = SingletonObjectContext.Instance.Context;

           try
           {
               db.ContaAPagar.Remove(conta_pagar);
               db.SaveChanges();
           }
           catch
           {
               MessageBox.Show("Erro");
           }

           return true;

       }

       public static bool PagarConta(ContaAPagar contaPagar)
       {
           banco db = SingletonObjectContext.Instance.Context;

           try
           {
               contaPagar.status = true;
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
