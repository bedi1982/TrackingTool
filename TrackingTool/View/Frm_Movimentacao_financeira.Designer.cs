namespace Tracking.View
{
    partial class Frm_Movimentacao_financeira
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
            this.DGMovimentacao = new System.Windows.Forms.DataGridView();
            this.ContaMF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitoMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldofinalMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoextratoMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferencaMV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conciliacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnOK = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.BtnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGMovimentacao)).BeginInit();
            this.SuspendLayout();
            // 
            // DGMovimentacao
            // 
            this.DGMovimentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMovimentacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContaMF,
            this.saldoMV,
            this.debitoMV,
            this.credito,
            this.saldofinalMV,
            this.saldoextratoMV,
            this.diferencaMV,
            this.Conciliacao});
            this.DGMovimentacao.Location = new System.Drawing.Point(12, 12);
            this.DGMovimentacao.Name = "DGMovimentacao";
            this.DGMovimentacao.Size = new System.Drawing.Size(893, 273);
            this.DGMovimentacao.TabIndex = 0;
            // 
            // ContaMF
            // 
            this.ContaMF.HeaderText = "Conta";
            this.ContaMF.Name = "ContaMF";
            this.ContaMF.Width = 150;
            // 
            // saldoMV
            // 
            this.saldoMV.HeaderText = "Saldo Atual R$";
            this.saldoMV.Name = "saldoMV";
            // 
            // debitoMV
            // 
            this.debitoMV.HeaderText = "Débito";
            this.debitoMV.Name = "debitoMV";
            // 
            // credito
            // 
            this.credito.HeaderText = "Crédito";
            this.credito.Name = "credito";
            // 
            // saldofinalMV
            // 
            this.saldofinalMV.HeaderText = "Saldo Final";
            this.saldofinalMV.Name = "saldofinalMV";
            // 
            // saldoextratoMV
            // 
            this.saldoextratoMV.HeaderText = "Saldo Extrato";
            this.saldoextratoMV.Name = "saldoextratoMV";
            // 
            // diferencaMV
            // 
            this.diferencaMV.HeaderText = "Diferença Saldo Final x Extrato";
            this.diferencaMV.Name = "diferencaMV";
            // 
            // Conciliacao
            // 
            this.Conciliacao.HeaderText = "Conciliação";
            this.Conciliacao.Name = "Conciliacao";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(827, 304);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(12, 303);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(329, 24);
            this.txtArquivoExcel.TabIndex = 8;
            this.txtArquivoExcel.Text = "C:\\Users\\Thiago\\Desktop\\Movimentacao Financeira";
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Location = new System.Drawing.Point(349, 304);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(103, 23);
            this.BtnExcel.TabIndex = 9;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "Gerar Relatório";
            this.BtnExcel.UseVisualStyleBackColor = true;
            // 
            // Frm_Movimentacao_financeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 339);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.DGMovimentacao);
            this.Name = "Frm_Movimentacao_financeira";
            this.Text = "Movimentação Financeira";
            ((System.ComponentModel.ISupportInitialize)(this.DGMovimentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGMovimentacao;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContaMF;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitoMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldofinalMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoextratoMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferencaMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conciliacao;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Button BtnExcel;
    }
}