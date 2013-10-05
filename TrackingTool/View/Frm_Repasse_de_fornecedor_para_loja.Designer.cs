namespace TrackingTool6.View
{
    partial class Frm_Repasse_de_fornecedor_para_loja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_procurar_por_nome = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_Nome_forn = new System.Windows.Forms.TextBox();
            this.txtCod_Forn = new System.Windows.Forms.TextBox();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Lbl_tel_cel_forn = new System.Windows.Forms.Label();
            this.txt_Celular_forn = new System.Windows.Forms.TextBox();
            this.txt_Cnpj_forn = new System.Windows.Forms.TextBox();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_tel_cel_forn);
            this.groupBox1.Controls.Add(this.txt_Celular_forn);
            this.groupBox1.Controls.Add(this.txt_Cnpj_forn);
            this.groupBox1.Controls.Add(this.LbCnpj);
            this.groupBox1.Controls.Add(this.txtCod_Forn);
            this.groupBox1.Controls.Add(this.Lbl_codigo);
            this.groupBox1.Controls.Add(this.btn_procurar_por_nome);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.txt_Nome_forn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedor de Origem";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loja de Destino";
            // 
            // btn_procurar_por_nome
            // 
            this.btn_procurar_por_nome.Location = new System.Drawing.Point(314, 27);
            this.btn_procurar_por_nome.Name = "btn_procurar_por_nome";
            this.btn_procurar_por_nome.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar_por_nome.TabIndex = 13;
            this.btn_procurar_por_nome.Text = "Procurar";
            this.btn_procurar_por_nome.UseVisualStyleBackColor = true;
            this.btn_procurar_por_nome.Click += new System.EventHandler(this.btn_procurar_por_nome_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(20, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(46, 16);
            this.lbl_nome.TabIndex = 12;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_Nome_forn
            // 
            this.txt_Nome_forn.AcceptsTab = true;
            this.txt_Nome_forn.Location = new System.Drawing.Point(82, 29);
            this.txt_Nome_forn.Name = "txt_Nome_forn";
            this.txt_Nome_forn.Size = new System.Drawing.Size(226, 20);
            this.txt_Nome_forn.TabIndex = 11;
            // 
            // txtCod_Forn
            // 
            this.txtCod_Forn.AcceptsTab = true;
            this.txtCod_Forn.Location = new System.Drawing.Point(112, 55);
            this.txtCod_Forn.Name = "txtCod_Forn";
            this.txtCod_Forn.Size = new System.Drawing.Size(51, 20);
            this.txtCod_Forn.TabIndex = 14;
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(20, 55);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(52, 16);
            this.Lbl_codigo.TabIndex = 15;
            this.Lbl_codigo.Text = "Código:";
            // 
            // Lbl_tel_cel_forn
            // 
            this.Lbl_tel_cel_forn.AutoSize = true;
            this.Lbl_tel_cel_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel_cel_forn.Location = new System.Drawing.Point(20, 112);
            this.Lbl_tel_cel_forn.Name = "Lbl_tel_cel_forn";
            this.Lbl_tel_cel_forn.Size = new System.Drawing.Size(83, 16);
            this.Lbl_tel_cel_forn.TabIndex = 19;
            this.Lbl_tel_cel_forn.Text = "Telefone Cel:";
            // 
            // txt_Celular_forn
            // 
            this.txt_Celular_forn.AcceptsTab = true;
            this.txt_Celular_forn.Location = new System.Drawing.Point(112, 112);
            this.txt_Celular_forn.Name = "txt_Celular_forn";
            this.txt_Celular_forn.Size = new System.Drawing.Size(152, 20);
            this.txt_Celular_forn.TabIndex = 18;
            // 
            // txt_Cnpj_forn
            // 
            this.txt_Cnpj_forn.AcceptsTab = true;
            this.txt_Cnpj_forn.Location = new System.Drawing.Point(111, 84);
            this.txt_Cnpj_forn.Name = "txt_Cnpj_forn";
            this.txt_Cnpj_forn.Size = new System.Drawing.Size(152, 20);
            this.txt_Cnpj_forn.TabIndex = 16;
            // 
            // LbCnpj
            // 
            this.LbCnpj.AutoSize = true;
            this.LbCnpj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnpj.Location = new System.Drawing.Point(20, 84);
            this.LbCnpj.Name = "LbCnpj";
            this.LbCnpj.Size = new System.Drawing.Size(45, 16);
            this.LbCnpj.TabIndex = 17;
            this.LbCnpj.Text = "CNPJ:";
            // 
            // Frm_Repasse_de_fornecedor_para_loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Repasse_de_fornecedor_para_loja";
            this.Text = "Repasse de Fornecedor para Loja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_procurar_por_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_Nome_forn;
        private System.Windows.Forms.TextBox txtCod_Forn;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.Label Lbl_tel_cel_forn;
        private System.Windows.Forms.TextBox txt_Celular_forn;
        private System.Windows.Forms.TextBox txt_Cnpj_forn;
        private System.Windows.Forms.Label LbCnpj;
    }
}