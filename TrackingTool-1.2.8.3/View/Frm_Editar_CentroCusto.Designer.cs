namespace Tracking.View
{
    partial class Frm_Editar_CentroCusto
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
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.BtnSalvarCDC = new System.Windows.Forms.Button();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.txt_numeroCDC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descricaoCDC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.txtNome_CDC = new System.Windows.Forms.TextBox();
            this.LbEditarCentroCusto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LbNomeCentroProcura = new System.Windows.Forms.Label();
            this.TxtProcuraCentro = new System.Windows.Forms.TextBox();
            this.BtnProcuraFornecedor = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.AcceptsTab = true;
            this.TxtSaldo.Location = new System.Drawing.Point(125, 77);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(74, 20);
            this.TxtSaldo.TabIndex = 5;
            this.TxtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldo_KeyPress);
            // 
            // BtnSalvarCDC
            // 
            this.BtnSalvarCDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarCDC.Location = new System.Drawing.Point(259, 252);
            this.BtnSalvarCDC.Name = "BtnSalvarCDC";
            this.BtnSalvarCDC.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvarCDC.TabIndex = 7;
            this.BtnSalvarCDC.Text = "Salvar";
            this.BtnSalvarCDC.UseVisualStyleBackColor = true;
            this.BtnSalvarCDC.Click += new System.EventHandler(this.BtnSalvarCDC_Click);
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSaldo.Location = new System.Drawing.Point(14, 78);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(78, 16);
            this.LblSaldo.TabIndex = 24;
            this.LblSaldo.Text = "Saldo Atual:";
            // 
            // txt_numeroCDC
            // 
            this.txt_numeroCDC.AcceptsTab = true;
            this.txt_numeroCDC.Location = new System.Drawing.Point(125, 103);
            this.txt_numeroCDC.Name = "txt_numeroCDC";
            this.txt_numeroCDC.Size = new System.Drawing.Size(74, 20);
            this.txt_numeroCDC.TabIndex = 6;
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
            this.groupBox1.Location = new System.Drawing.Point(29, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 151);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Contato";
            // 
            // txt_descricaoCDC
            // 
            this.txt_descricaoCDC.AcceptsTab = true;
            this.txt_descricaoCDC.Location = new System.Drawing.Point(102, 48);
            this.txt_descricaoCDC.Name = "txt_descricaoCDC";
            this.txt_descricaoCDC.Size = new System.Drawing.Size(272, 20);
            this.txt_descricaoCDC.TabIndex = 4;
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
            this.txtNome_CDC.TabIndex = 3;
            // 
            // LbEditarCentroCusto
            // 
            this.LbEditarCentroCusto.AutoSize = true;
            this.LbEditarCentroCusto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEditarCentroCusto.Location = new System.Drawing.Point(110, 9);
            this.LbEditarCentroCusto.Name = "LbEditarCentroCusto";
            this.LbEditarCentroCusto.Size = new System.Drawing.Size(224, 24);
            this.LbEditarCentroCusto.TabIndex = 28;
            this.LbEditarCentroCusto.Text = "Editar Centro de Custo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbNomeCentroProcura
            // 
            this.LbNomeCentroProcura.AutoSize = true;
            this.LbNomeCentroProcura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNomeCentroProcura.Location = new System.Drawing.Point(26, 59);
            this.LbNomeCentroProcura.Name = "LbNomeCentroProcura";
            this.LbNomeCentroProcura.Size = new System.Drawing.Size(121, 16);
            this.LbNomeCentroProcura.TabIndex = 26;
            this.LbNomeCentroProcura.Text = "Procurar por Nome:";
            // 
            // TxtProcuraCentro
            // 
            this.TxtProcuraCentro.AcceptsTab = true;
            this.TxtProcuraCentro.Location = new System.Drawing.Point(153, 58);
            this.TxtProcuraCentro.Name = "TxtProcuraCentro";
            this.TxtProcuraCentro.Size = new System.Drawing.Size(230, 20);
            this.TxtProcuraCentro.TabIndex = 1;
            // 
            // BtnProcuraFornecedor
            // 
            this.BtnProcuraFornecedor.Location = new System.Drawing.Point(389, 59);
            this.BtnProcuraFornecedor.Name = "BtnProcuraFornecedor";
            this.BtnProcuraFornecedor.Size = new System.Drawing.Size(26, 20);
            this.BtnProcuraFornecedor.TabIndex = 2;
            this.BtnProcuraFornecedor.Text = "...";
            this.BtnProcuraFornecedor.UseVisualStyleBackColor = true;
            this.BtnProcuraFornecedor.Click += new System.EventHandler(this.BtnProcuraFornecedor_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(29, 252);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Frm_Editar_CentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 287);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnProcuraFornecedor);
            this.Controls.Add(this.LbNomeCentroProcura);
            this.Controls.Add(this.BtnSalvarCDC);
            this.Controls.Add(this.TxtProcuraCentro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbEditarCentroCusto);
            this.Controls.Add(this.button1);
            this.Name = "Frm_Editar_CentroCusto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Centro de Custo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Button BtnSalvarCDC;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.TextBox txt_numeroCDC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descricaoCDC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.TextBox txtNome_CDC;
        private System.Windows.Forms.Label LbEditarCentroCusto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbNomeCentroProcura;
        private System.Windows.Forms.TextBox TxtProcuraCentro;
        private System.Windows.Forms.Button BtnProcuraFornecedor;
        private System.Windows.Forms.Button BtnLimpar;
    }
}