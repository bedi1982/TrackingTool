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
    public partial class Frm_Contas_Pagas : Form
    {
        public Frm_Contas_Pagas()
        {
            InitializeComponent();
            double total = 0;
            banco db = SingletonObjectContext.Instance.Context;
            DGContasPagas.Rows.Clear();
            foreach (ContaAPagar x in db.ContaAPagar)
            {
                if (x.status == true)
                {
                    DGContasPagas.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.tipo, x.descricao, x.centroCusto, x.valor);
                    total += x.valor;
                }
            }
            TxtTotalPago.Text = total.ToString();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnFiltrar_Click_1(object sender, EventArgs e)
        {

            double total = 0;
            banco db = SingletonObjectContext.Instance.Context;
            DGContasPagas.Rows.Clear();


            foreach (ContaAPagar x in db.ContaAPagar)
            {
                //Checagem de inativo(x.status) adicionado ao if abaixo - Sergio//
                if (x.status == true && (x.dataRecebe.Date >= DateTime.Parse(dateTimePicker1.Text)) && (x.dataRecebe.Date <= DateTime.Parse(dateTimePicker2.Text)))
                {
                    DGContasPagas.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.tipo, x.descricao, x.centroCusto, x.valor);
                    total += x.valor;
                }
            }
            TxtTotalPago.Text = total.ToString();
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
                xlWorkSheet.Cells[1, 2] = "Data do Cadastro";
                xlWorkSheet.Cells[1, 3] = "Data do Recebimento";
                xlWorkSheet.Cells[1, 4] = "Código";
                xlWorkSheet.Cells[1, 5] = "Loja";
                xlWorkSheet.Cells[1, 6] = "Fornecedor";
                xlWorkSheet.Cells[1, 7] = "Tipo";
                xlWorkSheet.Cells[1, 8] = "Descrição da Conta";
                xlWorkSheet.Cells[1, 9] = "Centro de Custo";
                xlWorkSheet.Cells[1, 10] = "Valor R$";

                xlWorkSheet.Cells[1, 13] = "Valor Total a Pagar R$";
                xlWorkSheet.Cells[2, 13] = TxtTotalPago.Text.ToString();

                xlWorkSheet.Cells[1, 16] = "Relatório Gerado em:";
                xlWorkSheet.Cells[2, 16] = DateTime.Now;

                DataGridViewCell celula = null;


                // vamos percorrer as linhas
                for (int i = 0; i < DGContasPagas.RowCount; i++)
                {
                    // vamos percorrer as colunas de cada linha
                    for (int x = 0; x < DGContasPagas.ColumnCount; x++)
                    {
                        // obtém a célula na coluna x e linha i
                        celula = DGContasPagas[x, i];

                        if (celula.Value != null)
                        {
                            xlWorkSheet.Cells[i + 2, x + 1] = celula.Value.ToString();

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