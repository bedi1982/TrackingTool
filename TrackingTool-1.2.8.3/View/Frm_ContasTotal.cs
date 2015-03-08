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
using System.Collections;

namespace Tracking.View
{
    public partial class Frm_ContasTotal : Form
    {
        public Frm_ContasTotal()
        {
            InitializeComponent();

            banco db = SingletonObjectContext.Instance.Context;
            CentroDeCusto centro = new CentroDeCusto();

            ArrayList lista = new ArrayList();
            foreach (CentroDeCusto x in db.CentrosDeCusto)
            {
                if (x.status == true)
                {
                    lista.Add(x.nome);
                }
            }
            CBCentros.DataSource = lista;

            double pagar = 0;
            double pago = 0;
            double receber = 0;
            double recebido = 0;

            TxtPagar.Text = "";
            TxtPago.Text = "";
            TxtReceber.Text = "";
            TxtRecebido.Text = "";

            DGContasTotal.Rows.Clear();

            foreach (ContaAPagar x in db.ContaAPagar)
            {
                if (x.centroCusto == CBCentros.Text && x.status == false)
                {
                        DGContasTotal.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.tipo, x.descricao, x.centroCusto, x.valor, "A Pagar");
                        pagar += x.valor;
                }

                if (x.centroCusto == CBCentros.Text && x.status == true)
                {
                        DGContasTotal.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.tipo, x.descricao, x.centroCusto, x.valor, "Pago");
                        pago += x.valor;
                }
            }

            foreach (ContaReceber x in db.ContaReceber)
            {
                if (x.centroCusto == CBCentros.Text && x.status == false)
                {
                        DGContasTotal.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.tipo, x.descricao, x.centroCusto, x.valor, "A Receber");
                        receber += x.valor;
                }
                if (x.centroCusto == CBCentros.Text && x.status == true)
                {
                        DGContasTotal.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.tipo, x.descricao, x.centroCusto, x.valor, "Recebido");
                        recebido += x.valor;
                }
            }

            TxtPagar.Text = pagar.ToString();
            TxtPago.Text = pago.ToString();
            TxtRecebido.Text = recebido.ToString();
            TxtReceber.Text = receber.ToString();

            MessageBox.Show("A primeira tela lista todas as contas, use um dos filtros disponíveis para resultados mais específicos");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            double pagar = 0;
            double pago = 0;
            double receber = 0;
            double recebido = 0;

            TxtPagar.Text = "";
            TxtPago.Text = "";
            TxtReceber.Text = "";
            TxtRecebido.Text = "";

            banco db = SingletonObjectContext.Instance.Context;
            DGContasTotal.Rows.Clear();
            foreach (ContaAPagar x in db.ContaAPagar)
            {
                if (x.centroCusto == CBCentros.Text && x.status == false)
                {
                    if ((x.dataRecebe.Date >= DateTime.Parse(dateTimePicker1.Text)) && (x.dataRecebe.Date <= DateTime.Parse(dateTimePicker2.Text)))
                    {
                        DGContasTotal.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor, "A Pagar");
                        pagar += x.valor;
                    }
                }
                if (x.centroCusto == CBCentros.Text && x.status == true)
                {
                    if ((x.dataRecebe.Date >= DateTime.Parse(dateTimePicker1.Text)) && (x.dataRecebe.Date <= DateTime.Parse(dateTimePicker2.Text)))
                    {
                        DGContasTotal.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor, "Pago");
                        pago += x.valor;
                    }
                }
            }
            foreach (ContaReceber x in db.ContaReceber)
            {
                if (x.centroCusto == CBCentros.Text && x.status == false)
                {
                    if ((x.dataRecebe.Date >= DateTime.Parse(dateTimePicker1.Text)) && (x.dataRecebe.Date <= DateTime.Parse(dateTimePicker2.Text)))
                    {
                        DGContasTotal.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor, "A Receber");
                        receber += x.valor;
                    }
                }
                if (x.centroCusto == CBCentros.Text && x.status == true)
                {
                    if ((x.dataRecebe.Date >= DateTime.Parse(dateTimePicker1.Text)) && (x.dataRecebe.Date <= DateTime.Parse(dateTimePicker2.Text)))
                    {
                        DGContasTotal.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor, "Recebido");
                        recebido += x.valor;
                    }
                }
            }

            TxtPagar.Text = pagar.ToString();
            TxtPago.Text = pago.ToString();
            TxtRecebido.Text = recebido.ToString();
            TxtReceber.Text = receber.ToString();
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
                xlWorkSheet.Cells[1, 8] = "Descrição da Conta";
                xlWorkSheet.Cells[1, 7] = "Tipo";
                xlWorkSheet.Cells[1, 9] = "Centro de Custo";
                xlWorkSheet.Cells[1, 10] = "Valor R$";
                xlWorkSheet.Cells[1, 11] = "Status";
                xlWorkSheet.Cells[1, 15] = "A Pagar R$";
                xlWorkSheet.Cells[2, 15] = TxtPagar.Text.ToString();
                xlWorkSheet.Cells[4, 15] = "Pago R$";
                xlWorkSheet.Cells[5, 15] = TxtPago.Text.ToString();

                xlWorkSheet.Cells[1, 17] = "Receber R$";
                xlWorkSheet.Cells[2, 17] = TxtReceber.Text.ToString();

                xlWorkSheet.Cells[4, 17] = "Recebido R$";
                xlWorkSheet.Cells[5, 17] = TxtRecebido.Text.ToString();

                xlWorkSheet.Cells[1, 19] = "Relatório Gerado em:";
                xlWorkSheet.Cells[2, 19] = DateTime.Now;

                DataGridViewCell celula = null;


                // vamos percorrer as linhas
                for (int i = 0; i < DGContasTotal.RowCount; i++)
                {
                    // vamos percorrer as colunas de cada linha
                    for (int x = 0; x < DGContasTotal.ColumnCount; x++)
                    {
                        // obtém a célula na coluna x e linha i
                        celula = DGContasTotal[x, i];

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