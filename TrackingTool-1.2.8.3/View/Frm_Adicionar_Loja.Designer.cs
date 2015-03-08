namespace Tracking.View
{
    partial class Frm_Adicionar_Loja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Adicionar_Loja));
            this.LbAddForn = new System.Windows.Forms.Label();
            this.txtNome_loja = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTel_loja = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj_loja = new System.Windows.Forms.MaskedTextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.txt_numero_loja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTel_res_forn = new System.Windows.Forms.Label();
            this.LbCnpj = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.btn_adicionar_loja = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GBEndereco = new System.Windows.Forms.GroupBox();
            this.TxtUF = new System.Windows.Forms.TextBox();
            this.LbUF = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.LbCidade = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.txtNumero_endereco_loja = new System.Windows.Forms.TextBox();
            this.LblNum = new System.Windows.Forms.Label();
            this.txt_bairro_loja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_tel_cel_forn = new System.Windows.Forms.Label();
            this.txt_Rua_Loja = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.GBEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbAddForn
            // 
            this.LbAddForn.AutoSize = true;
            this.LbAddForn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddForn.Location = new System.Drawing.Point(170, 9);
            this.LbAddForn.Name = "LbAddForn";
            this.LbAddForn.Size = new System.Drawing.Size(149, 24);
            this.LbAddForn.TabIndex = 21;
            this.LbAddForn.Text = "Cadastrar Loja";
            // 
            // txtNome_loja
            // 
            this.txtNome_loja.AcceptsTab = true;
            this.txtNome_loja.Location = new System.Drawing.Point(163, 25);
            this.txtNome_loja.Name = "txtNome_loja";
            this.txtNome_loja.Size = new System.Drawing.Size(343, 20);
            this.txtNome_loja.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTel_loja);
            this.groupBox1.Controls.Add(this.txtCnpj_loja);
            this.groupBox1.Controls.Add(this.LbEmail);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.txt_numero_loja);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LbTel_res_forn);
            this.groupBox1.Controls.Add(this.LbCnpj);
            this.groupBox1.Controls.Add(this.LbNome);
            this.groupBox1.Controls.Add(this.txtNome_loja);
            this.groupBox1.Location = new System.Drawing.Point(18, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 167);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Loja";
            // 
            // txtTel_loja
            // 
            this.txtTel_loja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTel_loja.Location = new System.Drawing.Point(163, 101);
            this.txtTel_loja.Mask = "(99)9999-99999";
            this.txtTel_loja.Name = "txtTel_loja";
            this.txtTel_loja.Size = new System.Drawing.Size(91, 22);
            this.txtTel_loja.TabIndex = 4;
            // 
            // txtCnpj_loja
            // 
            this.txtCnpj_loja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj_loja.Location = new System.Drawing.Point(162, 75);
            this.txtCnpj_loja.Mask = "99.999.999/9999-99";
            this.txtCnpj_loja.Name = "txtCnpj_loja";
            this.txtCnpj_loja.Size = new System.Drawing.Size(124, 22);
            this.txtCnpj_loja.TabIndex = 3;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(35, 133);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(121, 16);
            this.LbEmail.TabIndex = 24;
            this.LbEmail.Text = "Email para contato:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.AcceptsTab = true;
            this.TxtEmail.Location = new System.Drawing.Point(162, 129);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(343, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // txt_numero_loja
            // 
            this.txt_numero_loja.AcceptsTab = true;
            this.txt_numero_loja.Location = new System.Drawing.Point(163, 51);
            this.txt_numero_loja.Name = "txt_numero_loja";
            this.txt_numero_loja.Size = new System.Drawing.Size(81, 20);
            this.txt_numero_loja.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cód. Hiperfarma:";
            // 
            // LbTel_res_forn
            // 
            this.LbTel_res_forn.AutoSize = true;
            this.LbTel_res_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTel_res_forn.Location = new System.Drawing.Point(22, 104);
            this.LbTel_res_forn.Name = "LbTel_res_forn";
            this.LbTel_res_forn.Size = new System.Drawing.Size(137, 16);
            this.LbTel_res_forn.TabIndex = 5;
            this.LbTel_res_forn.Text = "Telefone para Contato:";
            // 
            // LbCnpj
            // 
            this.LbCnpj.AutoSize = true;
            this.LbCnpj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCnpj.Location = new System.Drawing.Point(111, 81);
            this.LbCnpj.Name = "LbCnpj";
            this.LbCnpj.Size = new System.Drawing.Size(45, 16);
            this.LbCnpj.TabIndex = 4;
            this.LbCnpj.Text = "CNPJ:";
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNome.Location = new System.Drawing.Point(111, 29);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(46, 16);
            this.LbNome.TabIndex = 3;
            this.LbNome.Text = "Nome:";
            // 
            // btn_adicionar_loja
            // 
            this.btn_adicionar_loja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar_loja.Image = ((System.Drawing.Image)(resources.GetObject("btn_adicionar_loja.Image")));
            this.btn_adicionar_loja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adicionar_loja.Location = new System.Drawing.Point(335, 410);
            this.btn_adicionar_loja.Name = "btn_adicionar_loja";
            this.btn_adicionar_loja.Size = new System.Drawing.Size(94, 33);
            this.btn_adicionar_loja.TabIndex = 12;
            this.btn_adicionar_loja.Text = "Adicionar";
            this.btn_adicionar_loja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adicionar_loja.UseVisualStyleBackColor = true;
            this.btn_adicionar_loja.Click += new System.EventHandler(this.btn_adicionar_loja_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(445, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sair";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GBEndereco
            // 
            this.GBEndereco.Controls.Add(this.TxtUF);
            this.GBEndereco.Controls.Add(this.LbUF);
            this.GBEndereco.Controls.Add(this.TxtCidade);
            this.GBEndereco.Controls.Add(this.LbCidade);
            this.GBEndereco.Controls.Add(this.txtcomplemento);
            this.GBEndereco.Controls.Add(this.lbComplemento);
            this.GBEndereco.Controls.Add(this.txtNumero_endereco_loja);
            this.GBEndereco.Controls.Add(this.LblNum);
            this.GBEndereco.Controls.Add(this.txt_bairro_loja);
            this.GBEndereco.Controls.Add(this.label1);
            this.GBEndereco.Controls.Add(this.Lbl_tel_cel_forn);
            this.GBEndereco.Controls.Add(this.txt_Rua_Loja);
            this.GBEndereco.Location = new System.Drawing.Point(18, 209);
            this.GBEndereco.Name = "GBEndereco";
            this.GBEndereco.Size = new System.Drawing.Size(521, 195);
            this.GBEndereco.TabIndex = 23;
            this.GBEndereco.TabStop = false;
            this.GBEndereco.Text = "Endereço";
            // 
            // TxtUF
            // 
            this.TxtUF.AcceptsTab = true;
            this.TxtUF.Location = new System.Drawing.Point(161, 113);
            this.TxtUF.Name = "TxtUF";
            this.TxtUF.Size = new System.Drawing.Size(41, 20);
            this.TxtUF.TabIndex = 9;
            // 
            // LbUF
            // 
            this.LbUF.AutoSize = true;
            this.LbUF.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUF.Location = new System.Drawing.Point(122, 117);
            this.LbUF.Name = "LbUF";
            this.LbUF.Size = new System.Drawing.Size(29, 16);
            this.LbUF.TabIndex = 36;
            this.LbUF.Text = "UF:";
            // 
            // TxtCidade
            // 
            this.TxtCidade.AcceptsTab = true;
            this.TxtCidade.Location = new System.Drawing.Point(161, 87);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(250, 20);
            this.TxtCidade.TabIndex = 8;
            // 
            // LbCidade
            // 
            this.LbCidade.AutoSize = true;
            this.LbCidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCidade.Location = new System.Drawing.Point(103, 91);
            this.LbCidade.Name = "LbCidade";
            this.LbCidade.Size = new System.Drawing.Size(52, 16);
            this.LbCidade.TabIndex = 34;
            this.LbCidade.Text = "Cidade:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(162, 166);
            this.txtcomplemento.Multiline = true;
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(341, 23);
            this.txtcomplemento.TabIndex = 11;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplemento.Location = new System.Drawing.Point(64, 173);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(92, 16);
            this.lbComplemento.TabIndex = 32;
            this.lbComplemento.Text = "Complemento:";
            // 
            // txtNumero_endereco_loja
            // 
            this.txtNumero_endereco_loja.AcceptsTab = true;
            this.txtNumero_endereco_loja.Location = new System.Drawing.Point(162, 55);
            this.txtNumero_endereco_loja.Name = "txtNumero_endereco_loja";
            this.txtNumero_endereco_loja.Size = new System.Drawing.Size(73, 20);
            this.txtNumero_endereco_loja.TabIndex = 7;
            this.txtNumero_endereco_loja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_endereco_loja_KeyPress);
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum.Location = new System.Drawing.Point(100, 59);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(57, 16);
            this.LblNum.TabIndex = 30;
            this.LblNum.Text = "Número:";
            // 
            // txt_bairro_loja
            // 
            this.txt_bairro_loja.AcceptsTab = true;
            this.txt_bairro_loja.Location = new System.Drawing.Point(162, 140);
            this.txt_bairro_loja.Name = "txt_bairro_loja";
            this.txt_bairro_loja.Size = new System.Drawing.Size(250, 20);
            this.txt_bairro_loja.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bairro:";
            // 
            // Lbl_tel_cel_forn
            // 
            this.Lbl_tel_cel_forn.AutoSize = true;
            this.Lbl_tel_cel_forn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel_cel_forn.Location = new System.Drawing.Point(122, 33);
            this.Lbl_tel_cel_forn.Name = "Lbl_tel_cel_forn";
            this.Lbl_tel_cel_forn.Size = new System.Drawing.Size(35, 16);
            this.Lbl_tel_cel_forn.TabIndex = 26;
            this.Lbl_tel_cel_forn.Text = "Rua:";
            // 
            // txt_Rua_Loja
            // 
            this.txt_Rua_Loja.AcceptsTab = true;
            this.txt_Rua_Loja.Location = new System.Drawing.Point(163, 29);
            this.txt_Rua_Loja.Name = "txt_Rua_Loja";
            this.txt_Rua_Loja.Size = new System.Drawing.Size(295, 20);
            this.txt_Rua_Loja.TabIndex = 6;
            // 
            // Frm_Adicionar_Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 452);
            this.Controls.Add(this.GBEndereco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_adicionar_loja);
            this.Controls.Add(this.LbAddForn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Adicionar_Loja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Loja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBEndereco.ResumeLayout(false);
            this.GBEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAddForn;
        private System.Windows.Forms.TextBox txtNome_loja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbTel_res_forn;
        private System.Windows.Forms.Label LbCnpj;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.Button btn_adicionar_loja;
        private System.Windows.Forms.TextBox txt_numero_loja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GBEndereco;
        private System.Windows.Forms.TextBox txtNumero_endereco_loja;
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.TextBox txt_bairro_loja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_tel_cel_forn;
        private System.Windows.Forms.TextBox txt_Rua_Loja;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.MaskedTextBox txtCnpj_loja;
        private System.Windows.Forms.MaskedTextBox txtTel_loja;
        private System.Windows.Forms.TextBox TxtUF;
        private System.Windows.Forms.Label LbUF;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label LbCidade;
    }
}