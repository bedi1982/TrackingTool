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
    public partial class Frm_Adicionar_Loja : Form
    {
        public Frm_Adicionar_Loja()
        {
            InitializeComponent();
            txtCnpj_loja.Text = "";
            txtCnpj_loja.Mask = "00,000,000/0000-00";
        }

        private void btn_adicionar_loja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            Loja procura = new Loja();

            if (txtNome_loja.Text == "" || txt_numero_loja.Text == "" || txtCnpj_loja.Text == "" || txt_Rua_Loja.Text == "" || txt_bairro_loja.Text == "" || txtNumero_endereco_loja.Text == "" || TxtCidade.Text == "" || TxtUF.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios em branco\n\nOs seguintes campos são obrigatórios:\n\nNome da Loja\nCód. Hiperfarma\nCNPJ\nRua\nNúmero\nBairro\nCidade\nUF", "Aviso");
            }
            else
            {
                loja.nome = txtNome_loja.Text;
                loja.CNPJ = txtCnpj_loja.Text;
                loja.telefone = txtTel_loja.Text;
                loja.rua = txt_Rua_Loja.Text;
                loja.bairro = txt_bairro_loja.Text;
                loja.codigo_hiperfarma = txt_numero_loja.Text;
                loja.email = TxtEmail.Text;
                loja.complemento = txtcomplemento.Text;
                loja.cidade = TxtCidade.Text;
                loja.UF = TxtUF.Text;

                if (ValidaCNPJ.IsCnpj(loja.CNPJ))
                {



                    loja.status = true;

                    procura = loja;

                    procura = LojaDAO.Procurar_Loja_por_codigo_hiperfarma(LojaDAO.Procurar_Loja_por_codigo_hiperfarma(procura));

                    if (procura != null)
                    {
                        MessageBox.Show("O código da loja já existe no sistema");
                    }
                    else
                    {
                        LojaDAO.AdicionaLojaEF(loja);

                        //limpa campos e foca em nome://
                        txtNome_loja.Text = "";
                        txtCnpj_loja.Text = "";
                        txtTel_loja.Text = "";
                        txt_Rua_Loja.Text = "";
                        txt_bairro_loja.Text = "";
                        //Nímero de identificação Hiperfarma
                        txt_numero_loja.Text = "";
                        TxtEmail.Clear();
                        txtcomplemento.Clear();
                        txtNumero_endereco_loja.Clear();
                        TxtCidade.Clear();
                        TxtUF.Clear();

                        txtNome_loja.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("O número do CNPJ é Inválido !");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCnpj_loja_KeyPress(object sender, KeyPressEventArgs e)
        {

            int asc = (int)e.KeyChar;
            
            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127)
            {

                e.Handled = true;
                MessageBox.Show("O Campo CNPJ aceita apenas números");
            }

        }

        private void txtNumero_endereco_loja_KeyPress(object sender, KeyPressEventArgs e)
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