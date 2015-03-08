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
            double credito = 0;
            double saldofinal = 0;

            foreach (CentroDeCusto x in db.CentrosDeCusto)
            {
                debito = 0;
                foreach (ContaAPagar y in db.ContaAPagar)
                {
                    if (y.centroCusto == x.nome)
                    {
                        if (y.status == false)
                        {
                            debito += y.valor;
                        }
                    }
                }

                credito = 0;
                foreach (ContaReceber n in db.ContaReceber)
                {

                    if (n.centroCusto == x.nome)
                    {
                        if (n.status == false)
                        {
                            credito += n.valor;
                        }
                    }
                }
                saldofinal = 0;
                saldofinal = x.saldo - debito + credito;
                DGMovimentacao.Rows.Add(x.nome, x.saldo, debito, credito, saldofinal);
            }
            
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {

            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                
                
                xlWorkSheet.Cells[1, 1] = "Conta";
                xlWorkSheet.Cells[1, 2] = "Saldo Atual R$";
                xlWorkSheet.Cells[1, 3] = "Débito R$";
                xlWorkSheet.Cells[1, 4] = "Crédito R$";
                xlWorkSheet.Cells[1, 5] = "Saldo Final R$";
                xlWorkSheet.Cells[1, 6] = "Saldo Extrato R$";
                xlWorkSheet.Cells[1, 7] = "Diferença Saldo Final x Extrato";
                xlWorkSheet.Cells[1, 8] = "Conciliação";
                
                xlWorkSheet.Cells[1, 12] = "Relatório Gerado em:";
                xlWorkSheet.Cells[2, 12] = DateTime.Now;

                DataGridViewCell celula = null;
                

                // vamos percorrer as linhas
                for (int i = 0; i < DGMovimentacao.RowCount; i++)
                {
                // vamos percorrer as colunas de cada linha
                    for (int x = 0; x < DGMovimentacao.ColumnCount; x++)
                    {
                        // obtém a célula na coluna x e linha i
                        celula = DGMovimentacao[x, i];

                        if (celula.Value != null)
                        {
                            xlWorkSheet.Cells[i+3, x+1] = celula.Value.ToString();
                            
                        }
                        else
                        {
                            
                        }
                        
                    }
                    
                }
                

                

                xlWorkBook.SaveAs(txtArquivoExcel.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                liberarObjetos(xlWorkSheet);
                liberarObjetos(xlWorkBook);
                liberarObjetos(xlApp);

                MessageBox.Show("O arquivo Excel foi criado com sucesso. Você pode encontrá-lo em : " + txtArquivoExcel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void liberarObjetos(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Ocorreu um erro durante a liberação do objeto " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }

        
        
        }

   }

        
}

