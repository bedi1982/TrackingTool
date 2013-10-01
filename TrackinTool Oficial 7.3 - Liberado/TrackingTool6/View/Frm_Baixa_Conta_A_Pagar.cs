using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrackingTool6.Controler;
using TrackingTool6.Model;

namespace TrackingTool6.View
{
    public partial class Frm_Baixa_Conta_A_Pagar : Form
    {
        public Frm_Baixa_Conta_A_Pagar()
        {
            InitializeComponent();
        }      

        private void Frm_Baixa_Conta_A_Pagar_Load(object sender, EventArgs e)
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

        private void cbbForn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.nome = cbbForn.Text;
            //forn = FornecedorDAO.Procurar_Fornecedor_por_nome(forn);

            dataGridView1.Rows.Clear();
            
            foreach (ContasPagar x in Contas_PagarDAO.Search(forn))
            {
                dataGridView1.Rows.Add(x.forn.nome, x.doc, x.despesa, x.centrosde_Custo.nome, x.valor, x.vencimento.Day + "/" + x.vencimento.Month + "/" + x.vencimento.Year);
            }
            if (dataGridView1.Rows.Count.Equals(1))
            {
                MessageBox.Show("Não existe contas a pagar para este fornecedor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDocumento.Text = dataGridView1.CurrentRow.Cells["documento"].Value.ToString();
            txtDesp.Text = dataGridView1.CurrentRow.Cells["despesa"].Value.ToString();
            label1.Text = dataGridView1.CurrentRow.Cells["valor_documento"].Value.ToString();
            dateVencimento.Text = dataGridView1.CurrentRow.Cells["vencimento"].Value.ToString();
        }
    }
}
