using Excel = Microsoft.Office.Interop.Excel; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tracking.Tool;
using Tracking.Model;

namespace Tracking.View
{
    public partial class Frm_listar_CDC : Form
    {
        public Frm_listar_CDC()
        {
            InitializeComponent();
        }

        private void Frm_listar_CDC_Load(object sender, EventArgs e)
        {
            banco db = SingletonObjectContext.Instance.Context;
            grid_listar_cdcs.Rows.Clear();
            foreach (CentroDeCusto x in db.CentrosDeCusto)
            {
                if (x.status == true)//Os inativos não queremos ver:
                {
                    grid_listar_cdcs.Rows.Add(x.codigo_hiperfarma, x.nome, x.descricao, x.saldo);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                
                
                xlWorkSheet.Cells[1, 1] = "Código";
                xlWorkSheet.Cells[1, 2] = "Nome";
                xlWorkSheet.Cells[1, 3] = "Descrição";
                xlWorkSheet.Cells[1, 4] = "Saldo R$";
                xlWorkSheet.Cells[1, 7] = "Relatório Gerado em:";
                xlWorkSheet.Cells[2, 7] = DateTime.Now;

                DataGridViewCell celula = null;
                

                // vamos percorrer as linhas
                for (int i = 0; i < grid_listar_cdcs.RowCount; i++)
                {
                // vamos percorrer as colunas de cada linha
                    for (int x = 0; x < grid_listar_cdcs.ColumnCount; x++)
                    {
                        // obtém a célula na coluna x e linha i
                        celula = grid_listar_cdcs[x, i];

                        if (celula.Value != null)
                        {
                            xlWorkSheet.Cells[i+2, x+1] = celula.Value.ToString();
                            
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

