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
            centro_de_custo.descricao = txt_descricaoCDC.Text;
            centro_de_custo.codigo_hiperfarma = int.Parse(txt_numeroCDC.Text);
            centro_de_custo.status = true;

            //Sempre inicia com saldo 0:
            centro_de_custo.saldo = '0';

            Centro_de_CustoDAO.AdicionaCentroDeCusto(centro_de_custo);

            //limpa campos e foca em nome://
            txtNome_CDC.Text = "";
            txt_descricaoCDC.Text = "";
            txt_numeroCDC.Text = "";
            txtNome_CDC.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
