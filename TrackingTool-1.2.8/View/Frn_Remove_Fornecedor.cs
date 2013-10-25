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

namespace Tracking.View
{
    public partial class Frn_Remove_Fornecedor : Form
    {
        Fornecedor fornecedor = new Fornecedor();

        public Frn_Remove_Fornecedor()
        {
            InitializeComponent();
            btn_remover.Enabled = false;
        }

        //TODO aqui temos duas funções de busca sendo que uma seria suficiente com if()else()
        //TODO adicionar excessoes para campos vazios
        
        //Procura fornecedor por ID
        private void btn_procurar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            if (txtCod_Forn.Text == "")
            {
                MessageBox.Show("O Código do fornecedor não pode estar em branco para fazer a procura", "Aviso");
            }
            else
            {
                fornecedor.codigo_hiperfarma = txtCod_Forn.Text;
                fornecedor = FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(fornecedor);

                
                if ((fornecedor != null) && (fornecedor.status == true))
                {
                    txt_Nome_forn.Text = "";
                    txt_Cnpj_forn.Text = "";
                    txtCod_Forn.Text = "";
                    txt_tel_contato_forn.Text = "";

                    txtCod_Forn.Text = fornecedor.codigo_hiperfarma.ToString();
                    txt_Nome_forn.Text = fornecedor.nome;
                    txt_Cnpj_forn.Text = fornecedor.CNPJ;
                    txt_tel_contato_forn.Text = fornecedor.telefoneRes;
                    btn_remover.Enabled = true;
                    btn_limpar.Enabled = true;
                }
                else
                {
                    btn_remover.Enabled = false;
                    btn_limpar.Enabled = true;
                    txtCod_Forn.Focus();

                    MessageBox.Show("Fornecedor não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_procurar_por_nome_Click_1(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.nome = txt_Nome_forn.Text;
            fornecedor = FornecedorDAO.Procurar_Fornecedor_por_nome(fornecedor);
            if (txt_Nome_forn.Text == "")
            {
                MessageBox.Show("O nome do fornecedor não pode estar em branco para fazer a procura", "Aviso");
            }
            else
            {
                if ((fornecedor != null) && (fornecedor.status == true))
                {

                    txt_Nome_forn.Text = "";
                    txt_Cnpj_forn.Text = "";
                    txtCod_Forn.Text = "";
                    txt_tel_contato_forn.Text = "";
                    
                    
                    txt_Nome_forn.Text = fornecedor.nome;
                    txt_Cnpj_forn.Text = fornecedor.CNPJ;
                    txt_tel_contato_forn.Text = fornecedor.telefoneRes;
                    btn_remover.Enabled = true;
                    btn_limpar.Enabled = true;
                }
                else
                {
                    

                    btn_remover.Enabled = false;
                    btn_limpar.Enabled = true;
                    txtCod_Forn.Focus();

                    MessageBox.Show("Fornecedor não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            Fornecedor forn = new Fornecedor();
            forn.codigo_hiperfarma = txtCod_Forn.Text;
            forn = FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(forn);

            FornecedorDAO.Remove_Fornecedor(forn);
            txt_Nome_forn.Text = "";
            txt_Cnpj_forn.Text = "";
            txtCod_Forn.Text = "";
            txt_tel_contato_forn.Text = "";
            txt_Nome_forn.Focus();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
                Close();
        }
    }
}