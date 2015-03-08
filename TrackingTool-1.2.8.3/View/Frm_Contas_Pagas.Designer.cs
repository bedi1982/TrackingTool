namespace Tracking.View
{
    partial class Frm_Contas_Pagas
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
            this.DGContasPagas = new System.Windows.Forms.DataGridView();
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
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.LbTotalPago = new System.Windows.Forms.Label();
            this.TxtTotalPago = new System.Windows.Forms.TextBox();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.TxtFornFiltro = new System.Windows.Forms.TextBox();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.TxtLojaFiltro = new System.Windows.Forms.TextBox();
            this.LblLoja = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.LblDataFinal = new System.Windows.Forms.Label();
            this.LblDataInicio = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtCentroCustoFiltro = new System.Windows.Forms.TextBox();
            this.LbCentroCusto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGContasPagas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGContasPagas
            // 
            this.DGContasPagas.AllowUserToAddRows = false;
            this.DGContasPagas.AllowUserToDeleteRows = false;
            this.DGContasPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGContasPagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DGContasPagas.Location = new System.Drawing.Point(12, 75);
            this.DGContasPagas.Name = "DGContasPagas";
            this.DGContasPagas.ReadOnly = true;
            this.DGContasPagas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGContasPagas.Size = new System.Drawing.Size(1087, 519);
            this.DGContasPagas.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // dataCad
            // 
            this.dataCad.HeaderText = "Data de Cadastro";
            this.dataCad.Name = "dataCad";
            this.dataCad.ReadOnly = true;
            this.dataCad.Width = 110;
            // 
            // DataPagar
            // 
            this.DataPagar.HeaderText = "Data de Pagamento";
            this.DataPagar.Name = "DataPagar";
            this.DataPagar.ReadOnly = true;
            this.DataPagar.Width = 110;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código da Conta";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
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
            this.Descricao.Width = 150;
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
            this.Valor.Width = 95;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.BtnVoltar.Location = new System.Drawing.Point(996, 636);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(103, 23);
            this.BtnVoltar.TabIndex = 7;
            this.BtnVoltar.TabStop = false;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // LbTotalPago
            // 
            this.LbTotalPago.AutoSize = true;
            this.LbTotalPago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotalPago.Location = new System.Drawing.Point(830, 610);
            this.LbTotalPago.Name = "LbTotalPago";
            this.LbTotalPago.Size = new System.Drawing.Size(139, 19);
            this.LbTotalPago.TabIndex = 40;
            this.LbTotalPago.Text = "Valor Total Pago:";
            // 
            // TxtTotalPago
            // 
            this.TxtTotalPago.AcceptsTab = true;
            this.TxtTotalPago.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtTotalPago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtTotalPago.ForeColor = System.Drawing.Color.Red;
            this.TxtTotalPago.Location = new System.Drawing.Point(975, 603);
            this.TxtTotalPago.Name = "TxtTotalPago";
            this.TxtTotalPago.Size = new System.Drawing.Size(124, 26);
            this.TxtTotalPago.TabIndex = 39;
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(12, 604);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(329, 24);
            this.txtArquivoExcel.TabIndex = 5;
            this.txtArquivoExcel.Text = "C:\\Users\\Thiago\\Desktop\\Contas Pagas";
            // 
            // BtnExcel
            // 
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Location = new System.Drawing.Point(346, 604);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(103, 23);
            this.BtnExcel.TabIndex = 6;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "Gerar Relatório";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // TxtFornFiltro
            // 
            this.TxtFornFiltro.AcceptsTab = true;
            this.TxtFornFiltro.Location = new System.Drawing.Point(333, 49);
            this.TxtFornFiltro.Name = "TxtFornFiltro";
            this.TxtFornFiltro.Size = new System.Drawing.Size(66, 20);
            this.TxtFornFiltro.TabIndex = 2;
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblFornecedor.Location = new System.Drawing.Point(250, 50);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(77, 16);
            this.LblFornecedor.TabIndex = 67;
            this.LblFornecedor.Text = "Fornecedor:";
            // 
            // TxtLojaFiltro
            // 
            this.TxtLojaFiltro.AcceptsTab = true;
            this.TxtLojaFiltro.Location = new System.Drawing.Point(178, 49);
            this.TxtLojaFiltro.Name = "TxtLojaFiltro";
            this.TxtLojaFiltro.Size = new System.Drawing.Size(66, 20);
            this.TxtLojaFiltro.TabIndex = 1;
            // 
            // LblLoja
            // 
            this.LblLoja.AutoSize = true;
            this.LblLoja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblLoja.Location = new System.Drawing.Point(136, 53);
            this.LblLoja.Name = "LblLoja";
            this.LblLoja.Size = new System.Drawing.Size(36, 16);
            this.LblLoja.TabIndex = 65;
            this.LblLoja.Text = "Loja:";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BtnFiltrar.Location = new System.Drawing.Point(931, 20);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(103, 23);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.TabStop = false;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // LblDataFinal
            // 
            this.LblDataFinal.AutoSize = true;
            this.LblDataFinal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDataFinal.Location = new System.Drawing.Point(421, 27);
            this.LblDataFinal.Name = "LblDataFinal";
            this.LblDataFinal.Size = new System.Drawing.Size(149, 16);
            this.LblDataFinal.TabIndex = 62;
            this.LblDataFinal.Text = "Data Final (Pagamento):";
            // 
            // LblDataInicio
            // 
            this.LblDataInicio.AutoSize = true;
            this.LblDataInicio.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDataInicio.Location = new System.Drawing.Point(18, 27);
            this.LblDataInicio.Name = "LblDataInicio";
            this.LblDataInicio.Size = new System.Drawing.Size(154, 16);
            this.LblDataInicio.TabIndex = 61;
            this.LblDataInicio.Text = "Data Inicial (Pagamento):";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(576, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 60;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // TxtCentroCustoFiltro
            // 
            this.TxtCentroCustoFiltro.AcceptsTab = true;
            this.TxtCentroCustoFiltro.Location = new System.Drawing.Point(576, 49);
            this.TxtCentroCustoFiltro.Name = "TxtCentroCustoFiltro";
            this.TxtCentroCustoFiltro.Size = new System.Drawing.Size(124, 20);
            this.TxtCentroCustoFiltro.TabIndex = 3;
            // 
            // LbCentroCusto
            // 
            this.LbCentroCusto.AutoSize = true;
            this.LbCentroCusto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LbCentroCusto.Location = new System.Drawing.Point(464, 53);
            this.LbCentroCusto.Name = "LbCentroCusto";
            this.LbCentroCusto.Size = new System.Drawing.Size(106, 16);
            this.LbCentroCusto.TabIndex = 69;
            this.LbCentroCusto.Text = "Centro de Custo:";
            // 
            // Frm_Contas_Pagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 671);
            this.Controls.Add(this.TxtCentroCustoFiltro);
            this.Controls.Add(this.LbCentroCusto);
            this.Controls.Add(this.TxtFornFiltro);
            this.Controls.Add(this.LblFornecedor);
            this.Controls.Add(this.TxtLojaFiltro);
            this.Controls.Add(this.LblLoja);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.LblDataFinal);
            this.Controls.Add(this.LblDataInicio);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.LbTotalPago);
            this.Controls.Add(this.TxtTotalPago);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.DGContasPagas);
            this.Name = "Frm_Contas_Pagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Pagas";
            ((System.ComponentModel.ISupportInitialize)(this.DGContasPagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGContasPagas;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label LbTotalPago;
        private System.Windows.Forms.TextBox TxtTotalPago;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.TextBox TxtFornFiltro;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.TextBox TxtLojaFiltro;
        private System.Windows.Forms.Label LblLoja;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label LblDataFinal;
        private System.Windows.Forms.Label LblDataInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtCentroCustoFiltro;
        private System.Windows.Forms.Label LbCentroCusto;
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