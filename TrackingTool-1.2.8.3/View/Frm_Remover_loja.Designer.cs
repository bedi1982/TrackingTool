namespace Tracking.View
{
    partial class Frm_Remover_loja
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
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_procurar_por_nome = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_Nome_loja = new System.Windows.Forms.TextBox();
            this.btn_procurar_por_codigo = new System.Windows.Forms.Button();
            this.Lbl_tel_cel_forn = new System.Windows.Forms.Label();
            this.txt_tel_contato_loja = new System.Windows.Forms.TextBox();
            this.txt_Cnpj_loja = new System.Windows.Forms.TextBox();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.txtCod_Loja = new System.Windows.Forms.TextBox();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Location = new System.Drawing.Point(220, 196);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 24;
            this.btn_remover.Text = "Remover";
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(301, 196);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 25;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_procurar_por_nome);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.txt_Nome_loja);
            this.groupBox1.Controls.Add(this.btn_procurar_por_codigo);
            this.groupBox1.Controls.Add(this.Lbl_tel_cel_forn);
            this.groupBox1.Controls.Add(this.txt_tel_contato_loja);
            this.groupBox1.Controls.Add(this.txt_Cnpj_loja);
            this.groupBox1.Controls.Add(this.LbCnpj);
            this.groupBox1.Controls.Add(this.txtCod_Loja);
            this.groupBox1.Controls.Add(this.Lbl_codigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 163);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira ou um Código ou um nome de Fornecedor";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(289, 134);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 24;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_procurar_por_nome
            // 
            this.btn_procurar_por_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar_por_nome.Location = new System.Drawing.Point(289, 52);
            this.btn_procurar_por_nome.Name = "btn_procurar_por_nome";
            this.btn_procurar_por_nome.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar_por_nome.TabIndex = 10;
            this.btn_procurar_por_nome.Text = "Procurar";
            this.btn_procurar_por_nome.UseVisualStyleBackColor = true;
            this.btn_procurar_por_nome.Click += new System.EventHandler(this.btn_procurar_por_nome_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(6, 54);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(46, 16);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_Nome_loja
            // 
            this.txt_Nome_loja.AcceptsTab = true;
            this.txt_Nome_loja.Location = new System.Drawing.Point(98, 54);
            this.txt_Nome_loja.Name = "txt_Nome_loja";
            this.txt_Nome_loja.Size = new System.Drawing.Size(152, 20);
            this.txt_Nome_loja.TabIndex = 8;
            // 
            // btn_procurar_por_codigo
            // 
            this.btn_procurar_por_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar_por_codigo.Location = new System.Drawing.Point(289, 23);
            this.btn_procurar_por_codigo.Name = "btn_procurar_por_codigo";
            this.btn_procurar_por_codigo.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar_por_codigo.TabIndex = 2;
            this.btn_procurar_por_codigo.Text = "Procurar";
            this.btn_procurar_por_codigo.UseVisualStyleBackColor = true;
            this.btn_procurar_por_codigo.Click += new System.EventHandler(this.btn_procurar_por_codigo_Click);
            // 
            // Lbl_tel_cel_forn
            // 
            this.Lbl_tel_cel_forn.AutoSize = true;
            this.Lbl_tel_cel_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel_cel_forn.Location = new System.Drawing.Point(6, 108);
            this.Lbl_tel_cel_forn.Name = "Lbl_tel_cel_forn";
            this.Lbl_tel_cel_forn.Size = new System.Drawing.Size(81, 16);
            this.Lbl_tel_cel_forn.TabIndex = 6;
            this.Lbl_tel_cel_forn.Text = "Tel. Contato:";
            // 
            // txt_tel_contato_loja
            // 
            this.txt_tel_contato_loja.AcceptsTab = true;
            this.txt_tel_contato_loja.Location = new System.Drawing.Point(98, 108);
            this.txt_tel_contato_loja.Name = "txt_tel_contato_loja";
            this.txt_tel_contato_loja.Size = new System.Drawing.Size(152, 20);
            this.txt_tel_contato_loja.TabIndex = 5;
            // 
            // txt_Cnpj_loja
            // 
            this.txt_Cnpj_loja.AcceptsTab = true;
            this.txt_Cnpj_loja.Location = new System.Drawing.Point(97, 80);
            this.txt_Cnpj_loja.Name = "txt_Cnpj_loja";
            this.txt_Cnpj_loja.Size = new System.Drawing.Size(152, 20);
            this.txt_Cnpj_loja.TabIndex = 4;
            // 
            // LbCnpj
            // 
            this.LbCnpj.AutoSize = true;
            this.LbCnpj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnpj.Location = new System.Drawing.Point(6, 80);
            this.LbCnpj.Name = "LbCnpj";
            this.LbCnpj.Size = new System.Drawing.Size(45, 16);
            this.LbCnpj.TabIndex = 4;
            this.LbCnpj.Text = "CNPJ:";
            // 
            // txtCod_Loja
            // 
            this.txtCod_Loja.AcceptsTab = true;
            this.txtCod_Loja.Location = new System.Drawing.Point(98, 24);
            this.txtCod_Loja.Name = "txtCod_Loja";
            this.txtCod_Loja.Size = new System.Drawing.Size(51, 20);
            this.txtCod_Loja.TabIndex = 1;
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(6, 24);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(52, 16);
            this.Lbl_codigo.TabIndex = 3;
            this.Lbl_codigo.Text = "Código:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Frm_Remover_loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 233);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_Remover_loja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover Loja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_procurar_por_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_Nome_loja;
        private System.Windows.Forms.Button btn_procurar_por_codigo;
        private System.Windows.Forms.Label Lbl_tel_cel_forn;
        private System.Windows.Forms.TextBox txt_tel_contato_loja;
        private System.Windows.Forms.TextBox txt_Cnpj_loja;
        private System.Windows.Forms.Label LbCnpj;
        private System.Windows.Forms.TextBox txtCod_Loja;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}