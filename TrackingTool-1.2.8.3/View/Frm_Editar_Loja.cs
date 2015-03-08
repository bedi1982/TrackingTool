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
    public partial class Frm_Editar_Loja : Form
    {
        public Frm_Editar_Loja()
        {
            InitializeComponent();
        }

        private void BtnProcuraLoja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            loja.codigo_hiperfarma = TxtLojaProcura.Text;
            loja = LojaDAO.Procurar_Loja_por_codigo_hiperfarma(LojaDAO.Procurar_Loja_por_codigo_hiperfarma(loja));

            if (loja != null)
            {
                txtNome_loja.Text = loja.nome.ToString();
                txtCnpj_loja.Text = loja.CNPJ.ToString();
                txt_numero_loja.Text = loja.codigo_hiperfarma.ToString();
                txtTel_loja.Text = loja.telefone.ToString();
                txt_Rua_Loja.Text = loja.rua.ToString();
                txt_bairro_loja.Text = loja.bairro.ToString();
                TxtEmail.Text = loja.email.ToString();
                txtNumero_endereco_loja.Text = loja.numero.ToString();
                txtcomplemento.Text = loja.complemento.ToString();


            }
            else
            {
                MessageBox.Show("Loja não Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvarLoja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();

            if (txtNome_loja.Text == "" || txt_numero_loja.Text == "" || txtCnpj_loja.Text == "" || txt_Rua_Loja.Text == "" || txt_bairro_loja.Text == "" || txtNumero_endereco_loja.Text == "" || TxtCidade.Text == "" || TxtUF.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios em branco\n\nOs seguintes campos são obrigatórios:\n\nNome da Loja\nCód. Hiperfarma\nCNPJ\nRua\nNúmero\nBairro\nCidade\nUF", "Aviso");
            }
            else
            {

                loja.codigo_hiperfarma = TxtLojaProcura.Text.ToString();

                loja = LojaDAO.Procurar_Loja_por_codigo_hiperfarma(LojaDAO.Procurar_Loja_por_codigo_hiperfarma(loja));


                try
                {
                    loja.nome = txtNome_loja.Text;
                    loja.CNPJ = txtCnpj_loja.Text;
                    loja.telefone = txtTel_loja.Text;
                    loja.rua = txt_Rua_Loja.Text;
                    loja.bairro = txt_bairro_loja.Text;
                    loja.codigo_hiperfarma = txt_numero_loja.Text;
                    loja.email = TxtEmail.Text.ToString();
                    loja.numero = int.Parse(txtNumero_endereco_loja.Text);
                    loja.complemento = txtcomplemento.Text.ToString();
                    loja.cidade = TxtCidade.Text;
                    loja.UF = TxtUF.Text;

                    LojaDAO.EditarLoja(loja);
                    MessageBox.Show("Loja Editada com Sucesso");
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtLojaProcura.Clear();
            txtNome_loja.Clear();
            txt_numero_loja.Clear();
            txtCnpj_loja.Clear();
            txtTel_loja.Clear();
            txt_Rua_Loja.Clear();
            txt_bairro_loja.Clear();
            TxtEmail.Clear();
            txtcomplemento.Clear();
            txtNumero_endereco_loja.Clear();
            TxtCidade.Clear();
            TxtUF.Clear();
        }

        private void txtCnpj_loja_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            //não deixa apagar, arrumar isso

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("O Campo CNPJ aceita apenas números");
            }
        }

        private void txtNumero_endereco_loja_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            //não deixa apagar, arrumar isso

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("O Campo Número do endereço aceita apenas números");
            }
        }


    }
}
