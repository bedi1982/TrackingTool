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
using Excel = Microsoft.Office.Interop.Excel; 

namespace Tracking.View
{
    public partial class Frm_Listar_Contas_Receber : Form
    {
        public Frm_Listar_Contas_Receber()
        {
            InitializeComponent();
            double total = 0;
            banco db = SingletonObjectContext.Instance.Context;
            DGContasReceber.Rows.Clear();
            foreach (ContaReceber x in db.ContaReceber)
            {
                if (x.status == false)
                {
                    DGContasReceber.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor);
                    total += x.valor;
                }
            }
            TxtTotalReceber.Text = total.ToString();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DGContasReceber.RowCount == 1)
            {
                MessageBox.Show("A lista de contas está vazia, nada a remover.");
            }
            else
            {
                if (MessageBox.Show("Esta conta será excluida do sistema, está correto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int row = DGContasReceber.CurrentRow.Index;
                    //Remove a conta do grid e do Tracking
                    ContaReceber conta_receber = new ContaReceber();

                    conta_receber.id = int.Parse(DGContasReceber.Rows[row].Cells[0].Value.ToString());
                    conta_receber = ContaReceberDAO.Procurar_Conta_por_id(conta_receber);

                    ContaReceberDAO.ExcluirContaReceber(conta_receber);
                    DGContasReceber.Rows.Remove(DGContasReceber.Rows[row]);
                    MessageBox.Show("Conta Removida");
                }
            }

        }

        private void BtnContaRecebida_Click(object sender, EventArgs e)
        {
            int row;
            double valor;
            string centro;
            try
            {
                //row recebe a linha onde está a conta
                row = DGContasReceber.CurrentRow.Index;
                valor = double.Parse(DGContasReceber.Rows[row].Cells[9].Value.ToString());
                centro = DGContasReceber.Rows[row].Cells[8].Value.ToString();

                //Procura o centro de custo a partir da linha selecionada

                CentroDeCusto centro_de_custo = new CentroDeCusto();
                centro_de_custo.nome = centro;
                centro_de_custo = Centro_de_CustoDAO.Procurar_Centro(centro_de_custo);

                //Remove a conta do grid 

                ContaReceber contareceber = new ContaReceber();
                contareceber.id = int.Parse(DGContasReceber.Rows[row].Cells[0].Value.ToString());

                contareceber = ContaReceberDAO.Procurar_Conta_por_id(contareceber);
                
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
                    BtnContaRecebida.Enabled = false;



                }
                else
                {
                    if (dialog == DialogResult.No)
                    {
                        //A conta que foi recebida recebe o status de true == recebida;

                        //O centro de custo recebe o valor a ser creditado e faz o update no Tracking
                        centro_de_custo.saldo += valor;
                        Centro_de_CustoDAO.AdicionaValorAoCDC(centro_de_custo);
                        contareceber.dataRecebe = DateTime.Now;
                        ContaReceberDAO.ReceberConta(contareceber);
                        //Remove a conta do grid
                        DGContasReceber.Rows.Remove(DGContasReceber.Rows[row]);

                        MessageBox.Show("Conta Recebida com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch
            {
                MessageBox.Show("É necessário primeiramente selecionar uma conta a ser recebida", " Aviso");
            }
                
                
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int row;
            string centro;

            //row recebe a linha onde está a conta
            row = DGContasReceber.CurrentRow.Index;

            centro = DGContasReceber.Rows[row].Cells[8].Value.ToString();

            //Procura o centro de custo a partir da linha selecionada

            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = centro;
            centro_de_custo = Centro_de_CustoDAO.Procurar_Centro(centro_de_custo);

            //Remove a conta do grid e do Tracking

            ContaReceber contareceber = new ContaReceber();
            contareceber.id = int.Parse(DGContasReceber.Rows[row].Cells[0].Value.ToString());
            contareceber = ContaReceberDAO.Procurar_Conta_por_id(contareceber);

            //A conta que foi recebida recebe o status de true == recebida;
            contareceber.status = true;
            contareceber.valor = double.Parse(TxtNovoValor.Text.ToString());
            contareceber.dataRecebe = DateTime.Now;
            
            centro_de_custo.saldo += double.Parse(TxtNovoValor.Text.ToString());
            Centro_de_CustoDAO.AdicionaValorAoCDC(centro_de_custo);
            ContaReceberDAO.ReceberConta(contareceber);

            DGContasReceber.Rows.Remove(DGContasReceber.Rows[row]);

            MessageBox.Show("Conta com valor alterado e recebida com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LblNovoValor.Visible = false;
            TxtNovoValor.Visible = false;
            BtnOK.Visible = false;


            BtnExcluir.Enabled = true;
            BtnContaRecebida.Enabled = true;

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            //Atualiza o valor total a receber
            double total = 0;
            banco db = SingletonObjectContext.Instance.Context;
            DGContasReceber.Rows.Clear();
            foreach (ContaReceber x in db.ContaReceber)
            {
                if (x.status == false)
                {
                    DGContasReceber.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor);
                    total += x.valor;
                }
            }
            TxtTotalReceber.Text = total.ToString();
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
                xlWorkSheet.Cells[1, 7] = "Descrição da Conta";
                xlWorkSheet.Cells[1, 8] = "Tipo";
                xlWorkSheet.Cells[1, 9] = "Centro de Custo";
                xlWorkSheet.Cells[1, 10] = "Valor R$";
                
                xlWorkSheet.Cells[1, 13] = "Valor Total a Receber R$";
                xlWorkSheet.Cells[2, 13] = TxtTotalReceber.Text.ToString();
                xlWorkSheet.Cells[1, 16] = "Relatório Gerado em:";
                xlWorkSheet.Cells[2, 16] = DateTime.Now;

                DataGridViewCell celula = null;
                

                // vamos percorrer as linhas
                for (int i = 0; i < DGContasReceber.RowCount; i++)
                {
                // vamos percorrer as colunas de cada linha
                    for (int x = 0; x < DGContasReceber.ColumnCount; x++)
                    {
                        // obtém a célula na coluna x e linha i
                        celula = DGContasReceber[x, i];

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

