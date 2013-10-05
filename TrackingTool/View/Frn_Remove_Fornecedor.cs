using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrackingTool6.Model;
using TrackingTool6.Controler;

namespace TrackingTool6.View
{
    public partial class Frn_Remove_Fornecedor : Form
    {
        Fornecedor fornecedor = new Fornecedor();

        public Frn_Remove_Fornecedor()
        {
            InitializeComponent();
        }

        //TODO aqui temos duas funções de busca sendo que uma seria suficiente com if()else()
        //TODO adicionar excessoes para campos vazios
        
        //Procura fornecedor por ID
        private void btn_procurar_Click(object sender, EventArgs e)
        {
            //Fornecedor fornecedor = new Fornecedor();
            fornecedor.codigo_hiperfarma = int.Parse(txtCod_Forn.Text);
            fornecedor = FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(fornecedor);

            if (fornecedor != null)
            {
                txtCod_Forn.Text = fornecedor.id.ToString();

                //emprestado.id = int.Parse(txtbox_InsereID.Text);

                txt_Nome_forn.Text = fornecedor.nome;
                txt_Cnpj_forn.Text = fornecedor.CNPJ;
                btn_remover.Enabled = true;
                btn_limpar.Enabled = true;
            }
            else
            {
                txt_Nome_forn.Text = "";
                txt_Cnpj_forn.Text = "";
                txtCod_Forn.Text = "";
                txt_tel_contato_forn.Text = "";

                btn_remover.Enabled = false;
                btn_limpar.Enabled = false;
                txtCod_Forn.Focus();

                MessageBox.Show("Fornecedor não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_procurar_por_nome_Click_1(object sender, EventArgs e)
        {
            fornecedor.nome = txt_Nome_forn.Text;
            //Fornecedor fornecedor = new Fornecedor();
            fornecedor = FornecedorDAO.Procurar_Fornecedor_por_nome(fornecedor);

            if (fornecedor != null)
            {
                txtCod_Forn.Text = fornecedor.id.ToString();

                txt_Nome_forn.Text = fornecedor.nome;
                txt_Cnpj_forn.Text = fornecedor.CNPJ;
                txt_tel_contato_forn.Text = fornecedor.telefoneRes;
                btn_remover.Enabled = true;
                btn_limpar.Enabled = true;
            }
            else
            {
                txt_Nome_forn.Text = "";
                txt_Cnpj_forn.Text = "";
                txtCod_Forn.Text = "";
                txt_tel_contato_forn.Text = "";
                txt_tel_contato_forn.Text = "";

                btn_remover.Enabled = false;
                btn_limpar.Enabled = false;
                txtCod_Forn.Focus();

                MessageBox.Show("Fornecedor não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_Nome_forn.Text = "";
            txt_Cnpj_forn.Text = "";
            txtCod_Forn.Text = "";
            txt_tel_contato_forn.Text = "";

            btn_remover.Enabled = false;
            btn_limpar.Enabled = false;
            txtCod_Forn.Focus();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            FornecedorDAO.Remove_Fornecedor(fornecedor);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
                Close();
        }
    }
}