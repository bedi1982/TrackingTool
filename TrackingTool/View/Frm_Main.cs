using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tracking.View;
using Tracking.Controler;


namespace Tracking.View
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
                InitializeComponent();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Adiciona_Fornecedor novo_forn = new Frm_Adiciona_Fornecedor();
            novo_forn.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frn_Remove_Fornecedor novo_forn = new Frn_Remove_Fornecedor();
            novo_forn.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Listar_Fornecedores novo_forn = new Frm_Listar_Fornecedores();
            novo_forn.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Adicionar_Loja novo_forn = new Frm_Adicionar_Loja();
            novo_forn.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Listar_Lojas novo_forn = new Frm_Listar_Lojas();
            novo_forn.Show();
        }

        private void adiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Adiciona_Centro_de_Custo novo_CDC = new Frm_Adiciona_Centro_de_Custo();
            novo_CDC.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddCentroCusto_Click(object sender, EventArgs e)
        {
            Frm_Adiciona_Centro_de_Custo novo_CDC = new Frm_Adiciona_Centro_de_Custo();
            novo_CDC.Show();
        }

        private void BtnAddFornecedor_Click(object sender, EventArgs e)
        {
            Frm_Adiciona_Fornecedor novo_forn = new Frm_Adiciona_Fornecedor();
            novo_forn.Show();
        }

        private void BtnListFornecedores_Click(object sender, EventArgs e)
        {
            Frm_Listar_Fornecedores novo_forn = new Frm_Listar_Fornecedores();
            novo_forn.Show();
        }

        private void BtnAddLoja_Click(object sender, EventArgs e)
        {
            Frm_Adicionar_Loja novo_forn = new Frm_Adicionar_Loja();
            novo_forn.Show();
        }

        private void BtnListLojas_Click(object sender, EventArgs e)
        {
            Frm_Listar_Lojas novo_forn = new Frm_Listar_Lojas();
            novo_forn.Show();
        }

        private void BtnAddContasReceber_Click(object sender, EventArgs e)
        {
            Frm_add_conta_receber add_conta_recebe = new Frm_add_conta_receber();
            add_conta_recebe.Show();
        }

        private void BtnAddContasPagar_Click(object sender, EventArgs e)
        {
            Frm_Add_Conta_Pagar add_conta_pagar = new Frm_Add_Conta_Pagar();
            add_conta_pagar.Show();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listar_CDC listar_cdc = new Frm_listar_CDC();
            listar_cdc.Show();
        }

        private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Remover_loja remove_loja = new Frm_Remover_loja();
            remove_loja.Show();
        }

        private void btn_atualizar_balanco_Click(object sender, EventArgs e)
        {
            txt_a_receber.Text = "Aguarde...";
            txt_a_pagar.Text = "Aguarde...";
            txt_cdc_total.Text = "Aguarde...";

            double receber = ContaReceberDAO.Retorna_a_receber_total();
            txt_a_receber.Text = receber.ToString();

            double pagar = ContaPagarDAO.Retorna_a_pagar_total();
            txt_a_pagar.Text = pagar.ToString();

            double total_cdcs = Centro_de_CustoDAO.valor_total_em_todos_osCDC();
            txt_cdc_total.Text = total_cdcs.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_listar_CDC listar_cdc = new Frm_listar_CDC();
            listar_cdc.Show();
        }

        private void BtnContaReceber_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Listar_Contas_Receber contasRecebe = new Frm_Listar_Contas_Receber();
                contasRecebe.Show();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void BtnContasAPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Listar_Contas_Pagar contasPagar = new Frm_Listar_Contas_Pagar();
                contasPagar.Show();
            }
            catch
            {
                MessageBox.Show("Erro.");
            }

        }

        private void BtnContasRecebidas_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Listar_Contas_Recebidas contasRecebidas = new Frm_Listar_Contas_Recebidas();
                contasRecebidas.Show();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void BtnContasPagas_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Contas_Pagas contasPagas = new Frm_Contas_Pagas();
                contasPagas.Show();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Editar_Fornecedor editforn = new Frm_Editar_Fornecedor();
            editforn.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Editar_Loja editLoja = new Frm_Editar_Loja();
            editLoja.Show();
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_Editar_CentroCusto editCentro = new Frm_Editar_CentroCusto();
            editCentro.Show();
        }

        private void Frm_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void saldoPorCentroDeCustoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listar_CDC listar_cdc = new Frm_listar_CDC();
            listar_cdc.Show();
        }

        private void ContasPorReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Listar_Contas_Receber contasRecebe = new Frm_Listar_Contas_Receber();
                contasRecebe.Show();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void contasPagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Contas_Pagas contasPagas = new Frm_Contas_Pagas();
                contasPagas.Show();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void ContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Listar_Contas_Pagar contasPagar = new Frm_Listar_Contas_Pagar();
                contasPagar.Show();
            }
            catch
            {
                MessageBox.Show("Erro.");
            }
        }

        private void contasRecebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Listar_Contas_Recebidas contasRecebidas = new Frm_Listar_Contas_Recebidas();
                contasRecebidas.Show();
            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void removerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_Remover_CDC remover = new Frm_Remover_CDC();
            remover.Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gerenciamento Financeiro para Redes Associativas de Farmácias\n\nEste software foi desenvolvido para o trabalho final do curso de Análise e Desenvolvimento de Sistemas da faculdade Positivo\n\nSoftware desenvolvido por:\n\nThiago Fontana Litcha\nSergio Rafael Lemke\nLeandro Kaizer\nLeandro Rafael da Silva\nGilson Waculicz\n\nDúvidas ou sugestões nos envie um email:\n\nthiagoftx@gmail.com\nbedi.com@gmail.com", "Sobre");
        }

        private void BtnTodasContas_Click(object sender, EventArgs e)
        {
            Frm_ContasTotal contas = new Frm_ContasTotal();
            contas.Show();
        }

        private void BtnMF_Click(object sender, EventArgs e)
        {
            Frm_Movimentacao_financeira mf = new Frm_Movimentacao_financeira();
            mf.Show();
        }
     }
}