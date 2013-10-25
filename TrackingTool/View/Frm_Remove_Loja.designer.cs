namespace Tracking.View
{
    partial class Frm_Remove_loja
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
            this.txtCod_Loja = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_loja_cel = new System.Windows.Forms.TextBox();
            this.txt_loja_cnpj = new System.Windows.Forms.TextBox();
            this.txt_nome_loja = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_procurar_loja = new System.Windows.Forms.Button();
            this.Lbl_tel_cel_forn = new System.Windows.Forms.Label();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_remover_loja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCod_Loja
            // 
            this.txtCod_Loja.AcceptsTab = true;
            this.txtCod_Loja.Location = new System.Drawing.Point(115, 24);
            this.txtCod_Loja.Name = "txtCod_Loja";
            this.txtCod_Loja.Size = new System.Drawing.Size(51, 20);
            this.txtCod_Loja.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_remover_loja);
            this.groupBox1.Controls.Add(this.txt_loja_cel);
            this.groupBox1.Controls.Add(this.txt_loja_cnpj);
            this.groupBox1.Controls.Add(this.txt_nome_loja);
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.btn_procurar_loja);
            this.groupBox1.Controls.Add(this.Lbl_tel_cel_forn);
            this.groupBox1.Controls.Add(this.LbCnpj);
            this.groupBox1.Controls.Add(this.txtCod_Loja);
            this.groupBox1.Controls.Add(this.Lbl_codigo);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 163);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira ou um Código ou um nome de Loja";
            // 
            // txt_loja_cel
            // 
            this.txt_loja_cel.AcceptsTab = true;
            this.txt_loja_cel.Location = new System.Drawing.Point(115, 106);
            this.txt_loja_cel.Name = "txt_loja_cel";
            this.txt_loja_cel.Size = new System.Drawing.Size(146, 20);
            this.txt_loja_cel.TabIndex = 27;
            // 
            // txt_loja_cnpj
            // 
            this.txt_loja_cnpj.AcceptsTab = true;
            this.txt_loja_cnpj.Location = new System.Drawing.Point(115, 80);
            this.txt_loja_cnpj.Name = "txt_loja_cnpj";
            this.txt_loja_cnpj.Size = new System.Drawing.Size(199, 20);
            this.txt_loja_cnpj.TabIndex = 26;
            // 
            // txt_nome_loja
            // 
            this.txt_nome_loja.AcceptsTab = true;
            this.txt_nome_loja.Location = new System.Drawing.Point(115, 53);
            this.txt_nome_loja.Name = "txt_nome_loja";
            this.txt_nome_loja.Size = new System.Drawing.Size(225, 20);
            this.txt_nome_loja.TabIndex = 25;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(289, 134);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 24;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
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
            // btn_procurar_loja
            // 
            this.btn_procurar_loja.Location = new System.Drawing.Point(265, 21);
            this.btn_procurar_loja.Name = "btn_procurar_loja";
            this.btn_procurar_loja.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar_loja.TabIndex = 2;
            this.btn_procurar_loja.Text = "Procurar";
            this.btn_procurar_loja.UseVisualStyleBackColor = true;
            this.btn_procurar_loja.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // Lbl_tel_cel_forn
            // 
            this.Lbl_tel_cel_forn.AutoSize = true;
            this.Lbl_tel_cel_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel_cel_forn.Location = new System.Drawing.Point(6, 108);
            this.Lbl_tel_cel_forn.Name = "Lbl_tel_cel_forn";
            this.Lbl_tel_cel_forn.Size = new System.Drawing.Size(83, 16);
            this.Lbl_tel_cel_forn.TabIndex = 6;
            this.Lbl_tel_cel_forn.Text = "Telefone Cel:";
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
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(6, 24);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(98, 16);
            this.Lbl_codigo.TabIndex = 3;
            this.Lbl_codigo.Text = "Código da Loja:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(302, 202);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // btn_remover_loja
            // 
            this.btn_remover_loja.Location = new System.Drawing.Point(6, 134);
            this.btn_remover_loja.Name = "btn_remover_loja";
            this.btn_remover_loja.Size = new System.Drawing.Size(75, 23);
            this.btn_remover_loja.TabIndex = 28;
            this.btn_remover_loja.Text = "Remover";
            this.btn_remover_loja.UseVisualStyleBackColor = true;
            this.btn_remover_loja.Click += new System.EventHandler(this.btn_remover_loja_Click);
            // 
            // Frm_Remove_loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 238);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Remove_loja";
            this.Text = "Remover Loja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod_Loja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_tel_cel_forn;
        private System.Windows.Forms.Label LbCnpj;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_procurar_loja;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_loja_cel;
        private System.Windows.Forms.TextBox txt_loja_cnpj;
        private System.Windows.Forms.TextBox txt_nome_loja;
        private System.Windows.Forms.Button btn_remover_loja;
    }
}