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
    public partial class Frm_Adiciona_Fornecedor : Form
    {
        public Frm_Adiciona_Fornecedor()
        {
            InitializeComponent();
            txtCnpj_forn.Text = "";
            txtCnpj_forn.Mask = "00,000,000/0000-00";
            
                      
        }

        
        
        
        private void btn_salvar_forn_Click(object sender, EventArgs e)
        {
            if (txtNome_Forn.Text == "" || TxtNumID.Text == "" || txtCnpj_forn.Text == "" || txtRua_forn.Text == "" || txtbairro_forn.Text == "" || txtNumero_endereco_forn.Text == "" || TxtCidade.Text == "" || TxtUF.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios em branco\n\nOs seguintes campos são obrigatórios:\n\nNome do Fornecedor\nCód. Hiperfarma\nCNPJ\nRua\nNúmero\nBairro\nCidade\nUF", "Aviso");
            }
            else
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Deseja cadastrar o fornecedor?\n"+txtNome_Forn.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Fornecedor fornecedor = new Fornecedor();
                    Fornecedor procura = new Fornecedor();

                    fornecedor.nome = txtNome_Forn.Text;
                    fornecedor.codigo_hiperfarma = TxtNumID.Text;
                    fornecedor.CNPJ = txtCnpj_forn.Text;
                    fornecedor.telefoneRes = txtTel_Res_forn.Text;
                    fornecedor.rua = txtRua_forn.Text;
                    fornecedor.bairro = txtbairro_forn.Text;
                    fornecedor.numero_endereco = int.Parse(txtNumero_endereco_forn.Text);
                    fornecedor.complemento = txtcomplemento_endereco_forn.Text;
                    fornecedor.status = true;
                    fornecedor.email = TxtEmail.Text;
                    fornecedor.cidade = TxtCidade.Text;
                    fornecedor.UF = TxtUF.Text;



                    if (ValidaCNPJ.IsCnpj(fornecedor.CNPJ))
                    {




                        procura = fornecedor;
                        procura = FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(procura));

                        if (procura != null)
                        {
                            MessageBox.Show("O código do fornecedor já existe no sistema");

                        }
                        else
                        {
                            FornecedorDAO.AdicionaFornecedorEF(fornecedor);

                            //limpa campos e foca em nome://
                            txtNome_Forn.Clear();
                            TxtNumID.Clear();
                            txtCnpj_forn.Clear();
                            txtTel_Res_forn.Clear();
                            txtRua_forn.Clear();
                            txtbairro_forn.Clear();
                            txtNumero_endereco_forn.Clear();
                            txtcomplemento_endereco_forn.Clear();
                            TxtEmail.Clear();
                            TxtCidade.Clear();
                            TxtUF.Clear();


                            txtNome_Forn.Focus();

                        }
                    }

                    else
                    {
                        MessageBox.Show("O número do CNPJ é Inválido !");
                    }
                }
            }


        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja abandonar o cadastro do fornecedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }


        
        private void txtCnpj_forn_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            

            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127)
            {

                e.Handled = true;
                MessageBox.Show("O Campo CNPJ aceita apenas números");

            }

        }

        

        private void txtNumero_endereco_forn_KeyPress(object sender, KeyPressEventArgs e)
        {

            int asc = (int)e.KeyChar;
            

            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127)
            {

                e.Handled = true;
                MessageBox.Show("O Campo Número do endereço aceita apenas números");

            }
            
        }

        
                      
    }
}
