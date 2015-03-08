namespace Tracking.View
{
    partial class Frn_Remove_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frn_Remove_Fornecedor));
            this.txt_tel_contato_forn = new System.Windows.Forms.TextBox();
            this.txt_Cnpj_forn = new System.Windows.Forms.TextBox();
            this.txtCod_Forn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_procurar_por_nome = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_Nome_forn = new System.Windows.Forms.TextBox();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.Lbl_tel_cel_forn = new System.Windows.Forms.Label();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_remover = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tel_contato_forn
            // 
            this.txt_tel_contato_forn.AcceptsTab = true;
            this.txt_tel_contato_forn.Location = new System.Drawing.Point(98, 134);
            this.txt_tel_contato_forn.Name = "txt_tel_contato_forn";
            this.txt_tel_contato_forn.Size = new System.Drawing.Size(152, 20);
            this.txt_tel_contato_forn.TabIndex = 5;
            // 
            // txt_Cnpj_forn
            // 
            this.txt_Cnpj_forn.AcceptsTab = true;
            this.txt_Cnpj_forn.Location = new System.Drawing.Point(97, 96);
            this.txt_Cnpj_forn.Name = "txt_Cnpj_forn";
            this.txt_Cnpj_forn.Size = new System.Drawing.Size(152, 20);
            this.txt_Cnpj_forn.TabIndex = 4;
            // 
            // txtCod_Forn
            // 
            this.txtCod_Forn.AcceptsTab = true;
            this.txtCod_Forn.Location = new System.Drawing.Point(98, 24);
            this.txtCod_Forn.Name = "txtCod_Forn";
            this.txtCod_Forn.Size = new System.Drawing.Size(51, 20);
            this.txtCod_Forn.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_procurar_por_nome);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.txt_Nome_forn);
            this.groupBox1.Controls.Add(this.btn_procurar);
            this.groupBox1.Controls.Add(this.Lbl_tel_cel_forn);
            this.groupBox1.Controls.Add(this.txt_tel_contato_forn);
            this.groupBox1.Controls.Add(this.txt_Cnpj_forn);
            this.groupBox1.Controls.Add(this.LbCnpj);
            this.groupBox1.Controls.Add(this.txtCod_Forn);
            this.groupBox1.Controls.Add(this.Lbl_codigo);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 185);
            this.groupBox1.TabIndex = 22;
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
            this.btn_procurar_por_nome.Image = ((System.Drawing.Image)(resources.GetObject("btn_procurar_por_nome.Image")));
            this.btn_procurar_por_nome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_procurar_por_nome.Location = new System.Drawing.Point(270, 54);
            this.btn_procurar_por_nome.Name = "btn_procurar_por_nome";
            this.btn_procurar_por_nome.Size = new System.Drawing.Size(94, 33);
            this.btn_procurar_por_nome.TabIndex = 10;
            this.btn_procurar_por_nome.Text = "Procurar";
            this.btn_procurar_por_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procurar_por_nome.UseVisualStyleBackColor = true;
            this.btn_procurar_por_nome.Click += new System.EventHandler(this.btn_procurar_por_nome_Click_1);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(6, 61);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(46, 16);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_Nome_forn
            // 
            this.txt_Nome_forn.AcceptsTab = true;
            this.txt_Nome_forn.Location = new System.Drawing.Point(98, 61);
            this.txt_Nome_forn.Name = "txt_Nome_forn";
            this.txt_Nome_forn.Size = new System.Drawing.Size(152, 20);
            this.txt_Nome_forn.TabIndex = 8;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_procurar.Image")));
            this.btn_procurar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_procurar.Location = new System.Drawing.Point(270, 16);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(94, 33);
            this.btn_procurar.TabIndex = 2;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // Lbl_tel_cel_forn
            // 
            this.Lbl_tel_cel_forn.AutoSize = true;
            this.Lbl_tel_cel_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel_cel_forn.Location = new System.Drawing.Point(6, 134);
            this.Lbl_tel_cel_forn.Name = "Lbl_tel_cel_forn";
            this.Lbl_tel_cel_forn.Size = new System.Drawing.Size(81, 16);
            this.Lbl_tel_cel_forn.TabIndex = 6;
            this.Lbl_tel_cel_forn.Text = "Tel. Contato:";
            // 
            // LbCnpj
            // 
            this.LbCnpj.AutoSize = true;
            this.LbCnpj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnpj.Location = new System.Drawing.Point(6, 96);
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
            this.Lbl_codigo.Size = new System.Drawing.Size(52, 16);
            this.Lbl_codigo.TabIndex = 3;
            this.Lbl_codigo.Text = "Código:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sair.Location = new System.Drawing.Point(289, 224);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(94, 33);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_remover
            // 
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.Image = ((System.Drawing.Image)(resources.GetObject("btn_remover.Image")));
            this.btn_remover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remover.Location = new System.Drawing.Point(168, 224);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(94, 33);
            this.btn_remover.TabIndex = 0;
            this.btn_remover.Text = "Remover";
            this.btn_remover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // Frn_Remove_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 269);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frn_Remove_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover Fornecedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tel_contato_forn;
        private System.Windows.Forms.TextBox txt_Cnpj_forn;
        private System.Windows.Forms.TextBox txtCod_Forn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_tel_cel_forn;
        private System.Windows.Forms.Label LbCnpj;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_Nome_forn;
        private System.Windows.Forms.Button btn_procurar_por_nome;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_remover;
    }
}