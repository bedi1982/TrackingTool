namespace Tracking.View
{
    partial class Frm_ListarFornContas
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
            this.DGFornecedores = new System.Windows.Forms.DataGridView();
            this.CodigoForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // DGFornecedores
            // 
            this.DGFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoForn,
            this.NomeForn});
            this.DGFornecedores.Location = new System.Drawing.Point(12, 12);
            this.DGFornecedores.Name = "DGFornecedores";
            this.DGFornecedores.Size = new System.Drawing.Size(266, 419);
            this.DGFornecedores.TabIndex = 0;
            // 
            // CodigoForn
            // 
            this.CodigoForn.HeaderText = "Código";
            this.CodigoForn.Name = "CodigoForn";
            // 
            // NomeForn
            // 
            this.NomeForn.HeaderText = "Nome";
            this.NomeForn.Name = "NomeForn";
            this.NomeForn.Width = 120;
            // 
            // Frm_ListarFornContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 443);
            this.Controls.Add(this.DGFornecedores);
            this.Name = "Frm_ListarFornContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.DGFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGFornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeForn;
    }
}