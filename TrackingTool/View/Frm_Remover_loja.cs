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
    public partial class Frm_Remover_loja : Form
    {
        Loja loja = new Loja();

        public Frm_Remover_loja()
        {
            InitializeComponent();
            btn_remover.Enabled = false;
            btn_limpar.Enabled = false;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btn_procurar_por_nome_Click(object sender, EventArgs e)
        {
            if (txt_Nome_loja.Text == "")
            {
                MessageBox.Show("O Nome da loja não pode estar em branco para fazer a procura", "Aviso");
            }
            else
            {
                Loja loja = new Loja();

                loja.nome = txt_Nome_loja.Text;
                loja = LojaDAO.Procurar_Loja_por_nome(loja);

                if ((loja != null) && (loja.status == true))
                {
                    txt_Nome_loja.Text = "";
                    txt_Cnpj_loja.Text = "";
                    txtCod_Loja.Text = "";
                    txt_tel_contato_loja.Text = "";

                    txtCod_Loja.Text = loja.codigo_hiperfarma;
                    txt_Nome_loja.Text = loja.nome;
                    txt_Cnpj_loja.Text = loja.CNPJ;
                    txt_tel_contato_loja.Text = loja.telefone;

                    btn_remover.Enabled = true;
                    btn_limpar.Enabled = true;
                }
                else
                {
                    txt_Nome_loja.Text = "";
                    txt_Cnpj_loja.Text = "";
                    txtCod_Loja.Text = "";
                    txt_tel_contato_loja.Text = "";
                    btn_remover.Enabled = false;
                    btn_limpar.Enabled = false;
                    txtCod_Loja.Focus();

                    MessageBox.Show("Loja não Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_Nome_loja.Text = "";
            txt_Cnpj_loja.Text = "";
            txtCod_Loja.Text = "";
            txt_tel_contato_loja.Text = "";
            btn_remover.Enabled = false;
            btn_limpar.Enabled = false;
            txtCod_Loja.Focus();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            loja.codigo_hiperfarma = txtCod_Loja.Text;
            loja = LojaDAO.Procurar_Loja_por_codigo_hiperfarma(loja);
            
            LojaDAO.Remove_Loja(loja);

            //Limpar campos://
            txt_Nome_loja.Text = "";
            txt_Cnpj_loja.Text = "";
            txtCod_Loja.Text = "";
            txt_tel_contato_loja.Text = "";
            btn_remover.Enabled = false;
            btn_limpar.Enabled = false;
            txtCod_Loja.Focus();
        }

        private void btn_procurar_por_codigo_Click(object sender, EventArgs e)
        {
            if (txtCod_Loja.Text == "")
            {
                MessageBox.Show("O Código da loja não pode estar em branco para fazer a procura", "Aviso");
            }
            else
            {

                Loja loja = new Loja();

                loja.codigo_hiperfarma = txtCod_Loja.Text;
                loja = LojaDAO.Procurar_Loja_por_codigo_hiperfarma(loja);

                if (loja != null && loja.status == true)
                {
                    btn_remover.Enabled = true;
                    btn_limpar.Enabled = true;

                    txt_Cnpj_loja.Clear();
                    txt_Nome_loja.Clear();
                    txt_tel_contato_loja.Clear();
                    txtCod_Loja.Clear();

                    txt_Nome_loja.Text = loja.nome;
                    txt_Cnpj_loja.Text = loja.CNPJ;
                    txt_tel_contato_loja.Text = loja.telefone;
                    txtCod_Loja.Text = loja.codigo_hiperfarma;

                }
                else
                {
                    btn_remover.Enabled = false;
                    txt_Cnpj_loja.Clear();
                    txt_Nome_loja.Clear();
                    txt_tel_contato_loja.Clear();
                    txtCod_Loja.Clear();
                    MessageBox.Show("Loja não encontrada", "Aviso");
                }
            }
        }
    }
}
