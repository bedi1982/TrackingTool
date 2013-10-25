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
    public partial class Frm_Add_Conta_Pagar : Form
    {
        public Frm_Add_Conta_Pagar()
        {
            try
            {
                InitializeComponent();
                banco db = SingletonObjectContext.Instance.Context;
                DGContasPagar.Rows.Clear();
                foreach (ContaAPagar x in db.ContaAPagar)
                {
                    if (x.status == false)
                    {
                        DGContasPagar.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor,x.tipo, x.descricao, x.centroCusto, x.valor);
                    }
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
            if (TxtValor.Text == "")
            {
                MessageBox.Show("O Campo Valor do Título é obrigatório");
            }
            else
            {
                if (TxtCentroCusto.Text == "")
                {
                    MessageBox.Show("O Campo Centro de Custo é obrigatório");
                }
                                 

                else
                {
                    contaPagar.centroCusto = TxtCentroCusto.Text;
                    contaPagar.codigo = TxtCodigo.Text;
                    contaPagar.valor = double.Parse(TxtValor.Text.ToString());
                    contaPagar.descricao = TxtDescricao.Text;
                    contaPagar.dataRecebe = DataCadastro.Value.Date;
                    contaPagar.dataCadastrado = DateTime.Now;
                    //O false abaixo diz que esta conta ainda não foi paga
                    contaPagar.status = false;
                    contaPagar.tipo = CBTipoSaida.Text;
                    

                            
                    if(TxtLojaDescricao.Text.Length == 0){
                        contaPagar.loja = "---";
                    }
                    else{
                        contaPagar.loja = TxtLojaDescricao.Text;
                    }
                    
                    if(TxtFornecedorDescricao.Text.Length == 0){
                        contaPagar.fornecedor = "---";
                    }
                    else
                    {
                       contaPagar.fornecedor = TxtFornecedorDescricao.Text;
                    }


                    try
                    {
                        ContaPagarDAO.AdicionaContaPagar(contaPagar);
                        MessageBox.Show("Conta Adicionada ao Banco");


                        banco db = SingletonObjectContext.Instance.Context;
                        DGContasPagar.Rows.Clear();
                        foreach (ContaAPagar x in db.ContaAPagar)
                        {
                            if (x.status == false)
                            {
                                DGContasPagar.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor,x.tipo, x.descricao, x.centroCusto, x.valor);
                            }
                        }


                        TxtCentroCusto.Clear();
                        TxtSaldo.Clear();
                        TxtCodigo.Clear();
                        TxtFornecedorProcura.Clear();
                        TxtFornecedorDescricao.Clear();
                        TxtValor.Clear();
                        TxtDescricao.Clear();
                        TxtLojaDescricao.Clear();
                        TxtLojaProcura.Clear();

                    }

                    catch
                    {
                        MessageBox.Show("Conta não Adicionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        

        private void BtnProcuraFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();

            if (TxtFornecedorProcura.Text == "")
            {

                MessageBox.Show("O código do fornecedor está em branco");

            }
            else
            {

                forn.codigo_hiperfarma = TxtFornecedorProcura.Text;

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
}

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            banco db = SingletonObjectContext.Instance.Context;
            DGContasPagar.Rows.Clear();
            foreach (ContaAPagar x in db.ContaAPagar)
            {
                if (x.status == false)
                {
                    DGContasPagar.Rows.Add(x.id, x.dataCadastrado, x.dataRecebe, x.codigo, x.loja, x.fornecedor,x.tipo, x.descricao, x.centroCusto, x.valor);
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta conta será excluida do sistema, está correto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int row = DGContasPagar.CurrentRow.Index;
                    //Remove a conta do grid e do Banco
                    ContaAPagar conta_pagar = new ContaAPagar();

                    conta_pagar.id = int.Parse(DGContasPagar.Rows[row].Cells[0].Value.ToString());
                    conta_pagar = ContaPagarDAO.Procurar_Conta_por_id(conta_pagar);

                    ContaPagarDAO.ExcluirContaPagar(conta_pagar);
                    DGContasPagar.Rows.Remove(DGContasPagar.Rows[row]);
                    MessageBox.Show("Conta Removida");
                }
            }
            catch
            {
                MessageBox.Show("Nem uma conta foi selecionada para excluir", "Aviso");
            }


        }

        private void BtnProcuraLoja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            
            if(TxtLojaProcura.Text == ""){

                MessageBox.Show("O código da loja está em branco");
            
            }
            else
            {
            loja.codigo_hiperfarma = TxtLojaProcura.Text;
            loja = LojaDAO.Procurar_Loja_por_codigo_hiperfarma(loja);
                           
            
            if (loja != null)
            {
                TxtLojaDescricao.Text = loja.nome.ToString();
            }
            else
            {
                MessageBox.Show("Loja não Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;


            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127 && asc != 44 && asc != 46)
            {

                e.Handled = true;
                MessageBox.Show("O Campo Valor aceita apenas números virgulas e pontos");

            }
        }

        private void BtnLojasContas_Click(object sender, EventArgs e)
        {
            Frm_ListarLojasContas lojas = new Frm_ListarLojasContas();
            lojas.Show();
        }

        private void BtnFornContas_Click(object sender, EventArgs e)
        {
            Frm_ListarFornContas forn = new Frm_ListarFornContas();
            forn.Show();
        }
              
    }
}
