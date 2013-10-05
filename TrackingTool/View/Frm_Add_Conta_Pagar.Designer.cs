namespace TrackingTool6.View
{
    partial class Frm_Add_Conta_Pagar
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
            this.components = new System.ComponentModel.Container();
            this.GBDadosConta = new System.Windows.Forms.GroupBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtNovoValor = new System.Windows.Forms.TextBox();
            this.LblNovoValor = new System.Windows.Forms.Label();
            this.TxtFornecedorDescricao = new System.Windows.Forms.TextBox();
            this.BtnProcuraFornecedor = new System.Windows.Forms.Button();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.TxtFornecedorProcura = new System.Windows.Forms.TextBox();
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
            this.DGContasPagar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contaAPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._TrackingTool6_db_TrackingToolEntitiesDataSet = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSet();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnContaRecebida = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.contaAPagarTableAdapter = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.ContaAPagarTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centroCustoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GBDadosConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGContasPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaAPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDadosConta
            // 
            this.GBDadosConta.Controls.Add(this.BtnOK);
            this.GBDadosConta.Controls.Add(this.TxtNovoValor);
            this.GBDadosConta.Controls.Add(this.LblNovoValor);
            this.GBDadosConta.Controls.Add(this.TxtFornecedorDescricao);
            this.GBDadosConta.Controls.Add(this.BtnProcuraFornecedor);
            this.GBDadosConta.Controls.Add(this.LblFornecedor);
            this.GBDadosConta.Controls.Add(this.TxtFornecedorProcura);
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
            this.GBDadosConta.Location = new System.Drawing.Point(89, 12);
            this.GBDadosConta.Name = "GBDadosConta";
            this.GBDadosConta.Size = new System.Drawing.Size(718, 286);
            this.GBDadosConta.TabIndex = 1;
            this.GBDadosConta.TabStop = false;
            this.GBDadosConta.Text = "Dados da Conta";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(272, 231);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(31, 20);
            this.BtnOK.TabIndex = 27;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Visible = false;
            // 
            // TxtNovoValor
            // 
            this.TxtNovoValor.AcceptsTab = true;
            this.TxtNovoValor.Location = new System.Drawing.Point(141, 231);
            this.TxtNovoValor.Name = "TxtNovoValor";
            this.TxtNovoValor.Size = new System.Drawing.Size(124, 20);
            this.TxtNovoValor.TabIndex = 25;
            this.TxtNovoValor.Visible = false;
            // 
            // LblNovoValor
            // 
            this.LblNovoValor.AutoSize = true;
            this.LblNovoValor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblNovoValor.Location = new System.Drawing.Point(57, 235);
            this.LblNovoValor.Name = "LblNovoValor";
            this.LblNovoValor.Size = new System.Drawing.Size(74, 16);
            this.LblNovoValor.TabIndex = 26;
            this.LblNovoValor.Text = "Novo Valor:";
            this.LblNovoValor.Visible = false;
            // 
            // TxtFornecedorDescricao
            // 
            this.TxtFornecedorDescricao.AcceptsTab = true;
            this.TxtFornecedorDescricao.Location = new System.Drawing.Point(289, 125);
            this.TxtFornecedorDescricao.Name = "TxtFornecedorDescricao";
            this.TxtFornecedorDescricao.ReadOnly = true;
            this.TxtFornecedorDescricao.Size = new System.Drawing.Size(357, 20);
            this.TxtFornecedorDescricao.TabIndex = 24;
            // 
            // BtnProcuraFornecedor
            // 
            this.BtnProcuraFornecedor.Location = new System.Drawing.Point(253, 127);
            this.BtnProcuraFornecedor.Name = "BtnProcuraFornecedor";
            this.BtnProcuraFornecedor.Size = new System.Drawing.Size(26, 20);
            this.BtnProcuraFornecedor.TabIndex = 5;
            this.BtnProcuraFornecedor.Text = "...";
            this.BtnProcuraFornecedor.UseVisualStyleBackColor = true;
            this.BtnProcuraFornecedor.Click += new System.EventHandler(this.BtnProcuraFornecedor_Click);
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblFornecedor.Location = new System.Drawing.Point(29, 127);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(139, 16);
            this.LblFornecedor.TabIndex = 22;
            this.LblFornecedor.Text = "Código do Fornecedor:";
            // 
            // TxtFornecedorProcura
            // 
            this.TxtFornecedorProcura.AcceptsTab = true;
            this.TxtFornecedorProcura.Location = new System.Drawing.Point(174, 128);
            this.TxtFornecedorProcura.Name = "TxtFornecedorProcura";
            this.TxtFornecedorProcura.Size = new System.Drawing.Size(56, 20);
            this.TxtFornecedorProcura.TabIndex = 4;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblCodigo.Location = new System.Drawing.Point(29, 95);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(218, 16);
            this.LblCodigo.TabIndex = 18;
            this.LblCodigo.Text = "Código de Barras deste Pagamento:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.AcceptsTab = true;
            this.TxtCodigo.Location = new System.Drawing.Point(256, 94);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(287, 20);
            this.TxtCodigo.TabIndex = 3;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(637, 257);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAtualizar.TabIndex = 10;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // DataCadastro
            // 
            this.DataCadastro.Location = new System.Drawing.Point(447, 159);
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Size = new System.Drawing.Size(214, 20);
            this.DataCadastro.TabIndex = 7;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblData.Location = new System.Drawing.Point(313, 164);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(130, 16);
            this.LblData.TabIndex = 14;
            this.LblData.Text = "Data de Vencimento:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(556, 257);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.AcceptsTab = true;
            this.TxtSaldo.Location = new System.Drawing.Point(256, 62);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.ReadOnly = true;
            this.TxtSaldo.Size = new System.Drawing.Size(124, 20);
            this.TxtSaldo.TabIndex = 12;
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblSaldo.Location = new System.Drawing.Point(29, 63);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(157, 16);
            this.LblSaldo.TabIndex = 11;
            this.LblSaldo.Text = "Saldo Atual deste Centro:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.AcceptsTab = true;
            this.TxtDescricao.Location = new System.Drawing.Point(141, 198);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(520, 20);
            this.TxtDescricao.TabIndex = 8;
            // 
            // LblDescrição
            // 
            this.LblDescrição.AutoSize = true;
            this.LblDescrição.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDescrição.Location = new System.Drawing.Point(9, 198);
            this.LblDescrição.Name = "LblDescrição";
            this.LblDescrição.Size = new System.Drawing.Size(126, 16);
            this.LblDescrição.TabIndex = 9;
            this.LblDescrição.Text = "Descrição da Conta:";
            // 
            // TxtValor
            // 
            this.TxtValor.AcceptsTab = true;
            this.TxtValor.Location = new System.Drawing.Point(174, 157);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(91, 20);
            this.TxtValor.TabIndex = 6;
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblValor.Location = new System.Drawing.Point(34, 161);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(130, 16);
            this.LblValor.TabIndex = 7;
            this.LblValor.Text = "Valor do Pagamento:";
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.Location = new System.Drawing.Point(586, 27);
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Size = new System.Drawing.Size(75, 23);
            this.BtnProcurar.TabIndex = 2;
            this.BtnProcurar.Text = "Procurar";
            this.BtnProcurar.UseVisualStyleBackColor = true;
            this.BtnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // TxtCentroCusto
            // 
            this.TxtCentroCusto.AcceptsTab = true;
            this.TxtCentroCusto.Location = new System.Drawing.Point(256, 29);
            this.TxtCentroCusto.Name = "TxtCentroCusto";
            this.TxtCentroCusto.Size = new System.Drawing.Size(287, 20);
            this.TxtCentroCusto.TabIndex = 1;
            // 
            // LblCentroCusto
            // 
            this.LblCentroCusto.AutoSize = true;
            this.LblCentroCusto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblCentroCusto.Location = new System.Drawing.Point(29, 30);
            this.LblCentroCusto.Name = "LblCentroCusto";
            this.LblCentroCusto.Size = new System.Drawing.Size(221, 16);
            this.LblCentroCusto.TabIndex = 4;
            this.LblCentroCusto.Text = "Nome do Centro de Custo de Débito:";
            // 
            // DGContasPagar
            // 
            this.DGContasPagar.AllowUserToAddRows = false;
            this.DGContasPagar.AllowUserToDeleteRows = false;
            this.DGContasPagar.AutoGenerateColumns = false;
            this.DGContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGContasPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Descricao,
            this.Valor,
            this.CentroCusto,
            this.DataPagar,
            this.dataCad,
            this.FornGrid,
            this.idDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.dataRecebeDataGridViewTextBoxColumn,
            this.dataCadastradoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.centroCustoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.DGContasPagar.DataSource = this.contaAPagarBindingSource;
            this.DGContasPagar.Location = new System.Drawing.Point(23, 304);
            this.DGContasPagar.Name = "DGContasPagar";
            this.DGContasPagar.ReadOnly = true;
            this.DGContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGContasPagar.Size = new System.Drawing.Size(834, 194);
            this.DGContasPagar.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código da Conta";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição da Conta";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 150;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // CentroCusto
            // 
            this.CentroCusto.HeaderText = "Centro de Custo";
            this.CentroCusto.Name = "CentroCusto";
            this.CentroCusto.ReadOnly = true;
            // 
            // DataPagar
            // 
            this.DataPagar.HeaderText = "Data de Pagamento";
            this.DataPagar.Name = "DataPagar";
            this.DataPagar.ReadOnly = true;
            // 
            // dataCad
            // 
            this.dataCad.HeaderText = "Data de Cadastro";
            this.dataCad.Name = "dataCad";
            this.dataCad.ReadOnly = true;
            // 
            // FornGrid
            // 
            this.FornGrid.HeaderText = "Fornecedor";
            this.FornGrid.Name = "FornGrid";
            this.FornGrid.ReadOnly = true;
            this.FornGrid.Width = 120;
            // 
            // contaAPagarBindingSource
            // 
            this.contaAPagarBindingSource.DataMember = "ContaAPagar";
            this.contaAPagarBindingSource.DataSource = this._TrackingTool6_db_TrackingToolEntitiesDataSet;
            // 
            // _TrackingTool6_db_TrackingToolEntitiesDataSet
            // 
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.DataSetName = "_TrackingTool6_db_TrackingToolEntitiesDataSet";
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(617, 504);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 23);
            this.BtnExcluir.TabIndex = 29;
            this.BtnExcluir.Text = "Excluir Conta";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnContaRecebida
            // 
            this.BtnContaRecebida.Location = new System.Drawing.Point(508, 504);
            this.BtnContaRecebida.Name = "BtnContaRecebida";
            this.BtnContaRecebida.Size = new System.Drawing.Size(103, 23);
            this.BtnContaRecebida.TabIndex = 28;
            this.BtnContaRecebida.Text = "Conta Recebida";
            this.BtnContaRecebida.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(726, 504);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 27;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // contaAPagarTableAdapter
            // 
            this.contaAPagarTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRecebeDataGridViewTextBoxColumn
            // 
            this.dataRecebeDataGridViewTextBoxColumn.DataPropertyName = "dataRecebe";
            this.dataRecebeDataGridViewTextBoxColumn.HeaderText = "dataRecebe";
            this.dataRecebeDataGridViewTextBoxColumn.Name = "dataRecebeDataGridViewTextBoxColumn";
            this.dataRecebeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastradoDataGridViewTextBoxColumn
            // 
            this.dataCadastradoDataGridViewTextBoxColumn.DataPropertyName = "dataCadastrado";
            this.dataCadastradoDataGridViewTextBoxColumn.HeaderText = "dataCadastrado";
            this.dataCadastradoDataGridViewTextBoxColumn.Name = "dataCadastradoDataGridViewTextBoxColumn";
            this.dataCadastradoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centroCustoDataGridViewTextBoxColumn
            // 
            this.centroCustoDataGridViewTextBoxColumn.DataPropertyName = "centroCusto";
            this.centroCustoDataGridViewTextBoxColumn.HeaderText = "centroCusto";
            this.centroCustoDataGridViewTextBoxColumn.Name = "centroCustoDataGridViewTextBoxColumn";
            this.centroCustoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Frm_Add_Conta_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 547);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnContaRecebida);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.DGContasPagar);
            this.Controls.Add(this.GBDadosConta);
            this.Name = "Frm_Add_Conta_Pagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Conta a Pagar";
            this.Load += new System.EventHandler(this.Frm_Add_Conta_Pagar_Load);
            this.GBDadosConta.ResumeLayout(false);
            this.GBDadosConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGContasPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaAPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDadosConta;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtNovoValor;
        private System.Windows.Forms.Label LblNovoValor;
        private System.Windows.Forms.TextBox TxtFornecedorDescricao;
        private System.Windows.Forms.Button BtnProcuraFornecedor;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.TextBox TxtFornecedorProcura;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.DateTimePicker DataCadastro;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label LblDescrição;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.TextBox TxtCentroCusto;
        private System.Windows.Forms.Label LblCentroCusto;
        private System.Windows.Forms.DataGridView DGContasPagar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnContaRecebida;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornGrid;
        private _TrackingTool6_db_TrackingToolEntitiesDataSet _TrackingTool6_db_TrackingToolEntitiesDataSet;
        private System.Windows.Forms.BindingSource contaAPagarBindingSource;
        private _TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.ContaAPagarTableAdapter contaAPagarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centroCustoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}