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
    public partial class Frm_Listar_Lojas : Form
    {
        public Frm_Listar_Lojas()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Listar_Lojas_Load(object sender, EventArgs e)
        {
            banco db = SingletonObjectContext.Instance.Context;
            grid_listar_lojas.Rows.Clear();
            foreach (Loja x in db.Lojas)
            {
                if (x.status == true)//Os inativos não queremos ver:
                {
                    grid_listar_lojas.Rows.Add(x.id, x.codigo_hiperfarma, x.nome, x.CNPJ, x.telefone, x.email, x.rua, x.bairro, x.numero, x.complemento);
                }
            }
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
                
                
                xlWorkSheet.Cells[1, 1] = "ID";
                xlWorkSheet.Cells[1, 2] = "Código";
                xlWorkSheet.Cells[1, 3] = "Nome";
                xlWorkSheet.Cells[1, 4] = "CNPJ";
                xlWorkSheet.Cells[1, 5] = "Telefone";
                xlWorkSheet.Cells[1, 6] = "E-mail";
                xlWorkSheet.Cells[1, 7] = "Rua";
                xlWorkSheet.Cells[1, 8] = "Bairro";
                xlWorkSheet.Cells[1, 9] = "Número";
                xlWorkSheet.Cells[1, 10] = "Complemento";

                xlWorkSheet.Cells[1, 13] = "Relatório Gerado em:";
                xlWorkSheet.Cells[2, 13] = DateTime.Now;
                
                DataGridViewCell celula = null;
                

                // vamos percorrer as linhas
                for (int i = 0; i < grid_listar_lojas.RowCount; i++)
                {
                // vamos percorrer as colunas de cada linha
                    for (int x = 0; x < grid_listar_lojas.ColumnCount; x++)
                    {
                        // obtém a célula na coluna x e linha i
                        celula = grid_listar_lojas [x, i];

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

