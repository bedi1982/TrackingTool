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
    public partial class Frm_add_conta_receber : Form
    {
        public Frm_add_conta_receber()
        {
            InitializeComponent();
            try
            {
                banco db = SingletonObjectContext.Instance.Context;
                foreach (ContaReceber x in db.ContaReceber)
                {
                    if (x.status == false)
                    {
                        GridContasReceber.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Você precisa cadastrar no mínimo uma Loja e um Centro de Custo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = TxtCentroCusto.Text;
            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo);

            if (centro_de_custo != null)
            {
                TxtCentroCusto.Text = centro_de_custo.nome;
                TxtSaldo.Text = centro_de_custo.saldo.ToString();
                BtnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Centro de Custo não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ContaReceber contaRecebe = new ContaReceber();

            if (TxtValor.Text == "")
            {
                MessageBox.Show("O Campo Valor do Título é obrigatório");
            }
            else
            {
                if (TxtCentroCusto.Text == "")
                {
                    MessageBox.Show("O Campo Centro de Custo é obrigatório");
                }

                else
                {

                    contaRecebe.valor = Double.Parse(TxtValor.Text);
                    contaRecebe.descricao = TxtDescricao.Text;
                    contaRecebe.dataRecebe = DataCadastro.Value.Date;
                    contaRecebe.dataCadastrado = DateTime.Now;
                    contaRecebe.centroCusto = TxtCentroCusto.Text;
                    contaRecebe.codigo = TxtCodigo.Text;
                    contaRecebe.tipo = CBTipo.Text;
                    
                    

                    if (TxtLojaDescricao.Text.Length == 0)
                    {
                        contaRecebe.loja = "---";
                    }
                    else
                    {
                        contaRecebe.loja = TxtLojaDescricao.Text;
                    }

                    if (TxtDescricaoForn.Text.Length == 0)
                    {
                        contaRecebe.fornecedor = "---";
                    }
                    else
                    {
                        contaRecebe.fornecedor = TxtDescricaoForn.Text;
                    }


                    try
                    {
                        ContaReceberDAO.AdicionaContaReceber(contaRecebe);
                        MessageBox.Show("Conta Adicionada ao Banco");

                        TxtCentroCusto.Clear();
                        TxtSaldo.Clear();
                        TxtCodigo.Clear();
                        TxtLojaProcura.Clear();
                        TxtLojaDescricao.Clear();
                        TxtValor.Clear();
                        TxtDescricao.Clear();
                        TxtDescricaoForn.Clear();
                        TxtProcurarForn.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Conta Não Adicionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Após adicionar a conta, ele automaticamente atualiza o grid
                banco db = SingletonObjectContext.Instance.Context;
                GridContasReceber.Rows.Clear();
                foreach (ContaReceber x in db.ContaReceber)
                {
                    if (x.status == false)
                    {
                        GridContasReceber.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor);
                    }
                }
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            banco db = SingletonObjectContext.Instance.Context;
            GridContasReceber.Rows.Clear();
            foreach (ContaReceber x in db.ContaReceber)
            {
                GridContasReceber.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor, x.descricao, x.tipo, x.centroCusto, x.valor);
            }
        }

        private void BtnProcuraLoja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            if (TxtLojaProcura.Text == "")
            {

                MessageBox.Show("O código da loja está em branco");

            }
            else
            {
                loja.codigo_hiperfarma = TxtLojaProcura.Text;
                loja = LojaDAO.Procurar_Loja_por_codigo_hiperfarma(loja);

                if (loja != null)
                {
                    TxtLojaDescricao.Text = loja.nome.ToString();
                }
                else
                {
                    MessageBox.Show("Loja não Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Erro aqui
            try
            {
                if (MessageBox.Show("Esta conta será excluida do sistema, está correto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int row = GridContasReceber.CurrentRow.Index;
                    //Remove a conta do grid e do Tracking
                    ContaReceber conta_receber = new ContaReceber();

                    conta_receber.id = int.Parse(GridContasReceber.Rows[row].Cells[0].Value.ToString());
                    conta_receber = ContaReceberDAO.Procurar_Conta_por_id(conta_receber);

                    ContaReceberDAO.ExcluirContaReceber(conta_receber);
                    GridContasReceber.Rows.Remove(GridContasReceber.Rows[row]);
                    MessageBox.Show("Conta Removida");
                }
            }
            catch
            {
                MessageBox.Show("Nem uma conta foi selecionada para excluir","Aviso");
            }
        }

        private void BtnProcurarForn_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            if (TxtProcurarForn.Text == "")
            {

                MessageBox.Show("O código do fornecedor está em branco");

            }
            else
            {
                forn.codigo_hiperfarma = TxtProcurarForn.Text;

                forn = FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(forn));

                if (forn != null)
                {
                    TxtDescricaoForn.Text = forn.nome.ToString();

                }
                else
                {
                    MessageBox.Show("Fornecedor não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;


            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127 && asc != 44 && asc != 46)
            {

                e.Handled = true;
                MessageBox.Show("O Campo Valor aceita apenas números virgulas e pontos");

            }
        }

        private void BtnLojasContas_Click(object sender, EventArgs e)
        {
            Frm_ListarLojasContas lojas = new Frm_ListarLojasContas();
            lojas.Show();
        }

        private void BtnFornContas_Click(object sender, EventArgs e)
        {
            Frm_ListarFornContas forn = new Frm_ListarFornContas();
            forn.Show();
        }

        

       

        /*
        private void BtnOK_Click(object sender, EventArgs e)
        {
            int row = GridContasReceber.CurrentRow.Index;

            ContaReceber conta_receber = new ContaReceber();

            conta_receber.id = int.Parse(GridContasReceber.Rows[row].Cells[0].Value.ToString());
            conta_receber = ContaReceberDAO.Procurar_Conta_por_id(conta_receber);

            ContaReceberDAO.ReceberConta(conta_receber);

            //Procura o centro de custo a partir da linha selecionada
            
            String centro;
            centro = GridContasReceber.Rows[row].Cells[4].Value.ToString();
            
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = centro;
            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo);
            
            Centro_de_CustoDAO.AdicionaValorAoCDC(centro_de_custo);
            //
            GridContasReceber.Rows.Remove(GridContasReceber.Rows[row]);
            

            MessageBox.Show("Conta com valor modificado", "Aviso");
            MessageBox.Show("Conta Recebida com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

           

            TxtCentroCusto.Enabled = true;
            TxtCodigo.Enabled = true;
            TxtLojaProcura.Enabled = true;
            TxtValor.Enabled = true;
            TxtDescricao.Enabled = true;
            DataCadastro.Enabled = true;
            TxtDescricao.Enabled = true;

            BtnProcurar.Enabled = true;
            CBTipo.Enabled = true;
            BtnProcuraLoja.Enabled = true;
            BtnAdd.Enabled = true;
            BtnAtualizar.Enabled = true;
            BtnContaRecebida.Enabled = true;
            BtnExcluir.Enabled = true;
        }*/
    }
}