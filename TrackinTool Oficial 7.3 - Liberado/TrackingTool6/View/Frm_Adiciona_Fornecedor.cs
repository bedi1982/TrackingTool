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
    public partial class Frm_Adiciona_Fornecedor : Form
    {
        public Frm_Adiciona_Fornecedor()
        {
            InitializeComponent();
        }

        private void Adiciona_Fornecedor_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Entrei na interface de cadastrar fornecedor");
        }

        
        private void GbEndereco_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumero_endereco_forn_TextChanged(object sender, EventArgs e)
        {

        }
        //TODO Não ah tratamento aqui, se algum campo estiver em branco vai dar erro
        private void btn_salvar_forn_Click(object sender, EventArgs e)
        {
        Fornecedor fornecedor = new Fornecedor();

            fornecedor.nome = txtNome_Forn.Text;
            fornecedor.CNPJ = txtCnpj_forn.Text;
            fornecedor.telefoneRes = txtTel_Res_forn.Text;
            fornecedor.telefoneCel = txt_Celular_forn.Text;
            fornecedor.rua = txtRua_forn.Text;
            fornecedor.bairro = txtbairro_forn.Text;
            fornecedor.numero = int.Parse(txtNumero_endereco_forn.Text);
            fornecedor.complemento = txtcomplemento_endereco_forn.Text;
            fornecedor.saldo = float.Parse(txt_saldo_inicial_forn.Text);
            FornecedorDAO.AdicionaFornecedorEF(fornecedor);

            //limpa campos e foca em nome://
            txtNome_Forn.Text = "";
            txtCnpj_forn.Text = "";
            txtTel_Res_forn.Text = "";
            txt_Celular_forn.Text = "";
            txtRua_forn.Text = "";
            txtbairro_forn.Text = "";
            txtNumero_endereco_forn.Text = "";
            txtcomplemento_endereco_forn.Text = "";

            txtNome_Forn.Focus();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
