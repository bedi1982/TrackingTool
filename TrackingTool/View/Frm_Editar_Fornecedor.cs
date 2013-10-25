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
    public partial class Frm_Editar_Fornecedor : Form
    {
        public Frm_Editar_Fornecedor()
        {
            InitializeComponent();
        }

        private void BtnProcuraFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.codigo_hiperfarma = TxtCodFornProcura.Text;

            forn = FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(forn));

            if (forn != null)
            {
                txtNome_Forn.Text = forn.nome.ToString();
                TxtNumID.Text = forn.codigo_hiperfarma.ToString();
                txtCnpj_forn.Text = forn.CNPJ.ToString();
                txtTel_Res_forn.Text = forn.telefoneRes.ToString();
                txtRua_forn.Text = forn.rua.ToString();
                txtTel_Res_forn.Text = forn.telefoneRes.ToString();
                TxtEmail.Text = forn.email.ToString();
                txtNumero_endereco_forn.Text = forn.numero_endereco.ToString();
                txtbairro_forn.Text = forn.bairro.ToString();
                txtcomplemento_endereco_forn.Text = forn.complemento.ToString();


            }
            else
            {
                MessageBox.Show("Fornecedor não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_forn_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            if (txtNome_Forn.Text == "" || TxtNumID.Text == "" || txtCnpj_forn.Text == "" || txtRua_forn.Text == "" || txtbairro_forn.Text == "" || txtNumero_endereco_forn.Text == "" || TxtCidade.Text == "" || TxtUF.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios em branco\n\nOs seguintes campos são obrigatórios:\n\nNome do Fornecedor\nCód. Hiperfarma\nCNPJ\nRua\nNúmero\nBairro\nCidade\nUF", "Aviso");
            }
            else
            {

                forn.codigo_hiperfarma = TxtCodFornProcura.Text;

                forn = FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(forn));

                try
                {

                    forn.nome = txtNome_Forn.Text;
                    forn.codigo_hiperfarma = TxtNumID.Text.ToString();
                    forn.CNPJ = txtCnpj_forn.Text;
                    forn.telefoneRes = txtTel_Res_forn.Text;
                    forn.rua = txtRua_forn.Text;
                    forn.bairro = txtbairro_forn.Text;
                    forn.numero_endereco = int.Parse(txtNumero_endereco_forn.Text);
                    forn.complemento = txtcomplemento_endereco_forn.Text;
                    forn.email = TxtEmail.Text.ToString();
                    forn.cidade = TxtCidade.Text;
                    forn.UF = TxtUF.Text;

                    FornecedorDAO.Editar_Fornecedor(forn);
                    MessageBox.Show("Fornecedor Editado com Sucesso");
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtCodFornProcura.Clear();
            txtNome_Forn.Clear();
            TxtNumID.Clear();
            txtCnpj_forn.Clear();
            txtTel_Res_forn.Clear();
            txtRua_forn.Clear();
            txtNumero_endereco_forn.Clear();
            txtbairro_forn.Clear();
            txtcomplemento_endereco_forn.Clear();
            TxtEmail.Clear();
            TxtCidade.Clear();
            TxtUF.Clear();
        }

        private void txtCnpj_forn_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            //não deixa apagar, arrumar isso

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("O Campo CNPJ aceita apenas números");
            }
        }

        private void txtNumero_endereco_forn_KeyPress(object sender, KeyPressEventArgs e)
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
