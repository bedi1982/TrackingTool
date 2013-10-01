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
    public partial class Frm_Adiciona_Centro_de_Custo : Form
    {
        public Frm_Adiciona_Centro_de_Custo()
        {
            InitializeComponent();
        }

        private void btn_adicionar_centro_de_custo_Click(object sender, EventArgs e)
        {
            CentroDeCusto  centro_de_custo = new CentroDeCusto();

            centro_de_custo.nome = txtNome_CDC.Text;
            centro_de_custo.CNPJ = txtCnpj_CDC.Text;
            centro_de_custo.telefone = txtTel_CDC.Text;
            centro_de_custo.rua = txt_RuaCDC.Text;
            centro_de_custo.bairro = txt_bairroCDC.Text;
            centro_de_custo.numero = int.Parse(txt_numeroCDC.Text);
            centro_de_custo.saldo = float.Parse(txt_saldo_inicialCDC.Text);

            Centro_de_CustoDAO.AdicionaCentroDeCusto(centro_de_custo);

            //limpa campos e foca em nome://
            txtNome_CDC.Text = "";
            txtCnpj_CDC.Text = "";
            txtTel_CDC.Text = "";
            txt_RuaCDC.Text = "";
            txt_bairroCDC.Text = "";
            txt_numeroCDC.Text = "";
            txt_saldo_inicialCDC.Text = "";

            txtNome_CDC.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
