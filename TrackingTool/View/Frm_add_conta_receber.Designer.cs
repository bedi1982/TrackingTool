namespace TrackingTool6.View
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
            this.GBDadosConta = new System.Windows.Forms.GroupBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtNovoValor = new System.Windows.Forms.TextBox();
            this.LblNovoValor = new System.Windows.Forms.Label();
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnContaRecebida = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.GBDadosConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDadosConta
            // 
            this.GBDadosConta.Controls.Add(this.BtnOK);
            this.GBDadosConta.Controls.Add(this.TxtNovoValor);
            this.GBDadosConta.Controls.Add(this.LblNovoValor);
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
            this.GBDadosConta.Location = new System.Drawing.Point(87, 12);
            this.GBDadosConta.Name = "GBDadosConta";
            this.GBDadosConta.Size = new System.Drawing.Size(718, 286);
            this.GBDadosConta.TabIndex = 0;
            this.GBDadosConta.TabStop = false;
            this.GBDadosConta.Text = "Dados da Conta";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(271, 231);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(31, 20);
            this.BtnOK.TabIndex = 10;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Visible = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtNovoValor
            // 
            this.TxtNovoValor.AcceptsTab = true;
            this.TxtNovoValor.Location = new System.Drawing.Point(141, 231);
            this.TxtNovoValor.Name = "TxtNovoValor";
            this.TxtNovoValor.Size = new System.Drawing.Size(124, 20);
            this.TxtNovoValor.TabIndex = 9;
            this.TxtNovoValor.Visible = false;
            // 
            // LblNovoValor
            // 
            this.LblNovoValor.AutoSize = true;
            this.LblNovoValor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblNovoValor.Location = new System.Drawing.Point(16, 233);
            this.LblNovoValor.Name = "LblNovoValor";
            this.LblNovoValor.Size = new System.Drawing.Size(119, 16);
            this.LblNovoValor.TabIndex = 26;
            this.LblNovoValor.Text = "Alteração de Valor:";
            this.LblNovoValor.Visible = false;
            // 
            // TxtLojaDescricao
            // 
            this.TxtLojaDescricao.AcceptsTab = true;
            this.TxtLojaDescricao.Location = new System.Drawing.Point(239, 125);
            this.TxtLojaDescricao.Name = "TxtLojaDescricao";
            this.TxtLojaDescricao.ReadOnly = true;
            this.TxtLojaDescricao.Size = new System.Drawing.Size(422, 20);
            this.TxtLojaDescricao.TabIndex = 24;
            // 
            // BtnProcuraLoja
            // 
            this.BtnProcuraLoja.Location = new System.Drawing.Point(202, 125);
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
            this.LblLoja.Location = new System.Drawing.Point(29, 125);
            this.LblLoja.Name = "LblLoja";
            this.LblLoja.Size = new System.Drawing.Size(98, 16);
            this.LblLoja.TabIndex = 22;
            this.LblLoja.Text = "Código da Loja:";
            // 
            // TxtLojaProcura
            // 
            this.TxtLojaProcura.AcceptsTab = true;
            this.TxtLojaProcura.Location = new System.Drawing.Point(141, 125);
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
            "EVENTUAL",
            "MENSALIDADE"});
            this.CBTipo.Location = new System.Drawing.Point(459, 93);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(121, 21);
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
            this.BtnAtualizar.Location = new System.Drawing.Point(620, 257);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(92, 23);
            this.BtnAtualizar.TabIndex = 9;
            this.BtnAtualizar.Text = "Atualizar lista";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // DataCadastro
            // 
            this.DataCadastro.Location = new System.Drawing.Point(447, 159);
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Size = new System.Drawing.Size(214, 20);
            this.DataCadastro.TabIndex = 6;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblData.Location = new System.Drawing.Point(313, 164);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(127, 16);
            this.LblData.TabIndex = 14;
            this.LblData.Text = "Data do Pagamento:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(12, 257);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Adicionar";
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
            this.LblSaldo.Size = new System.Drawing.Size(161, 16);
            this.LblSaldo.TabIndex = 11;
            this.LblSaldo.Text = "Saldo Atual deste  Centro:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.AcceptsTab = true;
            this.TxtDescricao.Location = new System.Drawing.Point(141, 194);
            this.TxtDescricao.Multiline = true;
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(535, 20);
            this.TxtDescricao.TabIndex = 8;
            // 
            // LblDescrição
            // 
            this.LblDescrição.AutoSize = true;
            this.LblDescrição.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDescrição.Location = new System.Drawing.Point(9, 198);
            this.LblDescrição.Name = "LblDescrição";
            this.LblDescrição.Size = new System.Drawing.Size(137, 16);
            this.LblDescrição.TabIndex = 9;
            this.LblDescrição.Text = "Descrição da Entrada:";
            // 
            // TxtValor
            // 
            this.TxtValor.AcceptsTab = true;
            this.TxtValor.Location = new System.Drawing.Point(141, 160);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(124, 20);
            this.TxtValor.TabIndex = 7;
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblValor.Location = new System.Drawing.Point(29, 161);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(95, 16);
            this.LblValor.TabIndex = 7;
            this.LblValor.Text = "Valor do Título:";
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.Location = new System.Drawing.Point(459, 27);
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
            this.TxtCentroCusto.Location = new System.Drawing.Point(191, 29);
            this.TxtCentroCusto.Name = "TxtCentroCusto";
            this.TxtCentroCusto.Size = new System.Drawing.Size(250, 20);
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
            this.BtnVoltar.Location = new System.Drawing.Point(784, 504);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 12;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // GridContasReceber
            // 
            this.GridContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.descricao,
            this.Valor,
            this.CentroCusto,
            this.Data,
            this.dataCad,
            this.tipo,
            this.loja});
            this.GridContasReceber.Location = new System.Drawing.Point(13, 304);
            this.GridContasReceber.MultiSelect = false;
            this.GridContasReceber.Name = "GridContasReceber";
            this.GridContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridContasReceber.Size = new System.Drawing.Size(846, 194);
            this.GridContasReceber.TabIndex = 8;
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
            // codigo
            // 
            this.codigo.HeaderText = "Código da Conta";
            this.codigo.Name = "codigo";
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descricao.HeaderText = "Descrição da Conta";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 90;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Valor.Width = 56;
            // 
            // CentroCusto
            // 
            this.CentroCusto.HeaderText = "Centro de Custo";
            this.CentroCusto.Name = "CentroCusto";
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Data.HeaderText = "Data do Pagamento";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 116;
            // 
            // dataCad
            // 
            this.dataCad.HeaderText = "Data de Cadastro";
            this.dataCad.Name = "dataCad";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo da Conta";
            this.tipo.Name = "tipo";
            // 
            // loja
            // 
            this.loja.HeaderText = "Loja";
            this.loja.Name = "loja";
            // 
            // BtnContaRecebida
            // 
            this.BtnContaRecebida.Location = new System.Drawing.Point(99, 504);
            this.BtnContaRecebida.Name = "BtnContaRecebida";
            this.BtnContaRecebida.Size = new System.Drawing.Size(103, 23);
            this.BtnContaRecebida.TabIndex = 25;
            this.BtnContaRecebida.TabStop = false;
            this.BtnContaRecebida.Text = "Receber Conta";
            this.BtnContaRecebida.UseVisualStyleBackColor = true;
            this.BtnContaRecebida.Click += new System.EventHandler(this.BtnContaRecebida_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExcluir.Location = new System.Drawing.Point(228, 504);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 23);
            this.BtnExcluir.TabIndex = 26;
            this.BtnExcluir.TabStop = false;
            this.BtnExcluir.Text = "Excluir Conta";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // Frm_add_conta_receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 551);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnContaRecebida);
            this.Controls.Add(this.GridContasReceber);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.GBDadosConta);
            this.Name = "Frm_add_conta_receber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Conta a Receber";
            this.GBDadosConta.ResumeLayout(false);
            this.GBDadosConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridContasReceber)).EndInit();
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
        private System.Windows.Forms.Button BtnContaRecebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn loja;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TextBox TxtNovoValor;
        private System.Windows.Forms.Label LblNovoValor;
        private System.Windows.Forms.Button BtnOK;

    }
}