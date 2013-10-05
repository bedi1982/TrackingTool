namespace TrackingTool6.View
{
    partial class Frm_Remove_CDC
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
            this.txt_saldoAtual_cdc = new System.Windows.Forms.TextBox();
            this.txt_descricao_cdc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_procurar_cdc_por_nome = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_Nome_cdc = new System.Windows.Forms.TextBox();
            this.Lbl_tel_cel_forn = new System.Windows.Forms.Label();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_remover_cdc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero_cdc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_saldoAtual_cdc
            // 
            this.txt_saldoAtual_cdc.AcceptsTab = true;
            this.txt_saldoAtual_cdc.Location = new System.Drawing.Point(95, 108);
            this.txt_saldoAtual_cdc.Name = "txt_saldoAtual_cdc";
            this.txt_saldoAtual_cdc.Size = new System.Drawing.Size(72, 20);
            this.txt_saldoAtual_cdc.TabIndex = 5;
            // 
            // txt_descricao_cdc
            // 
            this.txt_descricao_cdc.AcceptsTab = true;
            this.txt_descricao_cdc.Location = new System.Drawing.Point(95, 80);
            this.txt_descricao_cdc.Name = "txt_descricao_cdc";
            this.txt_descricao_cdc.Size = new System.Drawing.Size(196, 20);
            this.txt_descricao_cdc.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_numero_cdc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_procurar_cdc_por_nome);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.txt_Nome_cdc);
            this.groupBox1.Controls.Add(this.Lbl_tel_cel_forn);
            this.groupBox1.Controls.Add(this.txt_saldoAtual_cdc);
            this.groupBox1.Controls.Add(this.txt_descricao_cdc);
            this.groupBox1.Controls.Add(this.LbCnpj);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 163);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira o nome de Centro de Custo a Remover";
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
            // btn_procurar_cdc_por_nome
            // 
            this.btn_procurar_cdc_por_nome.Location = new System.Drawing.Point(295, 25);
            this.btn_procurar_cdc_por_nome.Name = "btn_procurar_cdc_por_nome";
            this.btn_procurar_cdc_por_nome.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar_cdc_por_nome.TabIndex = 10;
            this.btn_procurar_cdc_por_nome.Text = "Procurar";
            this.btn_procurar_cdc_por_nome.UseVisualStyleBackColor = true;
            this.btn_procurar_cdc_por_nome.Click += new System.EventHandler(this.btn_procurar_por_nome_Click_1);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(6, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(46, 16);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_Nome_cdc
            // 
            this.txt_Nome_cdc.AcceptsTab = true;
            this.txt_Nome_cdc.Location = new System.Drawing.Point(69, 27);
            this.txt_Nome_cdc.Name = "txt_Nome_cdc";
            this.txt_Nome_cdc.Size = new System.Drawing.Size(214, 20);
            this.txt_Nome_cdc.TabIndex = 8;
            // 
            // Lbl_tel_cel_forn
            // 
            this.Lbl_tel_cel_forn.AutoSize = true;
            this.Lbl_tel_cel_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel_cel_forn.Location = new System.Drawing.Point(6, 108);
            this.Lbl_tel_cel_forn.Name = "Lbl_tel_cel_forn";
            this.Lbl_tel_cel_forn.Size = new System.Drawing.Size(79, 16);
            this.Lbl_tel_cel_forn.TabIndex = 6;
            this.Lbl_tel_cel_forn.Text = "Saldo Atual:";
            // 
            // LbCnpj
            // 
            this.LbCnpj.AutoSize = true;
            this.LbCnpj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnpj.Location = new System.Drawing.Point(6, 80);
            this.LbCnpj.Name = "LbCnpj";
            this.LbCnpj.Size = new System.Drawing.Size(70, 16);
            this.LbCnpj.TabIndex = 4;
            this.LbCnpj.Text = "Descrição:";
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
            // btn_remover_cdc
            // 
            this.btn_remover_cdc.Location = new System.Drawing.Point(221, 202);
            this.btn_remover_cdc.Name = "btn_remover_cdc";
            this.btn_remover_cdc.Size = new System.Drawing.Size(75, 23);
            this.btn_remover_cdc.TabIndex = 0;
            this.btn_remover_cdc.Text = "Remover";
            this.btn_remover_cdc.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Número:";
            // 
            // txt_numero_cdc
            // 
            this.txt_numero_cdc.AcceptsTab = true;
            this.txt_numero_cdc.Location = new System.Drawing.Point(69, 54);
            this.txt_numero_cdc.Name = "txt_numero_cdc";
            this.txt_numero_cdc.Size = new System.Drawing.Size(76, 20);
            this.txt_numero_cdc.TabIndex = 26;
            // 
            // Frm_Remove_loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 238);
            this.Controls.Add(this.btn_remover_cdc);
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

        private System.Windows.Forms.TextBox txt_saldoAtual_cdc;
        private System.Windows.Forms.TextBox txt_descricao_cdc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_tel_cel_forn;
        private System.Windows.Forms.Label LbCnpj;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_Nome_cdc;
        private System.Windows.Forms.Button btn_procurar_cdc_por_nome;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_remover_cdc;
        private System.Windows.Forms.TextBox txt_numero_cdc;
        private System.Windows.Forms.Label label1;
    }
}