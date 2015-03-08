namespace Tracking.View
{
    partial class Frm_add_conta_receber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_add_conta_receber));
            this.GBDadosConta = new System.Windows.Forms.GroupBox();
            this.BtnFornContas = new System.Windows.Forms.Button();
            this.BtnLojasContas = new System.Windows.Forms.Button();
            this.TxtDescricaoForn = new System.Windows.Forms.TextBox();
            this.BtnProcurarForn = new System.Windows.Forms.Button();
            this.LblCodFornecedor = new System.Windows.Forms.Label();
            this.TxtProcurarForn = new System.Windows.Forms.TextBox();
            this.TxtLojaDescricao = new System.Windows.Forms.TextBox();
            this.BtnProcuraLoja = new System.Windows.Forms.Button();
            this.LblLoja = new System.Windows.Forms.Label();
            this.TxtLojaProcura = new System.Windows.Forms.TextBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.DataCadastro = new System.Windows.Forms.DateTimePicker();
            this.LblData = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.LblDescrição = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.BtnProcurar = new System.Windows.Forms.Button();
            this.TxtCentroCusto = new System.Windows.Forms.TextBox();
            this.LblCentroCusto = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.GridContasReceber = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBDadosConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridContasReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDadosConta
            // 
            this.GBDadosConta.Controls.Add(this.BtnFornContas);
            this.GBDadosConta.Controls.Add(this.BtnLojasContas);
            this.GBDadosConta.Controls.Add(this.TxtDescricaoForn);
            this.GBDadosConta.Controls.Add(this.BtnProcurarForn);
            this.GBDadosConta.Controls.Add(this.LblCodFornecedor);
            this.GBDadosConta.Controls.Add(this.TxtProcurarForn);
            this.GBDadosConta.Controls.Add(this.TxtLojaDescricao);
            this.GBDadosConta.Controls.Add(this.BtnProcuraLoja);
            this.GBDadosConta.Controls.Add(this.LblLoja);
            this.GBDadosConta.Controls.Add(this.TxtLojaProcura);
            this.GBDadosConta.Controls.Add(this.LblTipo);
            this.GBDadosConta.Controls.Add(this.CBTipo);
            this.GBDadosConta.Controls.Add(this.LblCodigo);
            this.GBDadosConta.Controls.Add(this.TxtCodigo);
            this.GBDadosConta.Controls.Add(this.BtnAtualizar);
            this.GBDadosConta.Controls.Add(this.DataCadastro);
            this.GBDadosConta.Controls.Add(this.LblData);
            this.GBDadosConta.Controls.Add(this.BtnAdd);
            this.GBDadosConta.Controls.Add(this.TxtSaldo);
            this.GBDadosConta.Controls.Add(this.LblSaldo);
            this.GBDadosConta.Controls.Add(this.TxtDescricao);
            this.GBDadosConta.Controls.Add(this.LblDescrição);
            this.GBDadosConta.Controls.Add(this.TxtValor);
            this.GBDadosConta.Controls.Add(this.LblValor);
            this.GBDadosConta.Controls.Add(this.BtnProcurar);
            this.GBDadosConta.Controls.Add(this.TxtCentroCusto);
            this.GBDadosConta.Controls.Add(this.LblCentroCusto);
            this.GBDadosConta.Location = new System.Drawing.Point(12, 12);
            this.GBDadosConta.Name = "GBDadosConta";
            this.GBDadosConta.Size = new System.Drawing.Size(766, 286);
            this.GBDadosConta.TabIndex = 0;
            this.GBDadosConta.TabStop = false;
            this.GBDadosConta.Text = "Dados da Conta";
            // 
            // BtnFornContas
            // 
            this.BtnFornContas.Image = global::Tracking.Properties.Resources.Search_icon;
            this.BtnFornContas.Location = new System.Drawing.Point(675, 156);
            this.BtnFornContas.Name = "BtnFornContas";
            this.BtnFornContas.Size = new System.Drawing.Size(26, 20);
            this.BtnFornContas.TabIndex = 30;
            this.BtnFornContas.Text = "...";
            this.BtnFornContas.UseVisualStyleBackColor = true;
            this.BtnFornContas.Click += new System.EventHandler(this.BtnFornContas_Click);
            // 
            // BtnLojasContas
            // 
            this.BtnLojasContas.Image = global::Tracking.Properties.Resources.Search_icon;
            this.BtnLojasContas.Location = new System.Drawing.Point(675, 125);
            this.BtnLojasContas.Name = "BtnLojasContas";
            this.BtnLojasContas.Size = new System.Drawing.Size(26, 20);
            this.BtnLojasContas.TabIndex = 29;
            this.BtnLojasContas.Text = "...";
            this.BtnLojasContas.UseVisualStyleBackColor = true;
            this.BtnLojasContas.Click += new System.EventHandler(this.BtnLojasContas_Click);
            // 
            // TxtDescricaoForn
            // 
            this.TxtDescricaoForn.AcceptsTab = true;
            this.TxtDescricaoForn.Location = new System.Drawing.Point(247, 156);
            this.TxtDescricaoForn.Name = "TxtDescricaoForn";
            this.TxtDescricaoForn.ReadOnly = true;
            this.TxtDescricaoForn.Size = new System.Drawing.Size(422, 20);
            this.TxtDescricaoForn.TabIndex = 28;
            // 
            // BtnProcurarForn
            // 
            this.BtnProcurarForn.Location = new System.Drawing.Point(210, 156);
            this.BtnProcurarForn.Name = "BtnProcurarForn";
            this.BtnProcurarForn.Size = new System.Drawing.Size(26, 20);
            this.BtnProcurarForn.TabIndex = 8;
            this.BtnProcurarForn.Text = "...";
            this.BtnProcurarForn.UseVisualStyleBackColor = true;
            this.BtnProcurarForn.Click += new System.EventHandler(this.BtnProcurarForn_Click);
            // 
            // LblCodFornecedor
            // 
            this.LblCodFornecedor.AutoSize = true;
            this.LblCodFornecedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblCodFornecedor.Location = new System.Drawing.Point(4, 160);
            this.LblCodFornecedor.Name = "LblCodFornecedor";
            this.LblCodFornecedor.Size = new System.Drawing.Size(139, 16);
            this.LblCodFornecedor.TabIndex = 27;
            this.LblCodFornecedor.Text = "Código do Fornecedor:";
            // 
            // TxtProcurarForn
            // 
            this.TxtProcurarForn.AcceptsTab = true;
            this.TxtProcurarForn.Location = new System.Drawing.Point(149, 156);
            this.TxtProcurarForn.Name = "TxtProcurarForn";
            this.TxtProcurarForn.Size = new System.Drawing.Size(55, 20);
            this.TxtProcurarForn.TabIndex = 7;
            // 
            // TxtLojaDescricao
            // 
            this.TxtLojaDescricao.AcceptsTab = true;
            this.TxtLojaDescricao.Location = new System.Drawing.Point(247, 125);
            this.TxtLojaDescricao.Name = "TxtLojaDescricao";
            this.TxtLojaDescricao.ReadOnly = true;
            this.TxtLojaDescricao.Size = new System.Drawing.Size(422, 20);
            this.TxtLojaDescricao.TabIndex = 24;
            // 
            // BtnProcuraLoja
            // 
            this.BtnProcuraLoja.Location = new System.Drawing.Point(210, 125);
            this.BtnProcuraLoja.Name = "BtnProcuraLoja";
            this.BtnProcuraLoja.Size = new System.Drawing.Size(26, 20);
            this.BtnProcuraLoja.TabIndex = 6;
            this.BtnProcuraLoja.Text = "...";
            this.BtnProcuraLoja.UseVisualStyleBackColor = true;
            this.BtnProcuraLoja.Click += new System.EventHandler(this.BtnProcuraLoja_Click);
            // 
            // LblLoja
            // 
            this.LblLoja.AutoSize = true;
            this.LblLoja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblLoja.Location = new System.Drawing.Point(37, 125);
            this.LblLoja.Name = "LblLoja";
            this.LblLoja.Size = new System.Drawing.Size(98, 16);
            this.LblLoja.TabIndex = 22;
            this.LblLoja.Text = "Código da Loja:";
            // 
            // TxtLojaProcura
            // 
            this.TxtLojaProcura.AcceptsTab = true;
            this.TxtLojaProcura.Location = new System.Drawing.Point(149, 125);
            this.TxtLojaProcura.Name = "TxtLojaProcura";
            this.TxtLojaProcura.Size = new System.Drawing.Size(55, 20);
            this.TxtLojaProcura.TabIndex = 5;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblTipo.Location = new System.Drawing.Point(356, 96);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(103, 16);
            this.LblTipo.TabIndex = 20;
            this.LblTipo.Text = "Tipo de Entrada:";
            // 
            // CBTipo
            // 
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Items.AddRange(new object[] {
            "Depósito não Indentificado",
            "Empréstimos entre C/C",
            "Estorno Despesas",
            "Mensalidade",
            "Recebimento Convênio",
            "Reemb. Refeição Colab. Eurofarma",
            "Rend. Aplic. Financeiro",
            "Repasse Fornec. p/ Sede",
            "Repasse Fornec. p/ Associados",
            "Transferência p/ Poupança",
            "Transf. mens./desp./outros entre C/C",
            "Venda Produtos - Em Dinheiro/CH",
            "Venda Produtos - Via Cartão de Débito",
            "Verba MKTG - Negociação",
            "Verba MKTG - Planejamento",
            "Verba MKTG - Tablóide",
            "Verba MKTG - Outros Eventos"});
            this.CBTipo.Location = new System.Drawing.Point(459, 93);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(199, 21);
            this.CBTipo.TabIndex = 4;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblCodigo.Location = new System.Drawing.Point(73, 96);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(112, 16);
            this.LblCodigo.TabIndex = 18;
            this.LblCodigo.Text = "Código de Barras:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.AcceptsTab = true;
            this.TxtCodigo.Location = new System.Drawing.Point(191, 94);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(124, 20);
            this.TxtCodigo.TabIndex = 3;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAtualizar.Image")));
            this.BtnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAtualizar.Location = new System.Drawing.Point(643, 247);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(117, 33);
            this.BtnAtualizar.TabIndex = 12;
            this.BtnAtualizar.Text = "Atualizar lista";
            this.BtnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // DataCadastro
            // 
            this.DataCadastro.Location = new System.Drawing.Point(444, 187);
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Size = new System.Drawing.Size(214, 20);
            this.DataCadastro.TabIndex = 6;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblData.Location = new System.Drawing.Point(310, 192);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(129, 16);
            this.LblData.TabIndex = 14;
            this.LblData.Text = "Data de Vencimento:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(543, 247);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 33);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.AcceptsTab = true;
            this.TxtSaldo.Location = new System.Drawing.Point(191, 61);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.ReadOnly = true;
            this.TxtSaldo.Size = new System.Drawing.Size(124, 20);
            this.TxtSaldo.TabIndex = 12;
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblSaldo.Location = new System.Drawing.Point(29, 62);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(160, 16);
            this.LblSaldo.TabIndex = 11;
            this.LblSaldo.Text = "Saldo Atual deste  Centro:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.AcceptsTab = true;
            this.TxtDescricao.Location = new System.Drawing.Point(149, 222);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(535, 20);
            this.TxtDescricao.TabIndex = 10;
            // 
            // LblDescrição
            // 
            this.LblDescrição.AutoSize = true;
            this.LblDescrição.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDescrição.Location = new System.Drawing.Point(6, 226);
            this.LblDescrição.Name = "LblDescrição";
            this.LblDescrição.Size = new System.Drawing.Size(137, 16);
            this.LblDescrição.TabIndex = 9;
            this.LblDescrição.Text = "Descrição da Entrada:";
            // 
            // TxtValor
            // 
            this.TxtValor.AcceptsTab = true;
            this.TxtValor.Location = new System.Drawing.Point(149, 187);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(124, 20);
            this.TxtValor.TabIndex = 9;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblValor.Location = new System.Drawing.Point(49, 191);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(94, 16);
            this.LblValor.TabIndex = 7;
            this.LblValor.Text = "Valor do Título:";
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProcurar.Image")));
            this.BtnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProcurar.Location = new System.Drawing.Point(465, 22);
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Size = new System.Drawing.Size(94, 33);
            this.BtnProcurar.TabIndex = 2;
            this.BtnProcurar.Text = "Procurar";
            this.BtnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcurar.UseVisualStyleBackColor = true;
            this.BtnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // TxtCentroCusto
            // 
            this.TxtCentroCusto.AcceptsTab = true;
            this.TxtCentroCusto.Location = new System.Drawing.Point(197, 29);
            this.TxtCentroCusto.Name = "TxtCentroCusto";
            this.TxtCentroCusto.Size = new System.Drawing.Size(262, 20);
            this.TxtCentroCusto.TabIndex = 1;
            // 
            // LblCentroCusto
            // 
            this.LblCentroCusto.AutoSize = true;
            this.LblCentroCusto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblCentroCusto.Location = new System.Drawing.Point(29, 30);
            this.LblCentroCusto.Name = "LblCentroCusto";
            this.LblCentroCusto.Size = new System.Drawing.Size(162, 16);
            this.LblCentroCusto.TabIndex = 4;
            this.LblCentroCusto.Text = "Nome do Centro de Custo:";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVoltar.Location = new System.Drawing.Point(928, 564);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(94, 33);
            this.BtnVoltar.TabIndex = 13;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // GridContasReceber
            // 
            this.GridContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataCad,
            this.Data,
            this.codigo,
            this.loja,
            this.FornecedorCR,
            this.descricao,
            this.tipo,
            this.CentroCusto,
            this.Valor});
            this.GridContasReceber.Location = new System.Drawing.Point(12, 304);
            this.GridContasReceber.MultiSelect = false;
            this.GridContasReceber.Name = "GridContasReceber";
            this.GridContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridContasReceber.Size = new System.Drawing.Size(1010, 254);
            this.GridContasReceber.TabIndex = 8;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Red;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.Location = new System.Drawing.Point(13, 564);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(113, 33);
            this.BtnExcluir.TabIndex = 26;
            this.BtnExcluir.TabStop = false;
            this.BtnExcluir.Text = "Excluir Conta";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(784, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 65);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Width = 40;
            // 
            // dataCad
            // 
            this.dataCad.HeaderText = "Data de Cadastro";
            this.dataCad.Name = "dataCad";
            this.dataCad.Width = 118;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Data.HeaderText = "Data de Vencimento";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 118;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código da Conta";
            this.codigo.Name = "codigo";
            // 
            // loja
            // 
            this.loja.HeaderText = "Loja";
            this.loja.Name = "loja";
            // 
            // FornecedorCR
            // 
            this.FornecedorCR.HeaderText = "Fornecedor";
            this.FornecedorCR.Name = "FornecedorCR";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descricao.HeaderText = "Descrição da Conta";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 90;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo da Conta";
            this.tipo.Name = "tipo";
            // 
            // CentroCusto
            // 
            this.CentroCusto.HeaderText = "Centro de Custo de Crédito";
            this.CentroCusto.Name = "CentroCusto";
            this.CentroCusto.Width = 120;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Valor.Width = 80;
            // 
            // Frm_add_conta_receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.GridContasReceber);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.GBDadosConta);
            this.Name = "Frm_add_conta_receber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Conta a Receber";
            this.GBDadosConta.ResumeLayout(false);
            this.GBDadosConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridContasReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDadosConta;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label LblDescrição;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.TextBox TxtCentroCusto;
        private System.Windows.Forms.Label LblCentroCusto;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.DateTimePicker DataCadastro;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.DataGridView GridContasReceber;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.TextBox TxtLojaDescricao;
        private System.Windows.Forms.Button BtnProcuraLoja;
        private System.Windows.Forms.Label LblLoja;
        private System.Windows.Forms.TextBox TxtLojaProcura;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtDescricaoForn;
        private System.Windows.Forms.Button BtnProcurarForn;
        private System.Windows.Forms.Label LblCodFornecedor;
        private System.Windows.Forms.TextBox TxtProcurarForn;
        private System.Windows.Forms.Button BtnFornContas;
        private System.Windows.Forms.Button BtnLojasContas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn loja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;

    }
}