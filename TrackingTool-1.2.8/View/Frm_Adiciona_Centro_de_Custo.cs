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
    public partial class Frm_Adiciona_Centro_de_Custo : Form
    {
        public Frm_Adiciona_Centro_de_Custo()
        {
            InitializeComponent();
            
        }

        private void btn_adicionar_centro_de_custo_Click(object sender, EventArgs e)
        {
            CentroDeCusto  centro_de_custo = new CentroDeCusto();
            if (txtNome_CDC.Text == "" || txt_descricaoCDC.Text == "" || TxtSaldo.Text == "" || txt_numeroCDC.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios, certifiqui-se que todos os campos foram preenchidos corretamente", "Aviso");
            }
            else
            {
                centro_de_custo.nome = txtNome_CDC.Text;
                centro_de_custo.descricao = txt_descricaoCDC.Text;
                centro_de_custo.codigo_hiperfarma = txt_numeroCDC.Text;
                centro_de_custo.status = true;
                centro_de_custo.saldo = double.Parse(TxtSaldo.Text);

                Centro_de_CustoDAO.AdicionaCentroDeCusto(centro_de_custo);

                //limpa campos e foca em nome://
                txtNome_CDC.Text = "";
                txt_descricaoCDC.Text = "";
                txt_numeroCDC.Text = "";
                txtNome_CDC.Focus();
                TxtSaldo.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;


            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127 && asc != 44 && asc != 46)
            {

                e.Handled = true;
                MessageBox.Show("O Campo Valor aceita apenas números virgulas e pontos");

            }
        }

        
    }
}
