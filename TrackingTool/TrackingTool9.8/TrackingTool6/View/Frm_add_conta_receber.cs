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
    public partial class Frm_add_conta_receber : Form
    {
        public Frm_add_conta_receber()
        {
            InitializeComponent();
            try
            {
                TrackingToolEntities db = SingletonObjectContext.Instance.Context;
                foreach (ContaReceber x in db.ContaReceber)
                {
                    GridContasReceber.Rows.Add(x.id, x.codigo, x.descricao, x.valor, x.centroCusto, x.dataRecebe, x.dataCadastrado, x.tipo, x.loja);
                }
            }
            catch
            {
                MessageBox.Show("Você precisa cadastrar no mínimo uma Loja e um Centro de Custo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        {
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = TxtCentroCusto.Text;
            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo);

            if (centro_de_custo != null)
            {
                TxtSaldo.Text = centro_de_custo.saldo.ToString();
                BtnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Centro de Custo não Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ContaReceber contaRecebe = new ContaReceber();

            contaRecebe.valor = Double.Parse(TxtValor.Text);
            contaRecebe.descricao = TxtDescricao.Text;
            contaRecebe.dataRecebe = DataCadastro.Value.Date;
            contaRecebe.dataCadastrado = DateTime.Now;
            contaRecebe.centroCusto = TxtCentroCusto.Text;
            contaRecebe.codigo = TxtCodigo.Text;
            contaRecebe.tipo = CBTipo.Text;
            contaRecebe.loja = TxtLojaProcura.Text;
            try
            {
                ContaReceberDAO.AdicionaContaReceber(contaRecebe);
                MessageBox.Show("Conta Adicionada ao Banco");

                TxtCentroCusto.Clear();
                TxtSaldo.Clear();
                TxtCodigo.Clear();
                TxtLojaProcura.Clear();
                TxtLojaDescricao.Clear();
                TxtValor.Clear();
                TxtDescricao.Clear();
            }
            catch
            {
                MessageBox.Show("Conta Não Adicionada","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //Após adicionar a conta, ele automaticamente atualiza o grid
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            GridContasReceber.Rows.Clear();
            foreach (ContaReceber x in db.ContaReceber)
            {
                GridContasReceber.Rows.Add(x.id, x.codigo, x.descricao, x.valor, x.centroCusto, x.dataRecebe, x.dataCadastrado, x.tipo, x.loja);
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            GridContasReceber.Rows.Clear();
            foreach (ContaReceber x in db.ContaReceber)
            {
                GridContasReceber.Rows.Add(x.id, x.codigo, x.descricao, x.valor, x.centroCusto, x.dataRecebe, x.dataCadastrado, x.tipo, x.loja);
            }
        }

        private void BtnProcuraLoja_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            loja.codigo_hiperfarma = int.Parse(TxtLojaProcura.Text);
            loja = LojaDAO.Procurar_Loja_por_numero(loja);

            if (loja != null)
            {
                TxtLojaDescricao.Text = loja.nome.ToString();
            }
            else
            {
                MessageBox.Show("Loja não Encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnContaRecebida_Click(object sender, EventArgs e)
        {
            int row;
            float valor;
            string centro;

            //row recebe a linha onde está a conta
            row = GridContasReceber.CurrentRow.Index;
            valor = float.Parse(GridContasReceber.Rows[row].Cells[3].Value.ToString());
            centro = GridContasReceber.Rows[row].Cells[4].Value.ToString();

            //Procura o centro de custo a partir da linha selecionada

            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = centro;
            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo);

                //Remove a conta do grid e do banco

                ContaReceber contareceber = new ContaReceber();
                contareceber.id = int.Parse(GridContasReceber.Rows[row].Cells[0].Value.ToString());

                contareceber = ContaReceberDAO.Procurar_Conta_por_id(contareceber);

                //A conta que foi recebida é copiada para outra tabela do banco, "contaRecebida", 
                //para depois poder ser feito o relatório
                if(MessageBox.Show("Existe alguma alteração no valor da conta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    TxtCentroCusto.Enabled = false;
                    TxtCodigo.Enabled = false;
                    TxtLojaProcura.Enabled = false;
                    TxtValor.Enabled = false;
                    TxtDescricao.Enabled = false;
                    DataCadastro.Enabled = false;
                    TxtDescricao.Enabled = false;
                    
                    BtnProcurar.Enabled = false;
                    CBTipo.Enabled = false;
                    BtnProcuraLoja.Enabled = false;
                    BtnAdd.Enabled = false;
                    BtnAtualizar.Enabled = false;
                    BtnContaRecebida.Enabled = false;
                    BtnExcluir.Enabled = false;

                    LblNovoValor.Visible = true;
                    TxtNovoValor.Visible = true;
                    TxtNovoValor.Focus();
                    BtnOK.Visible = true;
                }
                else
                {
                        //O centro de custo recebe o valor a ser creditado e faz o update no banco
                        centro_de_custo.saldo += valor;
                        Centro_de_CustoDAO.AdicionaValorAoCDC(centro_de_custo);
                        //
                        ContaReceberDAO.ReceberConta(contareceber);
                        //Remove a conta do grid
                        GridContasReceber.Rows.Remove(GridContasReceber.Rows[row]);

                        MessageBox.Show("Conta Recebida com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
    }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int row = GridContasReceber.CurrentRow.Index;
            //Remove a conta do grid e do banco
            ContaReceber conta_receber = new ContaReceber();

            conta_receber.id = int.Parse(GridContasReceber.Rows[row].Cells[0].Value.ToString());
            conta_receber = ContaReceberDAO.Procurar_Conta_por_id(conta_receber);
            
            ContaReceberDAO.ReceberConta(conta_receber);
            GridContasReceber.Rows.Remove(GridContasReceber.Rows[row]);
            MessageBox.Show("Conta Removida");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int row = GridContasReceber.CurrentRow.Index;

            ContaReceber conta_receber = new ContaReceber();

            conta_receber.id = int.Parse(GridContasReceber.Rows[row].Cells[0].Value.ToString());
            conta_receber = ContaReceberDAO.Procurar_Conta_por_id(conta_receber);

            ContaReceberDAO.ReceberConta(conta_receber);

            //Procura o centro de custo a partir da linha selecionada
            
            String centro;
            centro = GridContasReceber.Rows[row].Cells[4].Value.ToString();
            
            CentroDeCusto centro_de_custo = new CentroDeCusto();
            centro_de_custo.nome = centro;
            centro_de_custo = Centro_de_CustoDAO.Procurar_CDC_por_nome(centro_de_custo);
            centro_de_custo.saldo += float.Parse(TxtNovoValor.Text.ToString());
            Centro_de_CustoDAO.AdicionaValorAoCDC(centro_de_custo);
            //
            GridContasReceber.Rows.Remove(GridContasReceber.Rows[row]);
            

            MessageBox.Show("Conta com valor modificado", "Aviso");
            MessageBox.Show("Conta Recebida com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LblNovoValor.Visible = false;
            TxtNovoValor.Visible = false;
            BtnOK.Visible = false;

            TxtCentroCusto.Enabled = true;
            TxtCodigo.Enabled = true;
            TxtLojaProcura.Enabled = true;
            TxtValor.Enabled = true;
            TxtDescricao.Enabled = true;
            DataCadastro.Enabled = true;
            TxtDescricao.Enabled = true;

            BtnProcurar.Enabled = true;
            CBTipo.Enabled = true;
            BtnProcuraLoja.Enabled = true;
            BtnAdd.Enabled = true;
            BtnAtualizar.Enabled = true;
            BtnContaRecebida.Enabled = true;
            BtnExcluir.Enabled = true;
        }
    }
}