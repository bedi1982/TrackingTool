namespace TrackingTool6.View
{
    partial class Frm_Adiciona_Centro_de_Custo
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
            this.btn_adicionarCDC = new System.Windows.Forms.Button();
            this.LbAddForn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_numeroCDC = new System.Windows.Forms.TextBox();
            this.txt_bairroCDC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_tel_cel_forn = new System.Windows.Forms.Label();
            this.LbTel_res_forn = new System.Windows.Forms.Label();
            this.txt_RuaCDC = new System.Windows.Forms.TextBox();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.txtTel_CDC = new System.Windows.Forms.TextBox();
            this.LbNome = new System.Windows.Forms.Label();
            this.txtCnpj_CDC = new System.Windows.Forms.TextBox();
            this.txtNome_CDC = new System.Windows.Forms.TextBox();
            this.txt_saldo_inicialCDC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionarCDC
            // 
            this.btn_adicionarCDC.Location = new System.Drawing.Point(314, 342);
            this.btn_adicionarCDC.Name = "btn_adicionarCDC";
            this.btn_adicionarCDC.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionarCDC.TabIndex = 8;
            this.btn_adicionarCDC.Text = "Adicionar";
            this.btn_adicionarCDC.UseVisualStyleBackColor = true;
            this.btn_adicionarCDC.Click += new System.EventHandler(this.btn_adicionar_centro_de_custo_Click);
            // 
            // LbAddForn
            // 
            this.LbAddForn.AutoSize = true;
            this.LbAddForn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddForn.Location = new System.Drawing.Point(127, 9);
            this.LbAddForn.Name = "LbAddForn";
            this.LbAddForn.Size = new System.Drawing.Size(262, 24);
            this.LbAddForn.TabIndex = 24;
            this.LbAddForn.Text = "Cadastrar Centro de Custo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_numeroCDC);
            this.groupBox1.Controls.Add(this.txt_bairroCDC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lbl_tel_cel_forn);
            this.groupBox1.Controls.Add(this.LbTel_res_forn);
            this.groupBox1.Controls.Add(this.txt_RuaCDC);
            this.groupBox1.Controls.Add(this.LbCnpj);
            this.groupBox1.Controls.Add(this.txtTel_CDC);
            this.groupBox1.Controls.Add(this.LbNome);
            this.groupBox1.Controls.Add(this.txtCnpj_CDC);
            this.groupBox1.Controls.Add(this.txtNome_CDC);
            this.groupBox1.Location = new System.Drawing.Point(21, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 208);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Contato";
            // 
            // txt_numeroCDC
            // 
            this.txt_numeroCDC.AcceptsTab = true;
            this.txt_numeroCDC.Location = new System.Drawing.Point(90, 164);
            this.txt_numeroCDC.Name = "txt_numeroCDC";
            this.txt_numeroCDC.Size = new System.Drawing.Size(74, 20);
            this.txt_numeroCDC.TabIndex = 6;
            // 
            // txt_bairroCDC
            // 
            this.txt_bairroCDC.AcceptsTab = true;
            this.txt_bairroCDC.Location = new System.Drawing.Point(90, 136);
            this.txt_bairroCDC.Name = "txt_bairroCDC";
            this.txt_bairroCDC.Size = new System.Drawing.Size(250, 20);
            this.txt_bairroCDC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bairro:";
            // 
            // Lbl_tel_cel_forn
            // 
            this.Lbl_tel_cel_forn.AutoSize = true;
            this.Lbl_tel_cel_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel_cel_forn.Location = new System.Drawing.Point(25, 109);
            this.Lbl_tel_cel_forn.Name = "Lbl_tel_cel_forn";
            this.Lbl_tel_cel_forn.Size = new System.Drawing.Size(35, 16);
            this.Lbl_tel_cel_forn.TabIndex = 6;
            this.Lbl_tel_cel_forn.Text = "Rua:";
            // 
            // LbTel_res_forn
            // 
            this.LbTel_res_forn.AutoSize = true;
            this.LbTel_res_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTel_res_forn.Location = new System.Drawing.Point(24, 80);
            this.LbTel_res_forn.Name = "LbTel_res_forn";
            this.LbTel_res_forn.Size = new System.Drawing.Size(60, 16);
            this.LbTel_res_forn.TabIndex = 5;
            this.LbTel_res_forn.Text = "Telefone:";
            // 
            // txt_RuaCDC
            // 
            this.txt_RuaCDC.AcceptsTab = true;
            this.txt_RuaCDC.Location = new System.Drawing.Point(90, 108);
            this.txt_RuaCDC.Name = "txt_RuaCDC";
            this.txt_RuaCDC.Size = new System.Drawing.Size(351, 20);
            this.txt_RuaCDC.TabIndex = 4;
            // 
            // LbCnpj
            // 
            this.LbCnpj.AutoSize = true;
            this.LbCnpj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnpj.Location = new System.Drawing.Point(26, 54);
            this.LbCnpj.Name = "LbCnpj";
            this.LbCnpj.Size = new System.Drawing.Size(45, 16);
            this.LbCnpj.TabIndex = 4;
            this.LbCnpj.Text = "CNPJ:";
            // 
            // txtTel_CDC
            // 
            this.txtTel_CDC.AcceptsTab = true;
            this.txtTel_CDC.Location = new System.Drawing.Point(90, 79);
            this.txtTel_CDC.Name = "txtTel_CDC";
            this.txtTel_CDC.Size = new System.Drawing.Size(152, 20);
            this.txtTel_CDC.TabIndex = 3;
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNome.Location = new System.Drawing.Point(24, 26);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(46, 16);
            this.LbNome.TabIndex = 3;
            this.LbNome.Text = "Nome:";
            // 
            // txtCnpj_CDC
            // 
            this.txtCnpj_CDC.AcceptsTab = true;
            this.txtCnpj_CDC.Location = new System.Drawing.Point(90, 50);
            this.txtCnpj_CDC.Name = "txtCnpj_CDC";
            this.txtCnpj_CDC.Size = new System.Drawing.Size(152, 20);
            this.txtCnpj_CDC.TabIndex = 2;
            // 
            // txtNome_CDC
            // 
            this.txtNome_CDC.AcceptsTab = true;
            this.txtNome_CDC.Location = new System.Drawing.Point(90, 24);
            this.txtNome_CDC.Name = "txtNome_CDC";
            this.txtNome_CDC.Size = new System.Drawing.Size(351, 20);
            this.txtNome_CDC.TabIndex = 1;
            // 
            // txt_saldo_inicialCDC
            // 
            this.txt_saldo_inicialCDC.AcceptsTab = true;
            this.txt_saldo_inicialCDC.Location = new System.Drawing.Point(112, 30);
            this.txt_saldo_inicialCDC.Name = "txt_saldo_inicialCDC";
            this.txt_saldo_inicialCDC.Size = new System.Drawing.Size(74, 20);
            this.txt_saldo_inicialCDC.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Saldo Inicial:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_saldo_inicialCDC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 73);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo Inicial";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Adiciona_Centro_de_Custo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_adicionarCDC);
            this.Controls.Add(this.LbAddForn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Adiciona_Centro_de_Custo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Centro de Custo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionarCDC;
        private System.Windows.Forms.Label LbAddForn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_saldo_inicialCDC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numeroCDC;
        private System.Windows.Forms.TextBox txt_bairroCDC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_tel_cel_forn;
        private System.Windows.Forms.Label LbTel_res_forn;
        private System.Windows.Forms.TextBox txt_RuaCDC;
        private System.Windows.Forms.Label LbCnpj;
        private System.Windows.Forms.TextBox txtTel_CDC;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.TextBox txtCnpj_CDC;
        private System.Windows.Forms.TextBox txtNome_CDC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}