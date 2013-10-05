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
    class ContaPagarDAO
    {
       public static bool AdicionaContaPagar(ContaAPagar conta_pagar)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
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

    }
}
