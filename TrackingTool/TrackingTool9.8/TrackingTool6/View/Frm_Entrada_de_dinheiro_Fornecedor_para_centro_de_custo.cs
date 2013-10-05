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
    public partial class Frm_Entrada_de_dinheiro_Fornecedor_para_centro_de_custo : Form
    {
        public Frm_Entrada_de_dinheiro_Fornecedor_para_centro_de_custo()
        {
            InitializeComponent();
            btn_confirma_repasse.Enabled = false;
        }

        private void btn_procurar_por_nome_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.nome = txt_Nome_forn.Text;

            fornecedor = FornecedorDAO.Procurar_Fornecedor_por_nome(fornecedor);

            if (fornecedor != null)
            {
                txt_Nome_forn.Text = fornecedor.nome;
                txt_cod_forn.Text = fornecedor.id.ToString();
                txt_Cnpj_forn.Text = fornecedor.CNPJ;
                txt_Celular_forn.Text = fornecedor.telefoneCel;
                
                
            }
            else
            {
                txt_Nome_forn.Text = "";
                txt_Cnpj_forn.Text = "";
                txt_Celular_forn.Text = "";
                MessageBox.Show("Centro de Custo não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_confirma_repasse.Enabled = false;
            }
        }

        private void btn_procurar_centro_de_custo_Click(object sender, EventArgs e)
        {
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = txt_cdc_procurar.Text;

            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo));

            if (centro_de_custo != null)
            {
                txt_cdc_procurar.Text = centro_de_custo.nome;
                txt_cdc_telefone.Text = centro_de_custo.telefone;
                txt_cdc_saldo_atual.Text = centro_de_custo.saldo.ToString();
            }
            else
            {
                txt_cdc_procurar.Text = "";
                txt_cdc_telefone.Text = "";
                txt_cdc_saldo_atual.Text = "";
                MessageBox.Show("Centro de Custo não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btn_confirma_repasse.Enabled = false;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
