namespace Tracking.View
{
    partial class Frm_listar_CDC
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
            this.button1 = new System.Windows.Forms.Button();
            this.grid_listar_cdcs = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.BtnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listar_cdcs)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_listar_cdcs
            // 
            this.grid_listar_cdcs.AllowUserToAddRows = false;
            this.grid_listar_cdcs.AllowUserToDeleteRows = false;
            this.grid_listar_cdcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_listar_cdcs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.descricao,
            this.saldo});
            this.grid_listar_cdcs.Location = new System.Drawing.Point(0, 0);
            this.grid_listar_cdcs.Name = "grid_listar_cdcs";
            this.grid_listar_cdcs.ReadOnly = true;
            this.grid_listar_cdcs.Size = new System.Drawing.Size(504, 305);
            this.grid_listar_cdcs.TabIndex = 2;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 150;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 200;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Width = 60;
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(11, 369);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(329, 24);
            this.txtArquivoExcel.TabIndex = 7;
            this.txtArquivoExcel.Text = "C:\\Users\\Thiago\\Desktop\\Centros de Custo";
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Location = new System.Drawing.Point(345, 369);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(103, 23);
            this.BtnExcel.TabIndex = 8;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "Gerar Relatório";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // Frm_listar_CDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 405);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.grid_listar_cdcs);
            this.Controls.Add(this.button1);
            this.Name = "Frm_listar_CDC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Centros de Custo";
            this.Load += new System.EventHandler(this.Frm_listar_CDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_listar_cdcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid_listar_cdcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Button BtnExcel;
    }
}