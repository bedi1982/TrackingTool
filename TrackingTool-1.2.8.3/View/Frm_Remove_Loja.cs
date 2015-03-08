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
    public partial class Frm_Remove_loja : Form
    {
        Loja loja = new Loja();

        public void Frm_Remove_Loja()
        {
            InitializeComponent();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            loja.id = int.Parse(txtCod_Loja.Text);
            loja = LojaDAO.Procurar_Loja_por_numero(loja);

            if (loja != null)
            {
                txtCod_Loja.Text = loja.codigo_hiperfarma.ToString();

                //emprestado.id = int.Parse(txtbox_InsereID.Text);

                txt_nome_loja.Text = loja.nome;
                txt_loja_cnpj.Text = loja.CNPJ;
                txt_loja_cel.Text = loja.telefone;

                btn_remover_loja.Enabled = true;
                btn_limpar.Enabled = true;
            }
            else
            {
                txt_nome_loja.Text = "";
                txt_loja_cnpj.Text = "";
                txtCod_Loja.Text = "";
                txt_loja_cel.Text = "";
                btn_remover_loja.Enabled = false;
                btn_limpar.Enabled = false;
                txtCod_Loja.Focus();

                MessageBox.Show("Loja não Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_procurar_por_nome_Click_1(object sender, EventArgs e)
        {
            txt_nome_loja.Text = loja.nome;
            //Fornecedor fornecedor = new Fornecedor();
            loja = LojaDAO.Procurar_Loja_por_nome(loja);

            if (loja != null)
            {
                txtCod_Loja.Text = loja.id.ToString();
                
                loja.id = int.Parse(txtCod_Loja.Text);
                txt_nome_loja.Text = loja.nome;
                txt_loja_cnpj.Text = loja.CNPJ;
                txt_loja_cel.Text = loja.telefone;

                btn_remover_loja.Enabled = true;
                btn_limpar.Enabled = true;
            }
            else
            {
                txt_nome_loja.Text = "";
                txt_loja_cnpj.Text = "";
                txtCod_Loja.Text = "";
                txt_loja_cel.Text = "";
                btn_remover_loja.Enabled = false;
                btn_limpar.Enabled = false;
                txtCod_Loja.Focus();

                MessageBox.Show("Loja não Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_loja.Text = "";
            txt_loja_cnpj.Text = "";
            txtCod_Loja.Text = "";
            txt_loja_cel.Text = "";
            btn_remover_loja.Enabled = false;
            btn_limpar.Enabled = false;
            txtCod_Loja.Focus();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_remover_loja_Click(object sender, EventArgs e)
        {
            LojaDAO.Remove_Loja(loja);
        }
    }
}