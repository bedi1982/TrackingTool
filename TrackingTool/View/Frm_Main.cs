using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrackingTool6.View;


namespace TrackingTool6.View
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

        private void removerToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_listar_CDC listar_cdc = new Frm_listar_CDC();
            listar_cdc.Show();
        }

    }
}