namespace Tracking.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Adiciona_Centro_de_Custo));
            this.btn_adicionarCDC = new System.Windows.Forms.Button();
            this.LbAddForn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.txt_numeroCDC = new System.Windows.Forms.TextBox();
            this.txt_descricaoCDC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.txtNome_CDC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionarCDC
            // 
            this.btn_adicionarCDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionarCDC.Image = ((System.Drawing.Image)(resources.GetObject("btn_adicionarCDC.Image")));
            this.btn_adicionarCDC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adicionarCDC.Location = new System.Drawing.Point(213, 197);
            this.btn_adicionarCDC.Name = "btn_adicionarCDC";
            this.btn_adicionarCDC.Size = new System.Drawing.Size(94, 33);
            this.btn_adicionarCDC.TabIndex = 5;
            this.btn_adicionarCDC.Text = "Adicionar";
            this.btn_adicionarCDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adicionarCDC.UseVisualStyleBackColor = true;
            this.btn_adicionarCDC.Click += new System.EventHandler(this.btn_adicionar_centro_de_custo_Click);
            // 
            // LbAddForn
            // 
            this.LbAddForn.AutoSize = true;
            this.LbAddForn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddForn.Location = new System.Drawing.Point(83, 9);
            this.LbAddForn.Name = "LbAddForn";
            this.LbAddForn.Size = new System.Drawing.Size(262, 24);
            this.LbAddForn.TabIndex = 24;
            this.LbAddForn.Text = "Cadastrar Centro de Custo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSaldo);
            this.groupBox1.Controls.Add(this.LblSaldo);
            this.groupBox1.Controls.Add(this.txt_numeroCDC);
            this.groupBox1.Controls.Add(this.txt_descricaoCDC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LbNome);
            this.groupBox1.Controls.Add(this.txtNome_CDC);
            this.groupBox1.Location = new System.Drawing.Point(21, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 151);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Contato";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.AcceptsTab = true;
            this.TxtSaldo.Location = new System.Drawing.Point(125, 77);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(74, 20);
            this.TxtSaldo.TabIndex = 3;
            this.TxtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldo_KeyPress);
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.Location = new System.Drawing.Point(14, 78);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(82, 16);
            this.LblSaldo.TabIndex = 24;
            this.LblSaldo.Text = "Saldo Inicial:";
            // 
            // txt_numeroCDC
            // 
            this.txt_numeroCDC.AcceptsTab = true;
            this.txt_numeroCDC.Location = new System.Drawing.Point(125, 103);
            this.txt_numeroCDC.Name = "txt_numeroCDC";
            this.txt_numeroCDC.Size = new System.Drawing.Size(74, 20);
            this.txt_numeroCDC.TabIndex = 4;
            // 
            // txt_descricaoCDC
            // 
            this.txt_descricaoCDC.AcceptsTab = true;
            this.txt_descricaoCDC.Location = new System.Drawing.Point(102, 48);
            this.txt_descricaoCDC.Name = "txt_descricaoCDC";
            this.txt_descricaoCDC.Size = new System.Drawing.Size(272, 20);
            this.txt_descricaoCDC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cód. Hiperfarma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descrição:";
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNome.Location = new System.Drawing.Point(14, 23);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(46, 16);
            this.LbNome.TabIndex = 3;
            this.LbNome.Text = "Nome:";
            // 
            // txtNome_CDC
            // 
            this.txtNome_CDC.AcceptsTab = true;
            this.txtNome_CDC.Location = new System.Drawing.Point(102, 22);
            this.txtNome_CDC.Name = "txtNome_CDC";
            this.txtNome_CDC.Size = new System.Drawing.Size(273, 20);
            this.txtNome_CDC.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(313, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sair";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Adiciona_Centro_de_Custo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_adicionarCDC);
            this.Controls.Add(this.LbAddForn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Adiciona_Centro_de_Custo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Centro de Custo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionarCDC;
        private System.Windows.Forms.Label LbAddForn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_numeroCDC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.TextBox txtNome_CDC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_descricaoCDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label LblSaldo;
    }
}