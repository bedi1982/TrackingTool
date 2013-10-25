namespace Tracking.View
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
            this.GBDadosConta = new System.Windows.Forms.GroupBox();
            this.BtnFornContas = new System.Windows.Forms.Button();
            this.TxtLojaDescricao = new System.Windows.Forms.TextBox();
            this.BtnLojasContas = new System.Windows.Forms.Button();
            this.TxtFornecedorDescricao = new System.Windows.Forms.TextBox();
            this.BtnProcuraLoja = new System.Windows.Forms.Button();
            this.BtnProcuraFornecedor = new System.Windows.Forms.Button();
            this.LblLoja = new System.Windows.Forms.Label();
            this.TxtLojaProcura = new System.Windows.Forms.TextBox();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.TxtFornecedorProcura = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
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
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.CBTipoSaida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LojaCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBDadosConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGContasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDadosConta
            // 
            this.GBDadosConta.Controls.Add(this.label1);
            this.GBDadosConta.Controls.Add(this.CBTipoSaida);
            this.GBDadosConta.Controls.Add(this.BtnFornContas);
            this.GBDadosConta.Controls.Add(this.TxtLojaDescricao);
            this.GBDadosConta.Controls.Add(this.BtnLojasContas);
            this.GBDadosConta.Controls.Add(this.TxtFornecedorDescricao);
            this.GBDadosConta.Controls.Add(this.BtnProcuraLoja);
            this.GBDadosConta.Controls.Add(this.BtnProcuraFornecedor);
            this.GBDadosConta.Controls.Add(this.LblLoja);
            this.GBDadosConta.Controls.Add(this.TxtLojaProcura);
            this.GBDadosConta.Controls.Add(this.LblFornecedor);
            this.GBDadosConta.Controls.Add(this.TxtFornecedorProcura);
            this.GBDadosConta.Controls.Add(this.LblCodigo);
            this.GBDadosConta.Controls.Add(this.TxtCodigo);
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
            this.GBDadosConta.Location = new System.Drawing.Point(153, 12);
            this.GBDadosConta.Name = "GBDadosConta";
            this.GBDadosConta.Size = new System.Drawing.Size(718, 286);
            this.GBDadosConta.TabIndex = 1;
            this.GBDadosConta.TabStop = false;
            this.GBDadosConta.Text = "Dados da Conta";
            // 
            // BtnFornContas
            // 
            this.BtnFornContas.Image = global::Tracking.Properties.Resources.Search_icon;
            this.BtnFornContas.Location = new System.Drawing.Point(675, 156);
            this.BtnFornContas.Name = "BtnFornContas";
            this.BtnFornContas.Size = new System.Drawing.Size(26, 20);
            this.BtnFornContas.TabIndex = 31;
            this.BtnFornContas.Text = "...";
            this.BtnFornContas.UseVisualStyleBackColor = true;
            this.BtnFornContas.Click += new System.EventHandler(this.BtnFornContas_Click);
            // 
            // TxtLojaDescricao
            // 
            this.TxtLojaDescricao.AcceptsTab = true;
            this.TxtLojaDescricao.Location = new System.Drawing.Point(247, 125);
            this.TxtLojaDescricao.Name = "TxtLojaDescricao";
            this.TxtLojaDescricao.ReadOnly = true;
            this.TxtLojaDescricao.Size = new System.Drawing.Size(422, 20);
            this.TxtLojaDescricao.TabIndex = 33;
            // 
            // BtnLojasContas
            // 
            this.BtnLojasContas.Image = global::Tracking.Properties.Resources.Search_icon;
            this.BtnLojasContas.Location = new System.Drawing.Point(675, 125);
            this.BtnLojasContas.Name = "BtnLojasContas";
            this.BtnLojasContas.Size = new System.Drawing.Size(26, 20);
            this.BtnLojasContas.TabIndex = 30;
            this.BtnLojasContas.Text = "...";
            this.BtnLojasContas.UseVisualStyleBackColor = true;
            this.BtnLojasContas.Click += new System.EventHandler(this.BtnLojasContas_Click);
            // 
            // TxtFornecedorDescricao
            // 
            this.TxtFornecedorDescricao.AcceptsTab = true;
            this.TxtFornecedorDescricao.Location = new System.Drawing.Point(247, 157);
            this.TxtFornecedorDescricao.Name = "TxtFornecedorDescricao";
            this.TxtFornecedorDescricao.ReadOnly = true;
            this.TxtFornecedorDescricao.Size = new System.Drawing.Size(422, 20);
            this.TxtFornecedorDescricao.TabIndex = 24;
            // 
            // BtnProcuraLoja
            // 
            this.BtnProcuraLoja.Location = new System.Drawing.Point(211, 124);
            this.BtnProcuraLoja.Name = "BtnProcuraLoja";
            this.BtnProcuraLoja.Size = new System.Drawing.Size(26, 20);
            this.BtnProcuraLoja.TabIndex = 5;
            this.BtnProcuraLoja.Text = "...";
            this.BtnProcuraLoja.UseVisualStyleBackColor = true;
            this.BtnProcuraLoja.Click += new System.EventHandler(this.BtnProcuraLoja_Click);
            // 
            // BtnProcuraFornecedor
            // 
            this.BtnProcuraFornecedor.Location = new System.Drawing.Point(211, 156);
            this.BtnProcuraFornecedor.Name = "BtnProcuraFornecedor";
            this.BtnProcuraFornecedor.Size = new System.Drawing.Size(26, 20);
            this.BtnProcuraFornecedor.TabIndex = 7;
            this.BtnProcuraFornecedor.Text = "...";
            this.BtnProcuraFornecedor.UseVisualStyleBackColor = true;
            this.BtnProcuraFornecedor.Click += new System.EventHandler(this.BtnProcuraFornecedor_Click);
            // 
            // LblLoja
            // 
            this.LblLoja.AutoSize = true;
            this.LblLoja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblLoja.Location = new System.Drawing.Point(37, 125);
            this.LblLoja.Name = "LblLoja";
            this.LblLoja.Size = new System.Drawing.Size(98, 16);
            this.LblLoja.TabIndex = 32;
            this.LblLoja.Text = "Código da Loja:";
            // 
            // TxtLojaProcura
            // 
            this.TxtLojaProcura.AcceptsTab = true;
            this.TxtLojaProcura.Location = new System.Drawing.Point(150, 125);
            this.TxtLojaProcura.Name = "TxtLojaProcura";
            this.TxtLojaProcura.Size = new System.Drawing.Size(55, 20);
            this.TxtLojaProcura.TabIndex = 4;
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblFornecedor.Location = new System.Drawing.Point(4, 157);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(139, 16);
            this.LblFornecedor.TabIndex = 22;
            this.LblFornecedor.Text = "Código do Fornecedor:";
            // 
            // TxtFornecedorProcura
            // 
            this.TxtFornecedorProcura.AcceptsTab = true;
            this.TxtFornecedorProcura.Location = new System.Drawing.Point(149, 156);
            this.TxtFornecedorProcura.Name = "TxtFornecedorProcura";
            this.TxtFornecedorProcura.Size = new System.Drawing.Size(56, 20);
            this.TxtFornecedorProcura.TabIndex = 6;
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
            // DataCadastro
            // 
            this.DataCadastro.Location = new System.Drawing.Point(447, 188);
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Size = new System.Drawing.Size(214, 20);
            this.DataCadastro.TabIndex = 7;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblData.Location = new System.Drawing.Point(312, 192);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(129, 16);
            this.LblData.TabIndex = 14;
            this.LblData.Text = "Data de Vencimento:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(626, 257);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.LblSaldo.Size = new System.Drawing.Size(156, 16);
            this.LblSaldo.TabIndex = 11;
            this.LblSaldo.Text = "Saldo Atual deste Centro:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.AcceptsTab = true;
            this.TxtDescricao.Location = new System.Drawing.Point(149, 221);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(520, 20);
            this.TxtDescricao.TabIndex = 9;
            // 
            // LblDescrição
            // 
            this.LblDescrição.AutoSize = true;
            this.LblDescrição.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDescrição.Location = new System.Drawing.Point(9, 221);
            this.LblDescrição.Name = "LblDescrição";
            this.LblDescrição.Size = new System.Drawing.Size(126, 16);
            this.LblDescrição.TabIndex = 9;
            this.LblDescrição.Text = "Descrição da Conta:";
            // 
            // TxtValor
            // 
            this.TxtValor.AcceptsTab = true;
            this.TxtValor.Location = new System.Drawing.Point(149, 188);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(91, 20);
            this.TxtValor.TabIndex = 8;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblValor.Location = new System.Drawing.Point(14, 189);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(129, 16);
            this.LblValor.TabIndex = 7;
            this.LblValor.Text = "Valor do Pagamento:";
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.DGContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGContasPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataCad,
            this.DataPagar,
            this.Codigo,
            this.LojaCP,
            this.FornGrid,
            this.TipoCP,
            this.Descricao,
            this.CentroCusto,
            this.Valor});
            this.DGContasPagar.Location = new System.Drawing.Point(23, 304);
            this.DGContasPagar.Name = "DGContasPagar";
            this.DGContasPagar.ReadOnly = true;
            this.DGContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGContasPagar.Size = new System.Drawing.Size(934, 194);
            this.DGContasPagar.TabIndex = 2;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Red;
            this.BtnExcluir.Location = new System.Drawing.Point(23, 516);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 23);
            this.BtnExcluir.TabIndex = 29;
            this.BtnExcluir.Text = "Excluir Conta";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(882, 516);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 12;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // CBTipoSaida
            // 
            this.CBTipoSaida.FormattingEnabled = true;
            this.CBTipoSaida.Location = new System.Drawing.Point(540, 61);
            this.CBTipoSaida.Name = "CBTipoSaida";
            this.CBTipoSaida.Size = new System.Drawing.Size(161, 21);
            this.CBTipoSaida.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(443, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tipo de Saída:";
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // dataCad
            // 
            this.dataCad.HeaderText = "Data de Cadastro";
            this.dataCad.Name = "dataCad";
            this.dataCad.ReadOnly = true;
            // 
            // DataPagar
            // 
            this.DataPagar.HeaderText = "Data de Pagamento";
            this.DataPagar.Name = "DataPagar";
            this.DataPagar.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código da Conta";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // LojaCP
            // 
            this.LojaCP.HeaderText = "Loja";
            this.LojaCP.Name = "LojaCP";
            this.LojaCP.ReadOnly = true;
            // 
            // FornGrid
            // 
            this.FornGrid.HeaderText = "Fornecedor";
            this.FornGrid.Name = "FornGrid";
            this.FornGrid.ReadOnly = true;
            // 
            // TipoCP
            // 
            this.TipoCP.HeaderText = "Tipo de Saída";
            this.TipoCP.Name = "TipoCP";
            this.TipoCP.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição da Conta";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // CentroCusto
            // 
            this.CentroCusto.HeaderText = "Centro de Custo";
            this.CentroCusto.Name = "CentroCusto";
            this.CentroCusto.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor R$";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // Frm_Add_Conta_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 551);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.DGContasPagar);
            this.Controls.Add(this.GBDadosConta);
            this.Name = "Frm_Add_Conta_Pagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Conta a Pagar";
            this.GBDadosConta.ResumeLayout(false);
            this.GBDadosConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGContasPagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBDadosConta;
        private System.Windows.Forms.TextBox TxtFornecedorDescricao;
        private System.Windows.Forms.Button BtnProcuraFornecedor;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.TextBox TxtFornecedorProcura;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtCodigo;
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
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.TextBox TxtLojaDescricao;
        private System.Windows.Forms.Button BtnProcuraLoja;
        private System.Windows.Forms.Label LblLoja;
        private System.Windows.Forms.TextBox TxtLojaProcura;
        private System.Windows.Forms.Button BtnFornContas;
        private System.Windows.Forms.Button BtnLojasContas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTipoSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LojaCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}