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
using TrackingTool6.db;
namespace TrackingTool6.View
{
    public partial class Frm_Add_Conta_Pagar : Form
    {
        public Frm_Add_Conta_Pagar()
        {
            try
            {
                InitializeComponent();
                TrackingToolEntities db = SingletonObjectContext.Instance.Context;
                DGContasPagar.Rows.Clear();
                foreach (ContaAPagar x in db.ContaAPagar)
                {
                    DGContasPagar.Rows.Add(x.id, x.codigo, x.descricao, x.valor, x.centroCusto, x.dataRecebe, x.dataCadastrado, x.fornecedor);
                }
            }
            catch
            {
                    MessageBox.Show("Você precisa cadastrar no mínimo uma loja e um fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = TxtCentroCusto.Text;
            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo));

            if (centro_de_custo != null)
            {
                TxtSaldo.Text = centro_de_custo.saldo.ToString();
                TxtCentroCusto.Text = centro_de_custo.nome.ToString();
                BtnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Centro de Custo não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCentroCusto.Text = "";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ContaAPagar contaPagar = new ContaAPagar();

            contaPagar.centroCusto = TxtCentroCusto.Text;
            contaPagar.codigo = TxtCodigo.Text;
            contaPagar.fornecedor = TxtFornecedorDescricao.Text;
            contaPagar.valor = double.Parse(TxtValor.Text.ToString());
            contaPagar.descricao = TxtDescricao.Text;
            contaPagar.dataRecebe = DataCadastro.Value.Date;
            contaPagar.dataCadastrado = DateTime.Now;
            //O false abaixo diz que esta conta ainda não foi paga
            contaPagar.status = false;

            try
            {
                ContaPagarDAO.AdicionaContaPagar(contaPagar);
                MessageBox.Show("Conta Adicionada ao Banco");

                TxtCentroCusto.Clear();
                TxtSaldo.Clear();
                TxtCodigo.Clear();
                TxtFornecedorProcura.Clear();
                TxtFornecedorDescricao.Clear();
                TxtValor.Clear();
                TxtDescricao.Clear();
            }

            catch
            {
                MessageBox.Show("Conta não Adicionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnProcuraFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.codigo_hiperfarma = int.Parse(TxtFornecedorProcura.Text);
            
            forn = FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(FornecedorDAO.Procurar_Fornecedor_por_codigo_hiperfarma(forn));

            if (forn != null)
            {
                TxtFornecedorDescricao.Text = forn.nome.ToString();

            }
            else
            {
                MessageBox.Show("Fornecedor não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            DGContasPagar.Rows.Clear();
            foreach (ContaAPagar x in db.ContaAPagar)
            {
                DGContasPagar.Rows.Add(x.id, x.codigo, x.descricao, x.valor, x.centroCusto, x.dataRecebe, x.dataCadastrado, x.fornecedor);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Add_Conta_Pagar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TrackingTool6_db_TrackingToolEntitiesDataSet.ContaAPagar' table. You can move, or remove it, as needed.
            this.contaAPagarTableAdapter.Fill(this._TrackingTool6_db_TrackingToolEntitiesDataSet.ContaAPagar);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.contaAPagarTableAdapter.FillBy(this._TrackingTool6_db_TrackingToolEntitiesDataSet.ContaAPagar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.contaAPagarTableAdapter.FillBy(this._TrackingTool6_db_TrackingToolEntitiesDataSet.ContaAPagar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
