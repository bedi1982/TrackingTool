using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Tracking.Model;
using Tracking.Controler;
using Tracking.Tool;

using System.Windows.Forms;

namespace Tracking.View
{
    public partial class Frm_Editar_CentroCusto : Form
    {
        public Frm_Editar_CentroCusto()
        {
            InitializeComponent();
        }

        private void BtnProcuraFornecedor_Click(object sender, EventArgs e)
        {
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = TxtProcuraCentro.Text;
            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo));

            if (centro_de_custo != null)
            {
                TxtSaldo.Text = centro_de_custo.saldo.ToString();
                txtNome_CDC.Text = centro_de_custo.nome.ToString();
                txt_descricaoCDC.Text = centro_de_custo.descricao.ToString();
                txt_numeroCDC.Text = centro_de_custo.codigo_hiperfarma.ToString();
                
            }
            else
            {
                MessageBox.Show("Centro de Custo não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnSalvarCDC_Click(object sender, EventArgs e)
        {
            CentroDeCusto centro = new CentroDeCusto();

            if (txtNome_CDC.Text == "" || txt_descricaoCDC.Text == "" || TxtSaldo.Text == "" || txt_numeroCDC.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios, certifiqui-se que todos os campos foram preenchidos corretamente", "Aviso");
            }
            else
            {


                centro.nome = TxtProcuraCentro.Text.ToString();

                centro = Centro_de_CustoDAO.Procurar_CDC_por_nome(Centro_de_CustoDAO.Procurar_CDC_por_nome(centro));
                try
                {
                    centro.nome = txtNome_CDC.Text.ToString();
                    centro.descricao = txt_descricaoCDC.Text.ToString();
                    centro.saldo = double.Parse(TxtSaldo.Text.ToString());
                    centro.codigo_hiperfarma = txt_numeroCDC.Text.ToString();

                    Centro_de_CustoDAO.EditarCentro(centro);
                    MessageBox.Show("Centro de Custos editado com sucesso");
                }

                catch
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtProcuraCentro.Clear();
            txtNome_CDC.Clear();
            txt_numeroCDC.Clear();
            TxtSaldo.Clear();
            txt_descricaoCDC.Clear();
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
