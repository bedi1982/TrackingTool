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
    public partial class Frm_Remove_CDC : Form
    {
        CentroDeCusto centrodecusto = new CentroDeCusto();

        public void Frn_Remove_CDC()
        {
            InitializeComponent();
        }

        private void btn_procurar_por_nome_Click_1(object sender, EventArgs e)
        {
            centrodecusto.nome = txt_Nome_cdc.Text;
            centrodecusto = Centro_de_CustoDAO.Procurar_CDC_por_nome(centrodecusto);

            if (centrodecusto != null)
            {
                txt_Nome_cdc.Text = centrodecusto.nome.ToString();
                txt_descricao_cdc.Text = centrodecusto.descricao.ToString();
                txt_saldoAtual_cdc.Text = centrodecusto.saldo.ToString();
                btn_remover_cdc.Enabled = true;
                btn_limpar.Enabled = true;
            }
            else
            {
                txt_Nome_cdc.Text = "";
                txt_descricao_cdc.Text = "";
                txt_numero_cdc.Text = "";
                txt_saldoAtual_cdc.Text = "";

                btn_remover_cdc.Enabled = false;
                btn_limpar.Enabled = false;
                txt_Nome_cdc.Focus();

                MessageBox.Show("Centro de Custo não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_Nome_cdc.Text = "";
            txt_descricao_cdc.Text = "";
            txt_numero_cdc.Text = "";
            txt_saldoAtual_cdc.Text = "";

            btn_remover_cdc.Enabled = false;
            btn_limpar.Enabled = false;
            txt_Nome_cdc.Focus();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            Centro_de_CustoDAO.Remove_CDC(centrodecusto);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}