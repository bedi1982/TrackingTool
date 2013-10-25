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
    public partial class Frm_Listar_Contas_Pagar : Form
    {
        public Frm_Listar_Contas_Pagar()
        {
            InitializeComponent();
            double total = 0;
            banco db = SingletonObjectContext.Instance.Context;
            DGContasAPagar.Rows.Clear();
            foreach (ContaAPagar x in db.ContaAPagar)
            {
                if (x.status == false)
                {
                    DGContasAPagar.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.tipo, x.descricao, x.centroCusto, x.valor);
                    total += x.valor;
                }
            }
            TxtTotalPagar.Text = total.ToString();

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta conta será excluida do sistema, está correto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row = DGContasAPagar.CurrentRow.Index;
                //Remove a conta do grid e do Tracking
                ContaAPagar conta_pagar = new ContaAPagar();

                conta_pagar.id = int.Parse(DGContasAPagar.Rows[row].Cells[0].Value.ToString());
                conta_pagar = ContaPagarDAO.Procurar_Conta_por_id(conta_pagar);

                ContaPagarDAO.ExcluirContaPagar(conta_pagar);
                DGContasAPagar.Rows.Remove(DGContasAPagar.Rows[row]);
                MessageBox.Show("Conta Removida");
            }
        }

        private void BtnContaPaga_Click(object sender, EventArgs e)
        {

            int row;
            double valor;
            string centro;

            //row recebe a linha onde está a conta
            row = DGContasAPagar.CurrentRow.Index;
            valor = double.Parse(DGContasAPagar.Rows[row].Cells[9].Value.ToString());
            centro = DGContasAPagar.Rows[row].Cells[8].Value.ToString();

            //Procura o centro de custo a partir da linha selecionada

            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = centro;
            centro_de_custo = Centro_de_CustoDAO.Procurar_Centro(centro_de_custo);

            ContaAPagar contaPagar = new ContaAPagar();
            contaPagar.id = int.Parse(DGContasAPagar.Rows[row].Cells[0].Value.ToString());

            contaPagar = ContaPagarDAO.Procurar_Conta_por_id(contaPagar);

            //A conta que foi recebida é alterada o status para true no banco
            //para depois poder ser feito o relatório


            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Existe alguma alteração no valor da conta?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {



                LblNovoValor.Visible = true;
                TxtNovoValor.Visible = true;
                BtnOK.Visible = true;


                BtnExcluir.Enabled = false;
                BtnContaPaga.Enabled = false;


            }

            else
            {

                if (dialog == DialogResult.No)
                {

                    //A conta que foi recebida recebe o status de true == paga;

                    //O valor é retirado do centro de custo e faz o update no banco
                    if (centro_de_custo.saldo > valor)
                    {
                        centro_de_custo.saldo -= valor;
                        Centro_de_CustoDAO.AdicionaValorAoCDC(centro_de_custo);

                        ContaPagarDAO.PagarConta(contaPagar);
                        //Remove a conta do grid
                        DGContasAPagar.Rows.Remove(DGContasAPagar.Rows[row]);

                        MessageBox.Show("Conta Paga com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Este centro de custo não tem saldo suficiente para aceitar o pagamento desta conta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }


        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int row;
            string centro;
            
            //row recebe a linha onde está a conta
            row = DGContasAPagar.CurrentRow.Index;

            centro = DGContasAPagar.Rows[row].Cells[8].Value.ToString();

            //Procura o centro de custo a partir da linha selecionada

            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = centro;
            centro_de_custo = Centro_de_CustoDAO.Procurar_Centro(centro_de_custo);

            //Remove a conta do grid e do Tracking

            ContaAPagar contaPagar = new ContaAPagar();
            contaPagar.id = int.Parse(DGContasAPagar.Rows[row].Cells[0].Value.ToString());
            contaPagar = ContaPagarDAO.Procurar_Conta_por_id(contaPagar);
            contaPagar.valor = double.Parse(TxtNovoValor.Text.ToString());

            if (centro_de_custo.saldo > contaPagar.valor)
            {

                //A conta que foi recebida recebe o status de true == pagar;
                contaPagar.status = true;
                centro_de_custo.saldo -= contaPagar.valor;
                Centro_de_CustoDAO.AdicionaValorAoCDC(centro_de_custo);
                ContaPagarDAO.PagarConta(contaPagar);

                DGContasAPagar.Rows.Remove(DGContasAPagar.Rows[row]);

                MessageBox.Show("Conta com valor alterado e paga com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
            
                MessageBox.Show("Este centro de custo não tem saldo suficiente para aceitar o pagamento desta conta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            LblNovoValor.Visible = false;
            TxtNovoValor.Visible = false;
            BtnOK.Visible = false;


            BtnExcluir.Enabled = true;
            BtnContaPaga.Enabled = true;
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            double total = 0;
            banco db = SingletonObjectContext.Instance.Context;
            DGContasAPagar.Rows.Clear();
            foreach (ContaAPagar x in db.ContaAPagar)
            {
                if (x.status == false)
                {
                    DGContasAPagar.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.tipo,x.descricao, x.centroCusto, x.valor);
                    total += x.valor;
                }
            }
            TxtTotalPagar.Text = total.ToString();
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
                xlWorkSheet.Cells[2, 13] = TxtTotalPagar.Text.ToString();
                xlWorkSheet.Cells[1, 16] = "Relatório Gerado em:";
                xlWorkSheet.Cells[2, 16] = DateTime.Now;

                DataGridViewCell celula = null;
                

                // vamos percorrer as linhas
                for (int i = 0; i < DGContasAPagar.RowCount; i++)
                {
                // vamos percorrer as colunas de cada linha
                    for (int x = 0; x < DGContasAPagar.ColumnCount; x++)
                    {
                        // obtém a célula na coluna x e linha i
                        celula = DGContasAPagar[x, i];

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
    

