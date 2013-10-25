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
using Tracking.Tool;

namespace Tracking.View
{
    public partial class Frm_Remover_CDC : Form
    {
        public Frm_Remover_CDC()
        {
            InitializeComponent();
        }

        private void BtnProcuraCDC_Click(object sender, EventArgs e)
        {
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = txtNome_CDC.Text;
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

        private void btn_excluirCDC_Click(object sender, EventArgs e)
        {
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = txtNome_CDC.Text;
            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo));
            if (centro_de_custo != null)
            {
                Centro_de_CustoDAO.Remove_CDC(centro_de_custo);
                TxtSaldo.Clear();
                txtNome_CDC.Clear();
                txt_descricaoCDC.Clear();
                txt_numeroCDC.Text = "";

                
            }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }

        }

        
    }
}
