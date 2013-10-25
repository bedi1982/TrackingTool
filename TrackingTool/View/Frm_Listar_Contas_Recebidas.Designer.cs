namespace Tracking.View
{
    partial class Frm_Listar_Contas_Recebidas
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
            this.DGContasReceber = new System.Windows.Forms.DataGridView();
            this.idCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastradoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebeCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LojaCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCustoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.LbTotal = new System.Windows.Forms.Label();
            this.TxtTotalReceber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LblDataInicio = new System.Windows.Forms.Label();
            this.LblDataFinal = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.TxtCentroCusto = new System.Windows.Forms.TextBox();
            this.LbCentroCusto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.TxtLoja = new System.Windows.Forms.TextBox();
            this.LblLoja = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // DGContasReceber
            // 
            this.DGContasReceber.AllowUserToDeleteRows = false;
            this.DGContasReceber.AllowUserToOrderColumns = true;
            this.DGContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCR,
            this.dataCadastradoCR,
            this.dataRecebeCR,
            this.CodigoCR,
            this.LojaCR,
            this.FornecedorCR,
            this.DescricaoCR,
            this.TipoCR,
            this.CentroCustoCR,
            this.ValorCR});
            this.DGContasReceber.Location = new System.Drawing.Point(12, 75);
            this.DGContasReceber.Name = "DGContasReceber";
            this.DGContasReceber.ReadOnly = true;
            this.DGContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGContasReceber.Size = new System.Drawing.Size(1087, 519);
            this.DGContasReceber.TabIndex = 1;
            // 
            // idCR
            // 
            this.idCR.HeaderText = "ID";
            this.idCR.Name = "idCR";
            this.idCR.ReadOnly = true;
            this.idCR.Width = 80;
            // 
            // dataCadastradoCR
            // 
            this.dataCadastradoCR.HeaderText = "Data do Cadastro";
            this.dataCadastradoCR.Name = "dataCadastradoCR";
            this.dataCadastradoCR.ReadOnly = true;
            // 
            // dataRecebeCR
            // 
            this.dataRecebeCR.HeaderText = "Data do Recebimento";
            this.dataRecebeCR.Name = "dataRecebeCR";
            this.dataRecebeCR.ReadOnly = true;
            // 
            // CodigoCR
            // 
            this.CodigoCR.HeaderText = "Código";
            this.CodigoCR.Name = "CodigoCR";
            this.CodigoCR.ReadOnly = true;
            // 
            // LojaCR
            // 
            this.LojaCR.HeaderText = "Loja";
            this.LojaCR.Name = "LojaCR";
            this.LojaCR.ReadOnly = true;
            // 
            // FornecedorCR
            // 
            this.FornecedorCR.HeaderText = "Fornecedor";
            this.FornecedorCR.Name = "FornecedorCR";
            this.FornecedorCR.ReadOnly = true;
            // 
            // DescricaoCR
            // 
            this.DescricaoCR.HeaderText = "Descrição da Conta";
            this.DescricaoCR.Name = "DescricaoCR";
            this.DescricaoCR.ReadOnly = true;
            this.DescricaoCR.Width = 160;
            // 
            // TipoCR
            // 
            this.TipoCR.HeaderText = "Tipo";
            this.TipoCR.Name = "TipoCR";
            this.TipoCR.ReadOnly = true;
            // 
            // CentroCustoCR
            // 
            this.CentroCustoCR.HeaderText = "Centro de Custo";
            this.CentroCustoCR.Name = "CentroCustoCR";
            this.CentroCustoCR.ReadOnly = true;
            // 
            // ValorCR
            // 
            this.ValorCR.HeaderText = "Valor R$";
            this.ValorCR.Name = "ValorCR";
            this.ValorCR.ReadOnly = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.BtnVoltar.Location = new System.Drawing.Point(996, 636);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(103, 23);
            this.BtnVoltar.TabIndex = 29;
            this.BtnVoltar.TabStop = false;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(797, 607);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(172, 19);
            this.LbTotal.TabIndex = 37;
            this.LbTotal.Text = "Valor Total Recebido:";
            // 
            // TxtTotalReceber
            // 
            this.TxtTotalReceber.AcceptsTab = true;
            this.TxtTotalReceber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtTotalReceber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtTotalReceber.ForeColor = System.Drawing.Color.Red;
            this.TxtTotalReceber.Location = new System.Drawing.Point(975, 600);
            this.TxtTotalReceber.Name = "TxtTotalReceber";
            this.TxtTotalReceber.Size = new System.Drawing.Size(124, 26);
            this.TxtTotalReceber.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(577, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 40;
            // 
            // LblDataInicio
            // 
            this.LblDataInicio.AutoSize = true;
            this.LblDataInicio.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDataInicio.Location = new System.Drawing.Point(9, 27);
            this.LblDataInicio.Name = "LblDataInicio";
            this.LblDataInicio.Size = new System.Drawing.Size(164, 16);
            this.LblDataInicio.TabIndex = 41;
            this.LblDataInicio.Text = "Data Inicial (Recebimento):";
            // 
            // LblDataFinal
            // 
            this.LblDataFinal.AutoSize = true;
            this.LblDataFinal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDataFinal.Location = new System.Drawing.Point(412, 23);
            this.LblDataFinal.Name = "LblDataFinal";
            this.LblDataFinal.Size = new System.Drawing.Size(159, 16);
            this.LblDataFinal.TabIndex = 42;
            this.LblDataFinal.Text = "Data Final (Recebimento):";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.BtnFiltrar.Location = new System.Drawing.Point(783, 16);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(103, 23);
            this.BtnFiltrar.TabIndex = 43;
            this.BtnFiltrar.TabStop = false;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Location = new System.Drawing.Point(346, 604);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(103, 23);
            this.BtnExcel.TabIndex = 49;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "Gerar Relatório";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(12, 604);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(329, 24);
            this.txtArquivoExcel.TabIndex = 50;
            this.txtArquivoExcel.Text = "C:\\Users\\Thiago\\Desktop\\Contas Recebidas";
            // 
            // TxtCentroCusto
            // 
            this.TxtCentroCusto.AcceptsTab = true;
            this.TxtCentroCusto.Location = new System.Drawing.Point(576, 49);
            this.TxtCentroCusto.Name = "TxtCentroCusto";
            this.TxtCentroCusto.Size = new System.Drawing.Size(124, 20);
            this.TxtCentroCusto.TabIndex = 72;
            // 
            // LbCentroCusto
            // 
            this.LbCentroCusto.AutoSize = true;
            this.LbCentroCusto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LbCentroCusto.Location = new System.Drawing.Point(464, 53);
            this.LbCentroCusto.Name = "LbCentroCusto";
            this.LbCentroCusto.Size = new System.Drawing.Size(106, 16);
            this.LbCentroCusto.TabIndex = 75;
            this.LbCentroCusto.Text = "Centro de Custo:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(333, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 71;
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblFornecedor.Location = new System.Drawing.Point(250, 50);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(77, 16);
            this.LblFornecedor.TabIndex = 74;
            this.LblFornecedor.Text = "Fornecedor:";
            // 
            // TxtLoja
            // 
            this.TxtLoja.AcceptsTab = true;
            this.TxtLoja.Location = new System.Drawing.Point(179, 49);
            this.TxtLoja.Name = "TxtLoja";
            this.TxtLoja.Size = new System.Drawing.Size(66, 20);
            this.TxtLoja.TabIndex = 70;
            // 
            // LblLoja
            // 
            this.LblLoja.AutoSize = true;
            this.LblLoja.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblLoja.Location = new System.Drawing.Point(136, 53);
            this.LblLoja.Name = "LblLoja";
            this.LblLoja.Size = new System.Drawing.Size(36, 16);
            this.LblLoja.TabIndex = 73;
            this.LblLoja.Text = "Loja:";
            // 
            // Frm_Listar_Contas_Recebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 671);
            this.Controls.Add(this.TxtCentroCusto);
            this.Controls.Add(this.LbCentroCusto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblFornecedor);
            this.Controls.Add(this.TxtLoja);
            this.Controls.Add(this.LblLoja);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.LblDataFinal);
            this.Controls.Add(this.LblDataInicio);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.TxtTotalReceber);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.DGContasReceber);
            this.Name = "Frm_Listar_Contas_Recebidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas Recebidas";
            ((System.ComponentModel.ISupportInitialize)(this.DGContasReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGContasReceber;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.TextBox TxtTotalReceber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LblDataInicio;
        private System.Windows.Forms.Label LblDataFinal;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastradoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebeCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn LojaCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCustoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCR;
        private System.Windows.Forms.TextBox TxtCentroCusto;
        private System.Windows.Forms.Label LbCentroCusto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.TextBox TxtLoja;
        private System.Windows.Forms.Label LblLoja;
    }
}