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
    public partial class Frm_Adicionar_Loja : Form
    {
        public Frm_Adicionar_Loja()
        {
            InitializeComponent();
        }

        private void btn_adicionar_loja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();

            loja.nome = txtNome_loja.Text;
            loja.CNPJ = txtCnpj_loja.Text;
            loja.telefone = txtTel_loja.Text;
            loja.rua = txt_Rua_Loja.Text;
            loja.bairro = txt_bairro_loja.Text;
            loja.codigo_hiperfarma = int.Parse(txt_numero_loja.Text);
            loja.saldo = float.Parse(txt_saldo_inicial.Text);
            loja.status = true;

            LojaDAO.AdicionaLojaEF(loja);

            //limpa campos e foca em nome://
            txtNome_loja.Text = "";
            txtCnpj_loja.Text = "";
            txtTel_loja.Text = "";
            txt_Rua_Loja.Text = "";
            txt_bairro_loja.Text = "";
            txt_numero_loja.Text = "";
            txt_saldo_inicial.Text = "";

            txtNome_loja.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}