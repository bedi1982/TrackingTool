namespace Tracking.View
{
    partial class Frm_Listar_Lojas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Listar_Lojas));
            this.grid_listar_lojas = new System.Windows.Forms.DataGridView();
            this.IdLoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailLoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroLoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplementoLoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnOK = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.BtnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listar_lojas)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_listar_lojas
            // 
            this.grid_listar_lojas.AllowUserToAddRows = false;
            this.grid_listar_lojas.AllowUserToDeleteRows = false;
            this.grid_listar_lojas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_listar_lojas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLoja,
            this.codigo,
            this.nome,
            this.cnpj,
            this.tel,
            this.EmailLoja,
            this.rua,
            this.bairro,
            this.NumeroLoja,
            this.ComplementoLoja});
            this.grid_listar_lojas.Location = new System.Drawing.Point(0, 0);
            this.grid_listar_lojas.Name = "grid_listar_lojas";
            this.grid_listar_lojas.ReadOnly = true;
            this.grid_listar_lojas.Size = new System.Drawing.Size(1184, 630);
            this.grid_listar_lojas.TabIndex = 0;
            // 
            // IdLoja
            // 
            this.IdLoja.HeaderText = "ID";
            this.IdLoja.Name = "IdLoja";
            this.IdLoja.ReadOnly = true;
            this.IdLoja.Width = 50;
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
            this.nome.Width = 160;
            // 
            // cnpj
            // 
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            this.cnpj.ReadOnly = true;
            this.cnpj.Width = 150;
            // 
            // tel
            // 
            this.tel.HeaderText = "Tel.";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // EmailLoja
            // 
            this.EmailLoja.HeaderText = "Email";
            this.EmailLoja.Name = "EmailLoja";
            this.EmailLoja.ReadOnly = true;
            // 
            // rua
            // 
            this.rua.HeaderText = "Rua";
            this.rua.Name = "rua";
            this.rua.ReadOnly = true;
            this.rua.Width = 180;
            // 
            // bairro
            // 
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 150;
            // 
            // NumeroLoja
            // 
            this.NumeroLoja.HeaderText = "Número";
            this.NumeroLoja.Name = "NumeroLoja";
            this.NumeroLoja.ReadOnly = true;
            this.NumeroLoja.Width = 80;
            // 
            // ComplementoLoja
            // 
            this.ComplementoLoja.HeaderText = "Complemento";
            this.ComplementoLoja.Name = "ComplementoLoja";
            this.ComplementoLoja.ReadOnly = true;
            this.ComplementoLoja.Width = 120;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Image = ((System.Drawing.Image)(resources.GetObject("BtnOK.Image")));
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOK.Location = new System.Drawing.Point(1097, 645);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(54, 33);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(11, 644);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(329, 24);
            this.txtArquivoExcel.TabIndex = 6;
            this.txtArquivoExcel.Text = "C:\\Users\\Thiago\\Desktop\\Lojas";
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcel.Image")));
            this.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcel.Location = new System.Drawing.Point(345, 636);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(126, 32);
            this.BtnExcel.TabIndex = 7;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "Gerar Relatório";
            this.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // Frm_Listar_Lojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 679);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.grid_listar_lojas);
            this.Name = "Frm_Listar_Lojas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Lojas";
            this.Load += new System.EventHandler(this.Frm_Listar_Lojas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_listar_lojas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_listar_lojas;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLoja;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailLoja;
        private System.Windows.Forms.DataGridViewTextBoxColumn rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLoja;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplementoLoja;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Button BtnExcel;
    }
}