using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tracking.Model;
using Tracking.Controler;
using Tracking.Tool;

namespace Tracking.View
{
    public partial class Frm_Movimentacao_financeira : Form
    {
        public Frm_Movimentacao_financeira()
        {
            InitializeComponent();
            banco db = SingletonObjectContext.Instance.Context;
            
            CentroDeCusto centro = new CentroDeCusto();
            ContaAPagar pagar = new ContaAPagar();

            double debito = 0;
            

            foreach(CentroDeCusto x in db.CentrosDeCusto){
                debito = 0;
                foreach (ContaAPagar y in db.ContaAPagar)
            {
                if(y.centroCusto == x.nome)
                {
                    if (y.status == false)
                    {
                        debito += y.valor;
                    }
                }
                
            }
                
            }
            
            foreach(CentroDeCusto x in db.CentrosDeCusto)
            {
                DGMovimentacao.Rows.Add(x.nome, x.saldo);
            }
            

            
        //DGMovimentacao.Columns[2].Name = debito.ToString();
            
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
