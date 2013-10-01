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
    public partial class Frm_Cadastar_Contas_Pagar : Form
    {
        public Frm_Cadastar_Contas_Pagar()
        {
            InitializeComponent();
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ContasPagar contaPagar = new ContasPagar();
            Fornecedor fornecedor = new Fornecedor();
            CentroDeCusto centroCusto = new CentroDeCusto();

            
            contaPagar.doc = txtDocumento.Text;
            fornecedor.nome = cbbForn.Text;
            centroCusto.nome = cbbCC.Text;
            
            contaPagar.despesa = txtDesp.Text;
            contaPagar.bancoConta = txtBanco.Text;
            try
            {
                contaPagar.valor = float.Parse(txtValor.Text);
                contaPagar.cheque = int.Parse(txtNumCheque.Text);
                contaPagar.juros = float.Parse(txtJuros.Text);
                contaPagar.desconto = float.Parse(textBox1.Text);
                contaPagar.valorPago = float.Parse(txtValorPagto.Text);
            }
            catch
            {
                MessageBox.Show("Valores Inválidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            contaPagar.observacao = richTextBox1.Text;
            contaPagar.emissao = dateTimePicker1.Value.Date;
            contaPagar.vencimento = dateTimePicker2.Value.Date;
            contaPagar.dataPagto = dateTimePicker3.Value.Date;

            if (txtDocumento.Text != "" || txtValor.Text != "")
            {
                fornecedor = FornecedorDAO.Procurar_Fornecedor_por_nome(fornecedor);
                if (fornecedor == null || cbbForn.Text == "")
                {
                    MessageBox.Show("Não foi possível cadastrar essa conta, Fornecedor não é cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    centroCusto = Centro_de_CustoDAO.Procurar_CDC_por_nome(centroCusto);
                    if (centroCusto == null || cbbCC.Text == "")
                    {
                        MessageBox.Show("Não foi possível cadastrar essa conta, Centro de Custo não existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        contaPagar.forn = fornecedor;
                        contaPagar.centrosde_Custo = centroCusto;

                        Contas_PagarDAO.AdicionaContaPagar(contaPagar);
                    }
                }
            }
            else
            {
                if(txtDocumento.Text == "")
                    MessageBox.Show("Documento inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(txtValor.Text == "")
                    MessageBox.Show("Valor da conta inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void cbbForn_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbForn.Items.Clear();
            foreach (Fornecedor x in FornecedorDAO.BuscaTodosFornecedores())
            {
                cbbForn.Items.Add(x.nome);
            }
        }

        //private void btnPesq_Click(object sender, EventArgs e)
        //{
        //    cbbForn.Items.Clear();
        //    foreach (Fornecedor x in FornecedorDAO.BuscaTodosFornecedores())
        //    {
        //        cbbForn.Items.Add(x.nome);
        //    }
        //}

        //private void btnCC_Click(object sender, EventArgs e)
        //{
        //    cbbCC.Items.Clear();
        //    foreach (CentroDeCusto x in Centro_de_CustoDAO.BuscaCentrosDeCustos())
        //    {
        //        cbbCC.Items.Add(x.nome);
        //    }

            
        //}

        private void Frm_Cadastar_Contas_Pagar_Load(object sender, EventArgs e)
        {
            cbbForn.Items.Clear();
            foreach (Fornecedor x in FornecedorDAO.BuscaTodosFornecedores())
            {
                cbbForn.Items.Add(x.nome);
            }
            cbbCC.Items.Clear();
            foreach (CentroDeCusto x in Centro_de_CustoDAO.BuscaCentrosDeCustos())
            {
                cbbCC.Items.Add(x.nome);
            }
        }

       


    }
}
