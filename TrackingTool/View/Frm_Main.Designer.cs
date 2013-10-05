namespace TrackingTool6.View
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lojasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosDeCustoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoPorCentroDeCustoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoPorFornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoPorLojaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeAlteraçãoDeSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._TrackingTool6_db_TrackingToolEntitiesDataSet = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSet();
            this.GPOperacoes = new System.Windows.Forms.GroupBox();
            this.BtnAddCentroCusto = new System.Windows.Forms.Button();
            this.BtnAddContasReceber = new System.Windows.Forms.Button();
            this.BtnAddContasPagar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GBFornecedor = new System.Windows.Forms.GroupBox();
            this.BtnListFornecedores = new System.Windows.Forms.Button();
            this.BtnAddFornecedor = new System.Windows.Forms.Button();
            this.GBLojas = new System.Windows.Forms.GroupBox();
            this.BtnListLojas = new System.Windows.Forms.Button();
            this.BtnAddLoja = new System.Windows.Forms.Button();
            this.GBRelatorios = new System.Windows.Forms.GroupBox();
            this.BtnRelatorios = new System.Windows.Forms.Button();
            this.PicBoxHiper = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).BeginInit();
            this.GPOperacoes.SuspendLayout();
            this.GBFornecedor.SuspendLayout();
            this.GBLojas.SuspendLayout();
            this.GBRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHiper)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedorToolStripMenuItem,
            this.lojasToolStripMenuItem,
            this.centrosDeCustoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cadastrarToolStripMenuItem.Text = "Listar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.removerToolStripMenuItem.Text = "Adicionar";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.alterarToolStripMenuItem.Text = "Editar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.listarToolStripMenuItem.Text = "Remover";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // lojasToolStripMenuItem
            // 
            this.lojasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.editarToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.removerToolStripMenuItem1});
            this.lojasToolStripMenuItem.Name = "lojasToolStripMenuItem";
            this.lojasToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.lojasToolStripMenuItem.Text = "Lojas";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.cadastrarToolStripMenuItem1.Text = "Listar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.editarToolStripMenuItem.Text = "Adicionar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // removerToolStripMenuItem1
            // 
            this.removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            this.removerToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.removerToolStripMenuItem1.Text = "Remover";
            // 
            // centrosDeCustoToolStripMenuItem
            // 
            this.centrosDeCustoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.adiciToolStripMenuItem,
            this.editarToolStripMenuItem2,
            this.removerToolStripMenuItem2});
            this.centrosDeCustoToolStripMenuItem.Name = "centrosDeCustoToolStripMenuItem";
            this.centrosDeCustoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.centrosDeCustoToolStripMenuItem.Text = "Centros De Custo";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // adiciToolStripMenuItem
            // 
            this.adiciToolStripMenuItem.Name = "adiciToolStripMenuItem";
            this.adiciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adiciToolStripMenuItem.Text = "Adicionar";
            this.adiciToolStripMenuItem.Click += new System.EventHandler(this.adiciToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem2
            // 
            this.editarToolStripMenuItem2.Name = "editarToolStripMenuItem2";
            this.editarToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.editarToolStripMenuItem2.Text = "Editar";
            // 
            // removerToolStripMenuItem2
            // 
            this.removerToolStripMenuItem2.Name = "removerToolStripMenuItem2";
            this.removerToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.removerToolStripMenuItem2.Text = "Remover";
            this.removerToolStripMenuItem2.Click += new System.EventHandler(this.removerToolStripMenuItem2_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saldoPorCentroDeCustoToolStripMenuItem1,
            this.saldoPorFornecedorToolStripMenuItem1,
            this.saldoPorLojaToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sobreToolStripMenuItem.Text = "Relatórios";
            // 
            // saldoPorCentroDeCustoToolStripMenuItem1
            // 
            this.saldoPorCentroDeCustoToolStripMenuItem1.Name = "saldoPorCentroDeCustoToolStripMenuItem1";
            this.saldoPorCentroDeCustoToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.saldoPorCentroDeCustoToolStripMenuItem1.Text = "Saldo por Centro de Custo";
            // 
            // saldoPorFornecedorToolStripMenuItem1
            // 
            this.saldoPorFornecedorToolStripMenuItem1.Name = "saldoPorFornecedorToolStripMenuItem1";
            this.saldoPorFornecedorToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.saldoPorFornecedorToolStripMenuItem1.Text = "Saldo por Fornecedor";
            // 
            // saldoPorLojaToolStripMenuItem1
            // 
            this.saldoPorLojaToolStripMenuItem1.Name = "saldoPorLojaToolStripMenuItem1";
            this.saldoPorLojaToolStripMenuItem1.Size = new System.Drawing.Size(212, 22);
            this.saldoPorLojaToolStripMenuItem1.Text = "Saldo por Loja";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosDeAlteraçãoDeSaldoToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // registrosDeAlteraçãoDeSaldoToolStripMenuItem
            // 
            this.registrosDeAlteraçãoDeSaldoToolStripMenuItem.Name = "registrosDeAlteraçãoDeSaldoToolStripMenuItem";
            this.registrosDeAlteraçãoDeSaldoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.registrosDeAlteraçãoDeSaldoToolStripMenuItem.Text = "Registros de alteração de Saldo";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            // 
            // _TrackingTool6_db_TrackingToolEntitiesDataSet
            // 
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.DataSetName = "_TrackingTool6_db_TrackingToolEntitiesDataSet";
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GPOperacoes
            // 
            this.GPOperacoes.Controls.Add(this.BtnAddCentroCusto);
            this.GPOperacoes.Controls.Add(this.BtnAddContasReceber);
            this.GPOperacoes.Controls.Add(this.BtnAddContasPagar);
            this.GPOperacoes.Controls.Add(this.button1);
            this.GPOperacoes.Location = new System.Drawing.Point(12, 57);
            this.GPOperacoes.Name = "GPOperacoes";
            this.GPOperacoes.Size = new System.Drawing.Size(163, 222);
            this.GPOperacoes.TabIndex = 2;
            this.GPOperacoes.TabStop = false;
            this.GPOperacoes.Text = "Operações Centros de Custo";
            // 
            // BtnAddCentroCusto
            // 
            this.BtnAddCentroCusto.Location = new System.Drawing.Point(5, 155);
            this.BtnAddCentroCusto.Name = "BtnAddCentroCusto";
            this.BtnAddCentroCusto.Size = new System.Drawing.Size(151, 23);
            this.BtnAddCentroCusto.TabIndex = 3;
            this.BtnAddCentroCusto.Text = "Adicionar Centro de Custo";
            this.BtnAddCentroCusto.UseVisualStyleBackColor = true;
            this.BtnAddCentroCusto.Click += new System.EventHandler(this.BtnAddCentroCusto_Click);
            // 
            // BtnAddContasReceber
            // 
            this.BtnAddContasReceber.Location = new System.Drawing.Point(6, 21);
            this.BtnAddContasReceber.Name = "BtnAddContasReceber";
            this.BtnAddContasReceber.Size = new System.Drawing.Size(150, 23);
            this.BtnAddContasReceber.TabIndex = 2;
            this.BtnAddContasReceber.Text = "Adicionar Contas a Receber";
            this.BtnAddContasReceber.UseVisualStyleBackColor = true;
            this.BtnAddContasReceber.Click += new System.EventHandler(this.BtnAddContasReceber_Click);
            // 
            // BtnAddContasPagar
            // 
            this.BtnAddContasPagar.Location = new System.Drawing.Point(7, 64);
            this.BtnAddContasPagar.Name = "BtnAddContasPagar";
            this.BtnAddContasPagar.Size = new System.Drawing.Size(150, 23);
            this.BtnAddContasPagar.TabIndex = 1;
            this.BtnAddContasPagar.Text = "Adicionar Contas a Pagar";
            this.BtnAddContasPagar.UseVisualStyleBackColor = true;
            this.BtnAddContasPagar.Click += new System.EventHandler(this.BtnAddContasPagar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Saldo Centros de Custo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(217, 304);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Fechar";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GBFornecedor
            // 
            this.GBFornecedor.Controls.Add(this.BtnListFornecedores);
            this.GBFornecedor.Controls.Add(this.BtnAddFornecedor);
            this.GBFornecedor.Location = new System.Drawing.Point(351, 57);
            this.GBFornecedor.Name = "GBFornecedor";
            this.GBFornecedor.Size = new System.Drawing.Size(163, 108);
            this.GBFornecedor.TabIndex = 4;
            this.GBFornecedor.TabStop = false;
            this.GBFornecedor.Text = "Fornecedor";
            // 
            // BtnListFornecedores
            // 
            this.BtnListFornecedores.Location = new System.Drawing.Point(6, 63);
            this.BtnListFornecedores.Name = "BtnListFornecedores";
            this.BtnListFornecedores.Size = new System.Drawing.Size(150, 23);
            this.BtnListFornecedores.TabIndex = 1;
            this.BtnListFornecedores.Text = "Listar Fornecedores";
            this.BtnListFornecedores.UseVisualStyleBackColor = true;
            this.BtnListFornecedores.Click += new System.EventHandler(this.BtnListFornecedores_Click);
            // 
            // BtnAddFornecedor
            // 
            this.BtnAddFornecedor.Location = new System.Drawing.Point(7, 20);
            this.BtnAddFornecedor.Name = "BtnAddFornecedor";
            this.BtnAddFornecedor.Size = new System.Drawing.Size(150, 23);
            this.BtnAddFornecedor.TabIndex = 0;
            this.BtnAddFornecedor.Text = "Adicionar Fornecedor";
            this.BtnAddFornecedor.UseVisualStyleBackColor = true;
            this.BtnAddFornecedor.Click += new System.EventHandler(this.BtnAddFornecedor_Click);
            // 
            // GBLojas
            // 
            this.GBLojas.Controls.Add(this.BtnListLojas);
            this.GBLojas.Controls.Add(this.BtnAddLoja);
            this.GBLojas.Location = new System.Drawing.Point(351, 171);
            this.GBLojas.Name = "GBLojas";
            this.GBLojas.Size = new System.Drawing.Size(163, 108);
            this.GBLojas.TabIndex = 5;
            this.GBLojas.TabStop = false;
            this.GBLojas.Text = "Lojas";
            // 
            // BtnListLojas
            // 
            this.BtnListLojas.Location = new System.Drawing.Point(6, 63);
            this.BtnListLojas.Name = "BtnListLojas";
            this.BtnListLojas.Size = new System.Drawing.Size(150, 23);
            this.BtnListLojas.TabIndex = 1;
            this.BtnListLojas.Text = "Listar Lojas";
            this.BtnListLojas.UseVisualStyleBackColor = true;
            this.BtnListLojas.Click += new System.EventHandler(this.BtnListLojas_Click);
            // 
            // BtnAddLoja
            // 
            this.BtnAddLoja.Location = new System.Drawing.Point(6, 20);
            this.BtnAddLoja.Name = "BtnAddLoja";
            this.BtnAddLoja.Size = new System.Drawing.Size(150, 23);
            this.BtnAddLoja.TabIndex = 0;
            this.BtnAddLoja.Text = "Adicionar Loja";
            this.BtnAddLoja.UseVisualStyleBackColor = true;
            this.BtnAddLoja.Click += new System.EventHandler(this.BtnAddLoja_Click);
            // 
            // GBRelatorios
            // 
            this.GBRelatorios.Controls.Add(this.BtnRelatorios);
            this.GBRelatorios.Location = new System.Drawing.Point(183, 57);
            this.GBRelatorios.Name = "GBRelatorios";
            this.GBRelatorios.Size = new System.Drawing.Size(162, 108);
            this.GBRelatorios.TabIndex = 6;
            this.GBRelatorios.TabStop = false;
            this.GBRelatorios.Text = "Relatórios";
            // 
            // BtnRelatorios
            // 
            this.BtnRelatorios.Location = new System.Drawing.Point(7, 20);
            this.BtnRelatorios.Name = "BtnRelatorios";
            this.BtnRelatorios.Size = new System.Drawing.Size(149, 23);
            this.BtnRelatorios.TabIndex = 0;
            this.BtnRelatorios.Text = "Gerar Relatorios";
            this.BtnRelatorios.UseVisualStyleBackColor = true;
            // 
            // PicBoxHiper
            // 
            this.PicBoxHiper.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxHiper.Image")));
            this.PicBoxHiper.Location = new System.Drawing.Point(183, 171);
            this.PicBoxHiper.Name = "PicBoxHiper";
            this.PicBoxHiper.Size = new System.Drawing.Size(162, 108);
            this.PicBoxHiper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxHiper.TabIndex = 7;
            this.PicBoxHiper.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 339);
            this.Controls.Add(this.PicBoxHiper);
            this.Controls.Add(this.GBRelatorios);
            this.Controls.Add(this.GBLojas);
            this.Controls.Add(this.GBFornecedor);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.GPOperacoes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking Tool 0.9.8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).EndInit();
            this.GPOperacoes.ResumeLayout(false);
            this.GBFornecedor.ResumeLayout(false);
            this.GBLojas.ResumeLayout(false);
            this.GBRelatorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHiper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lojasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem centrosDeCustoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adiciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoPorCentroDeCustoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saldoPorFornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saldoPorLojaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeAlteraçãoDeSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private _TrackingTool6_db_TrackingToolEntitiesDataSet _TrackingTool6_db_TrackingToolEntitiesDataSet;
        private System.Windows.Forms.GroupBox GPOperacoes;
        private System.Windows.Forms.Button BtnAddCentroCusto;
        private System.Windows.Forms.Button BtnAddContasReceber;
        private System.Windows.Forms.Button BtnAddContasPagar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox GBFornecedor;
        private System.Windows.Forms.Button BtnListFornecedores;
        private System.Windows.Forms.Button BtnAddFornecedor;
        private System.Windows.Forms.GroupBox GBLojas;
        private System.Windows.Forms.Button BtnListLojas;
        private System.Windows.Forms.Button BtnAddLoja;
        private System.Windows.Forms.GroupBox GBRelatorios;
        private System.Windows.Forms.Button BtnRelatorios;
        private System.Windows.Forms.PictureBox PicBoxHiper;
    }
}