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
    public partial class Frm_Repasse_de_fornecedor_para_loja : Form
    {
        public Frm_Repasse_de_fornecedor_para_loja()
        {
            InitializeComponent();
        }

        private void btn_procurar_por_nome_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.nome = txt_Nome_forn.Text;

            fornecedor = FornecedorDAO.Procurar_Fornecedor_por_nome(fornecedor);

            if (fornecedor != null)
            {
                txtCod_Forn.Text = fornecedor.id.ToString();

                txt_Nome_forn.Text = fornecedor.nome;
                txt_Cnpj_forn.Text = fornecedor.CNPJ;
                txt_Celular_forn.Text = fornecedor.telefoneCel;
            }
            else
            {
                txt_Nome_forn.Text = "";
                txt_Cnpj_forn.Text = "";
                txt_Celular_forn.Text = "";
                txt_Nome_forn.Focus();
                MessageBox.Show("Fornecedor não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}