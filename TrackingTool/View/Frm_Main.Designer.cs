namespace Tracking.View
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
            this.ContasPorReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasRecebidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasPagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.PicBoxHiper = new System.Windows.Forms.PictureBox();
            this.GroupRelatorios = new System.Windows.Forms.GroupBox();
            this.BtnContasPagas = new System.Windows.Forms.Button();
            this.BtnContasRecebidas = new System.Windows.Forms.Button();
            this.BtnContaReceber = new System.Windows.Forms.Button();
            this.BtnContasAPagar = new System.Windows.Forms.Button();
            this.GroupBalanço = new System.Windows.Forms.GroupBox();
            this.txt_cdc_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a_pagar = new System.Windows.Forms.TextBox();
            this.txt_a_receber = new System.Windows.Forms.TextBox();
            this.btn_atualizar_balanco = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnTodasContas = new System.Windows.Forms.Button();
            this.BtnMF = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.GPOperacoes.SuspendLayout();
            this.GBFornecedor.SuspendLayout();
            this.GBLojas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHiper)).BeginInit();
            this.GroupRelatorios.SuspendLayout();
            this.GroupBalanço.SuspendLayout();
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
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
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
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem.Text = "Listar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.removerToolStripMenuItem.Text = "Adicionar";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.alterarToolStripMenuItem.Text = "Editar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
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
            this.lojasToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.lojasToolStripMenuItem.Text = "Lojas";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem1.Text = "Listar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editarToolStripMenuItem.Text = "Adicionar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // removerToolStripMenuItem1
            // 
            this.removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            this.removerToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.removerToolStripMenuItem1.Text = "Remover";
            this.removerToolStripMenuItem1.Click += new System.EventHandler(this.removerToolStripMenuItem1_Click);
            // 
            // centrosDeCustoToolStripMenuItem
            // 
            this.centrosDeCustoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.adiciToolStripMenuItem,
            this.editarToolStripMenuItem2,
            this.removerToolStripMenuItem2});
            this.centrosDeCustoToolStripMenuItem.Name = "centrosDeCustoToolStripMenuItem";
            this.centrosDeCustoToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.centrosDeCustoToolStripMenuItem.Text = "Centros De Custo";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // adiciToolStripMenuItem
            // 
            this.adiciToolStripMenuItem.Name = "adiciToolStripMenuItem";
            this.adiciToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adiciToolStripMenuItem.Text = "Adicionar";
            this.adiciToolStripMenuItem.Click += new System.EventHandler(this.adiciToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem2
            // 
            this.editarToolStripMenuItem2.Name = "editarToolStripMenuItem2";
            this.editarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.editarToolStripMenuItem2.Text = "Editar";
            this.editarToolStripMenuItem2.Click += new System.EventHandler(this.editarToolStripMenuItem2_Click);
            // 
            // removerToolStripMenuItem2
            // 
            this.removerToolStripMenuItem2.Name = "removerToolStripMenuItem2";
            this.removerToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.removerToolStripMenuItem2.Text = "Remover";
            this.removerToolStripMenuItem2.Click += new System.EventHandler(this.removerToolStripMenuItem2_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saldoPorCentroDeCustoToolStripMenuItem1,
            this.ContasPorReceberToolStripMenuItem,
            this.ContasAPagarToolStripMenuItem,
            this.contasRecebidasToolStripMenuItem,
            this.contasPagasToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sobreToolStripMenuItem.Text = "Relatórios";
            // 
            // saldoPorCentroDeCustoToolStripMenuItem1
            // 
            this.saldoPorCentroDeCustoToolStripMenuItem1.Name = "saldoPorCentroDeCustoToolStripMenuItem1";
            this.saldoPorCentroDeCustoToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.saldoPorCentroDeCustoToolStripMenuItem1.Text = "Saldo por Centro de Custo";
            this.saldoPorCentroDeCustoToolStripMenuItem1.Click += new System.EventHandler(this.saldoPorCentroDeCustoToolStripMenuItem1_Click);
            // 
            // ContasPorReceberToolStripMenuItem
            // 
            this.ContasPorReceberToolStripMenuItem.Name = "ContasPorReceberToolStripMenuItem";
            this.ContasPorReceberToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ContasPorReceberToolStripMenuItem.Text = "Contas a Receber";
            this.ContasPorReceberToolStripMenuItem.Click += new System.EventHandler(this.ContasPorReceberToolStripMenuItem_Click);
            // 
            // ContasAPagarToolStripMenuItem
            // 
            this.ContasAPagarToolStripMenuItem.Name = "ContasAPagarToolStripMenuItem";
            this.ContasAPagarToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ContasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.ContasAPagarToolStripMenuItem.Click += new System.EventHandler(this.ContasAPagarToolStripMenuItem_Click);
            // 
            // contasRecebidasToolStripMenuItem
            // 
            this.contasRecebidasToolStripMenuItem.Name = "contasRecebidasToolStripMenuItem";
            this.contasRecebidasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contasRecebidasToolStripMenuItem.Text = "Contas Recebidas";
            this.contasRecebidasToolStripMenuItem.Click += new System.EventHandler(this.contasRecebidasToolStripMenuItem_Click);
            // 
            // contasPagasToolStripMenuItem
            // 
            this.contasPagasToolStripMenuItem.Name = "contasPagasToolStripMenuItem";
            this.contasPagasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.contasPagasToolStripMenuItem.Text = "Contas Pagas";
            this.contasPagasToolStripMenuItem.Click += new System.EventHandler(this.contasPagasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // GPOperacoes
            // 
            this.GPOperacoes.Controls.Add(this.BtnAddCentroCusto);
            this.GPOperacoes.Controls.Add(this.BtnAddContasReceber);
            this.GPOperacoes.Controls.Add(this.BtnAddContasPagar);
            this.GPOperacoes.Controls.Add(this.button1);
            this.GPOperacoes.Location = new System.Drawing.Point(12, 35);
            this.GPOperacoes.Name = "GPOperacoes";
            this.GPOperacoes.Size = new System.Drawing.Size(200, 251);
            this.GPOperacoes.TabIndex = 2;
            this.GPOperacoes.TabStop = false;
            this.GPOperacoes.Text = "Operações Centros de Custo";
            // 
            // BtnAddCentroCusto
            // 
            this.BtnAddCentroCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCentroCusto.Location = new System.Drawing.Point(24, 149);
            this.BtnAddCentroCusto.Name = "BtnAddCentroCusto";
            this.BtnAddCentroCusto.Size = new System.Drawing.Size(151, 23);
            this.BtnAddCentroCusto.TabIndex = 3;
            this.BtnAddCentroCusto.Text = "Adicionar Centro de Custo";
            this.BtnAddCentroCusto.UseVisualStyleBackColor = true;
            this.BtnAddCentroCusto.Click += new System.EventHandler(this.BtnAddCentroCusto_Click);
            // 
            // BtnAddContasReceber
            // 
            this.BtnAddContasReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddContasReceber.Location = new System.Drawing.Point(25, 21);
            this.BtnAddContasReceber.Name = "BtnAddContasReceber";
            this.BtnAddContasReceber.Size = new System.Drawing.Size(150, 23);
            this.BtnAddContasReceber.TabIndex = 2;
            this.BtnAddContasReceber.Text = "Adicionar Contas a Receber";
            this.BtnAddContasReceber.UseVisualStyleBackColor = true;
            this.BtnAddContasReceber.Click += new System.EventHandler(this.BtnAddContasReceber_Click);
            // 
            // BtnAddContasPagar
            // 
            this.BtnAddContasPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddContasPagar.Location = new System.Drawing.Point(25, 64);
            this.BtnAddContasPagar.Name = "BtnAddContasPagar";
            this.BtnAddContasPagar.Size = new System.Drawing.Size(150, 23);
            this.BtnAddContasPagar.TabIndex = 1;
            this.BtnAddContasPagar.Text = "Adicionar Contas a Pagar";
            this.BtnAddContasPagar.UseVisualStyleBackColor = true;
            this.BtnAddContasPagar.Click += new System.EventHandler(this.BtnAddContasPagar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Saldo Centros de Custo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(544, 357);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Sair";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GBFornecedor
            // 
            this.GBFornecedor.Controls.Add(this.BtnListFornecedores);
            this.GBFornecedor.Controls.Add(this.BtnAddFornecedor);
            this.GBFornecedor.Location = new System.Drawing.Point(232, 292);
            this.GBFornecedor.Name = "GBFornecedor";
            this.GBFornecedor.Size = new System.Drawing.Size(200, 108);
            this.GBFornecedor.TabIndex = 4;
            this.GBFornecedor.TabStop = false;
            this.GBFornecedor.Text = "Fornecedor";
            // 
            // BtnListFornecedores
            // 
            this.BtnListFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListFornecedores.Location = new System.Drawing.Point(21, 61);
            this.BtnListFornecedores.Name = "BtnListFornecedores";
            this.BtnListFornecedores.Size = new System.Drawing.Size(151, 23);
            this.BtnListFornecedores.TabIndex = 1;
            this.BtnListFornecedores.Text = "Listar Fornecedores";
            this.BtnListFornecedores.UseVisualStyleBackColor = true;
            this.BtnListFornecedores.Click += new System.EventHandler(this.BtnListFornecedores_Click);
            // 
            // BtnAddFornecedor
            // 
            this.BtnAddFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddFornecedor.Location = new System.Drawing.Point(21, 20);
            this.BtnAddFornecedor.Name = "BtnAddFornecedor";
            this.BtnAddFornecedor.Size = new System.Drawing.Size(151, 23);
            this.BtnAddFornecedor.TabIndex = 0;
            this.BtnAddFornecedor.Text = "Adicionar Fornecedor";
            this.BtnAddFornecedor.UseVisualStyleBackColor = true;
            this.BtnAddFornecedor.Click += new System.EventHandler(this.BtnAddFornecedor_Click);
            // 
            // GBLojas
            // 
            this.GBLojas.Controls.Add(this.BtnListLojas);
            this.GBLojas.Controls.Add(this.BtnAddLoja);
            this.GBLojas.Location = new System.Drawing.Point(12, 292);
            this.GBLojas.Name = "GBLojas";
            this.GBLojas.Size = new System.Drawing.Size(200, 108);
            this.GBLojas.TabIndex = 5;
            this.GBLojas.TabStop = false;
            this.GBLojas.Text = "Lojas";
            // 
            // BtnListLojas
            // 
            this.BtnListLojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListLojas.Location = new System.Drawing.Point(24, 61);
            this.BtnListLojas.Name = "BtnListLojas";
            this.BtnListLojas.Size = new System.Drawing.Size(151, 23);
            this.BtnListLojas.TabIndex = 1;
            this.BtnListLojas.Text = "Listar Lojas";
            this.BtnListLojas.UseVisualStyleBackColor = true;
            this.BtnListLojas.Click += new System.EventHandler(this.BtnListLojas_Click);
            // 
            // BtnAddLoja
            // 
            this.BtnAddLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddLoja.Location = new System.Drawing.Point(24, 20);
            this.BtnAddLoja.Name = "BtnAddLoja";
            this.BtnAddLoja.Size = new System.Drawing.Size(151, 23);
            this.BtnAddLoja.TabIndex = 0;
            this.BtnAddLoja.Text = "Adicionar Loja";
            this.BtnAddLoja.UseVisualStyleBackColor = true;
            this.BtnAddLoja.Click += new System.EventHandler(this.BtnAddLoja_Click);
            // 
            // PicBoxHiper
            // 
            this.PicBoxHiper.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxHiper.Image")));
            this.PicBoxHiper.Location = new System.Drawing.Point(491, 259);
            this.PicBoxHiper.Name = "PicBoxHiper";
            this.PicBoxHiper.Size = new System.Drawing.Size(159, 121);
            this.PicBoxHiper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxHiper.TabIndex = 7;
            this.PicBoxHiper.TabStop = false;
            // 
            // GroupRelatorios
            // 
            this.GroupRelatorios.Controls.Add(this.BtnMF);
            this.GroupRelatorios.Controls.Add(this.BtnTodasContas);
            this.GroupRelatorios.Controls.Add(this.BtnContasPagas);
            this.GroupRelatorios.Controls.Add(this.BtnContasRecebidas);
            this.GroupRelatorios.Controls.Add(this.BtnContaReceber);
            this.GroupRelatorios.Controls.Add(this.BtnContasAPagar);
            this.GroupRelatorios.Location = new System.Drawing.Point(232, 35);
            this.GroupRelatorios.Name = "GroupRelatorios";
            this.GroupRelatorios.Size = new System.Drawing.Size(200, 251);
            this.GroupRelatorios.TabIndex = 8;
            this.GroupRelatorios.TabStop = false;
            this.GroupRelatorios.Text = "Principais Relatórios";
            // 
            // BtnContasPagas
            // 
            this.BtnContasPagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContasPagas.Location = new System.Drawing.Point(21, 104);
            this.BtnContasPagas.Name = "BtnContasPagas";
            this.BtnContasPagas.Size = new System.Drawing.Size(151, 23);
            this.BtnContasPagas.TabIndex = 3;
            this.BtnContasPagas.Text = "Contas Pagas";
            this.BtnContasPagas.UseVisualStyleBackColor = true;
            this.BtnContasPagas.Click += new System.EventHandler(this.BtnContasPagas_Click);
            // 
            // BtnContasRecebidas
            // 
            this.BtnContasRecebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContasRecebidas.Location = new System.Drawing.Point(21, 149);
            this.BtnContasRecebidas.Name = "BtnContasRecebidas";
            this.BtnContasRecebidas.Size = new System.Drawing.Size(151, 23);
            this.BtnContasRecebidas.TabIndex = 2;
            this.BtnContasRecebidas.Text = "Contas Recebidas";
            this.BtnContasRecebidas.UseVisualStyleBackColor = true;
            this.BtnContasRecebidas.Click += new System.EventHandler(this.BtnContasRecebidas_Click);
            // 
            // BtnContaReceber
            // 
            this.BtnContaReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContaReceber.Location = new System.Drawing.Point(21, 64);
            this.BtnContaReceber.Name = "BtnContaReceber";
            this.BtnContaReceber.Size = new System.Drawing.Size(151, 23);
            this.BtnContaReceber.TabIndex = 1;
            this.BtnContaReceber.Text = "Contas a Receber";
            this.BtnContaReceber.UseVisualStyleBackColor = true;
            this.BtnContaReceber.Click += new System.EventHandler(this.BtnContaReceber_Click);
            // 
            // BtnContasAPagar
            // 
            this.BtnContasAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContasAPagar.Location = new System.Drawing.Point(21, 21);
            this.BtnContasAPagar.Name = "BtnContasAPagar";
            this.BtnContasAPagar.Size = new System.Drawing.Size(151, 23);
            this.BtnContasAPagar.TabIndex = 0;
            this.BtnContasAPagar.Text = "Contas a Pagar";
            this.BtnContasAPagar.UseVisualStyleBackColor = true;
            this.BtnContasAPagar.Click += new System.EventHandler(this.BtnContasAPagar_Click);
            // 
            // GroupBalanço
            // 
            this.GroupBalanço.Controls.Add(this.txt_cdc_total);
            this.GroupBalanço.Controls.Add(this.label3);
            this.GroupBalanço.Controls.Add(this.label2);
            this.GroupBalanço.Controls.Add(this.label1);
            this.GroupBalanço.Controls.Add(this.txt_a_pagar);
            this.GroupBalanço.Controls.Add(this.txt_a_receber);
            this.GroupBalanço.Controls.Add(this.btn_atualizar_balanco);
            this.GroupBalanço.Location = new System.Drawing.Point(450, 35);
            this.GroupBalanço.Name = "GroupBalanço";
            this.GroupBalanço.Size = new System.Drawing.Size(200, 215);
            this.GroupBalanço.TabIndex = 10;
            this.GroupBalanço.TabStop = false;
            this.GroupBalanço.Text = "Balanço Geral:";
            // 
            // txt_cdc_total
            // 
            this.txt_cdc_total.ForeColor = System.Drawing.Color.Maroon;
            this.txt_cdc_total.Location = new System.Drawing.Point(41, 140);
            this.txt_cdc_total.Name = "txt_cdc_total";
            this.txt_cdc_total.Size = new System.Drawing.Size(110, 20);
            this.txt_cdc_total.TabIndex = 6;
            this.txt_cdc_total.Text = "Pressione Atualizar";
            this.txt_cdc_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo Centros de Custo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "A Pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A Receber:";
            // 
            // txt_a_pagar
            // 
            this.txt_a_pagar.ForeColor = System.Drawing.Color.Maroon;
            this.txt_a_pagar.Location = new System.Drawing.Point(41, 91);
            this.txt_a_pagar.Name = "txt_a_pagar";
            this.txt_a_pagar.Size = new System.Drawing.Size(110, 20);
            this.txt_a_pagar.TabIndex = 2;
            this.txt_a_pagar.Text = "Pressione Atualizar";
            this.txt_a_pagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_a_receber
            // 
            this.txt_a_receber.ForeColor = System.Drawing.Color.Maroon;
            this.txt_a_receber.Location = new System.Drawing.Point(41, 42);
            this.txt_a_receber.Name = "txt_a_receber";
            this.txt_a_receber.Size = new System.Drawing.Size(110, 20);
            this.txt_a_receber.TabIndex = 1;
            this.txt_a_receber.Text = "Pressione Atualizar";
            this.txt_a_receber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_atualizar_balanco
            // 
            this.btn_atualizar_balanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_balanco.Location = new System.Drawing.Point(119, 176);
            this.btn_atualizar_balanco.Name = "btn_atualizar_balanco";
            this.btn_atualizar_balanco.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar_balanco.TabIndex = 0;
            this.btn_atualizar_balanco.Text = "Atualizar";
            this.btn_atualizar_balanco.UseVisualStyleBackColor = true;
            this.btn_atualizar_balanco.Click += new System.EventHandler(this.btn_atualizar_balanco_Click);
            // 
            // BtnTodasContas
            // 
            this.BtnTodasContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTodasContas.Location = new System.Drawing.Point(21, 187);
            this.BtnTodasContas.Name = "BtnTodasContas";
            this.BtnTodasContas.Size = new System.Drawing.Size(151, 23);
            this.BtnTodasContas.TabIndex = 4;
            this.BtnTodasContas.Text = "Todas as Contas";
            this.BtnTodasContas.UseVisualStyleBackColor = true;
            this.BtnTodasContas.Click += new System.EventHandler(this.BtnTodasContas_Click);
            // 
            // BtnMF
            // 
            this.BtnMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMF.Location = new System.Drawing.Point(21, 222);
            this.BtnMF.Name = "BtnMF";
            this.BtnMF.Size = new System.Drawing.Size(151, 23);
            this.BtnMF.TabIndex = 5;
            this.BtnMF.Text = "Borderô";
            this.BtnMF.UseVisualStyleBackColor = true;
            this.BtnMF.Click += new System.EventHandler(this.BtnMF_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 401);
            this.Controls.Add(this.GroupBalanço);
            this.Controls.Add(this.GroupRelatorios);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PicBoxHiper);
            this.Controls.Add(this.GBLojas);
            this.Controls.Add(this.GBFornecedor);
            this.Controls.Add(this.GPOperacoes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking Tool 1.2.5.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GPOperacoes.ResumeLayout(false);
            this.GBFornecedor.ResumeLayout(false);
            this.GBLojas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxHiper)).EndInit();
            this.GroupRelatorios.ResumeLayout(false);
            this.GroupBalanço.ResumeLayout(false);
            this.GroupBalanço.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
       
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
        private System.Windows.Forms.PictureBox PicBoxHiper;
        private System.Windows.Forms.ToolStripMenuItem ContasPorReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContasAPagarToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupRelatorios;
        private System.Windows.Forms.Button BtnContaReceber;
        private System.Windows.Forms.Button BtnContasAPagar;
        private System.Windows.Forms.GroupBox GroupBalanço;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a_pagar;
        private System.Windows.Forms.TextBox txt_a_receber;
        private System.Windows.Forms.Button btn_atualizar_balanco;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txt_cdc_total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnContasRecebidas;
        private System.Windows.Forms.Button BtnContasPagas;
        private System.Windows.Forms.ToolStripMenuItem contasRecebidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasPagasToolStripMenuItem;
        private System.Windows.Forms.Button BtnTodasContas;
        private System.Windows.Forms.Button BtnMF;
    }
}