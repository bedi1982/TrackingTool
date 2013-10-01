namespace TrackingTool6.View
{
    partial class Frm_Cadastar_Contas_Pagar
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
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblForn = new System.Windows.Forms.Label();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.lblDesp = new System.Windows.Forms.Label();
            this.lblCentroCusto = new System.Windows.Forms.Label();
            this.lblDataPagto = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.lblNumCheque = new System.Windows.Forms.Label();
            this.txtNumCheque = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtValorPagto = new System.Windows.Forms.TextBox();
            this.lblValorPagto = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.LbAddForn = new System.Windows.Forms.Label();
            this.grbContaPagar = new System.Windows.Forms.GroupBox();
            this.cbbForn = new System.Windows.Forms.ComboBox();
            this.grbValores = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbbCC = new System.Windows.Forms.ComboBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this._TrackingTool6_db_TrackingToolEntitiesDataSet = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSet();
            this.grbContaPagar.SuspendLayout();
            this.grbValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumento
            // 
            this.txtDocumento.AcceptsTab = true;
            this.txtDocumento.Location = new System.Drawing.Point(115, 24);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(343, 20);
            this.txtDocumento.TabIndex = 2;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDoc.Location = new System.Drawing.Point(35, 25);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(78, 16);
            this.lblDoc.TabIndex = 5;
            this.lblDoc.Text = "Documento:";
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblEmissao.Location = new System.Drawing.Point(50, 82);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(63, 16);
            this.lblEmissao.TabIndex = 6;
            this.lblEmissao.Text = "Emissão:";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblVencimento.Location = new System.Drawing.Point(276, 82);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(80, 16);
            this.lblVencimento.TabIndex = 9;
            this.lblVencimento.Text = "Vencimento:";
            // 
            // txtValor
            // 
            this.txtValor.AcceptsTab = true;
            this.txtValor.Location = new System.Drawing.Point(115, 151);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(81, 20);
            this.txtValor.TabIndex = 10;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblValor.Location = new System.Drawing.Point(48, 152);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(65, 16);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor  R$:";
            // 
            // lblForn
            // 
            this.lblForn.AutoSize = true;
            this.lblForn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblForn.Location = new System.Drawing.Point(36, 51);
            this.lblForn.Name = "lblForn";
            this.lblForn.Size = new System.Drawing.Size(77, 16);
            this.lblForn.TabIndex = 12;
            this.lblForn.Text = "Fornecedor:";
            // 
            // txtDesp
            // 
            this.txtDesp.AcceptsTab = true;
            this.txtDesp.Location = new System.Drawing.Point(115, 115);
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.Size = new System.Drawing.Size(218, 20);
            this.txtDesp.TabIndex = 14;
            // 
            // lblDesp
            // 
            this.lblDesp.AutoSize = true;
            this.lblDesp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDesp.Location = new System.Drawing.Point(50, 115);
            this.lblDesp.Name = "lblDesp";
            this.lblDesp.Size = new System.Drawing.Size(63, 16);
            this.lblDesp.TabIndex = 15;
            this.lblDesp.Text = "Despesa:";
            // 
            // lblCentroCusto
            // 
            this.lblCentroCusto.AutoSize = true;
            this.lblCentroCusto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblCentroCusto.Location = new System.Drawing.Point(7, 32);
            this.lblCentroCusto.Name = "lblCentroCusto";
            this.lblCentroCusto.Size = new System.Drawing.Size(106, 16);
            this.lblCentroCusto.TabIndex = 17;
            this.lblCentroCusto.Text = "Centro de Custo:";
            // 
            // lblDataPagto
            // 
            this.lblDataPagto.AutoSize = true;
            this.lblDataPagto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDataPagto.Location = new System.Drawing.Point(18, 64);
            this.lblDataPagto.Name = "lblDataPagto";
            this.lblDataPagto.Size = new System.Drawing.Size(95, 16);
            this.lblDataPagto.TabIndex = 18;
            this.lblDataPagto.Text = "Data do Pagto:";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblBanco.Location = new System.Drawing.Point(64, 96);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(49, 16);
            this.lblBanco.TabIndex = 20;
            this.lblBanco.Text = "Banco:";
            // 
            // txtBanco
            // 
            this.txtBanco.AcceptsTab = true;
            this.txtBanco.Location = new System.Drawing.Point(115, 95);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(119, 20);
            this.txtBanco.TabIndex = 21;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblConta.Location = new System.Drawing.Point(251, 97);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(46, 16);
            this.lblConta.TabIndex = 22;
            this.lblConta.Text = "Conta:";
            // 
            // txtConta
            // 
            this.txtConta.AcceptsTab = true;
            this.txtConta.Location = new System.Drawing.Point(298, 97);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(119, 20);
            this.txtConta.TabIndex = 23;
            // 
            // lblNumCheque
            // 
            this.lblNumCheque.AutoSize = true;
            this.lblNumCheque.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblNumCheque.Location = new System.Drawing.Point(35, 125);
            this.lblNumCheque.Name = "lblNumCheque";
            this.lblNumCheque.Size = new System.Drawing.Size(78, 16);
            this.lblNumCheque.TabIndex = 24;
            this.lblNumCheque.Text = "Nº  Cheque:";
            // 
            // txtNumCheque
            // 
            this.txtNumCheque.AcceptsTab = true;
            this.txtNumCheque.Location = new System.Drawing.Point(115, 124);
            this.txtNumCheque.Name = "txtNumCheque";
            this.txtNumCheque.Size = new System.Drawing.Size(119, 20);
            this.txtNumCheque.TabIndex = 25;
            // 
            // txtJuros
            // 
            this.txtJuros.AcceptsTab = true;
            this.txtJuros.Location = new System.Drawing.Point(298, 125);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(58, 20);
            this.txtJuros.TabIndex = 26;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblJuros.Location = new System.Drawing.Point(254, 125);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(43, 16);
            this.lblJuros.TabIndex = 27;
            this.lblJuros.Text = "Juros:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(115, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 28;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDesc.Location = new System.Drawing.Point(46, 155);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(67, 16);
            this.lblDesc.TabIndex = 29;
            this.lblDesc.Text = "Desconto:";
            // 
            // txtValorPagto
            // 
            this.txtValorPagto.AcceptsTab = true;
            this.txtValorPagto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorPagto.Location = new System.Drawing.Point(107, 189);
            this.txtValorPagto.Name = "txtValorPagto";
            this.txtValorPagto.Size = new System.Drawing.Size(81, 20);
            this.txtValorPagto.TabIndex = 30;
            this.txtValorPagto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValorPagto
            // 
            this.lblValorPagto.AutoSize = true;
            this.lblValorPagto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblValorPagto.Location = new System.Drawing.Point(18, 190);
            this.lblValorPagto.Name = "lblValorPagto";
            this.lblValorPagto.Size = new System.Drawing.Size(95, 16);
            this.lblValorPagto.TabIndex = 31;
            this.lblValorPagto.Text = "Valor Pago R$:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblObservacao.Location = new System.Drawing.Point(26, 220);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(87, 16);
            this.lblObservacao.TabIndex = 33;
            this.lblObservacao.Text = "Observações:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(358, 552);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 34;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(357, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(115, 64);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker3.TabIndex = 37;
            this.dateTimePicker3.Value = new System.DateTime(2013, 9, 19, 0, 0, 0, 0);
            // 
            // LbAddForn
            // 
            this.LbAddForn.AutoSize = true;
            this.LbAddForn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddForn.Location = new System.Drawing.Point(150, 9);
            this.LbAddForn.Name = "LbAddForn";
            this.LbAddForn.Size = new System.Drawing.Size(249, 24);
            this.LbAddForn.TabIndex = 38;
            this.LbAddForn.Text = "Cadastro Contas a Pagar";
            // 
            // grbContaPagar
            // 
            this.grbContaPagar.Controls.Add(this.cbbForn);
            this.grbContaPagar.Controls.Add(this.txtDocumento);
            this.grbContaPagar.Controls.Add(this.lblDoc);
            this.grbContaPagar.Controls.Add(this.dateTimePicker1);
            this.grbContaPagar.Controls.Add(this.dateTimePicker2);
            this.grbContaPagar.Controls.Add(this.lblVencimento);
            this.grbContaPagar.Controls.Add(this.lblEmissao);
            this.grbContaPagar.Controls.Add(this.txtValor);
            this.grbContaPagar.Controls.Add(this.lblValor);
            this.grbContaPagar.Controls.Add(this.lblForn);
            this.grbContaPagar.Controls.Add(this.txtDesp);
            this.grbContaPagar.Controls.Add(this.lblDesp);
            this.grbContaPagar.Location = new System.Drawing.Point(16, 45);
            this.grbContaPagar.Name = "grbContaPagar";
            this.grbContaPagar.Size = new System.Drawing.Size(514, 192);
            this.grbContaPagar.TabIndex = 39;
            this.grbContaPagar.TabStop = false;
            this.grbContaPagar.Text = "Dados da Conta";
            // 
            // cbbForn
            // 
            this.cbbForn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbbForn.FormattingEnabled = true;
            this.cbbForn.Location = new System.Drawing.Point(115, 51);
            this.cbbForn.Name = "cbbForn";
            this.cbbForn.Size = new System.Drawing.Size(182, 24);
            this.cbbForn.TabIndex = 37;
            // 
            // grbValores
            // 
            this.grbValores.Controls.Add(this.richTextBox1);
            this.grbValores.Controls.Add(this.cbbCC);
            this.grbValores.Controls.Add(this.lblCentroCusto);
            this.grbValores.Controls.Add(this.dateTimePicker3);
            this.grbValores.Controls.Add(this.lblDataPagto);
            this.grbValores.Controls.Add(this.txtConta);
            this.grbValores.Controls.Add(this.lblObservacao);
            this.grbValores.Controls.Add(this.lblConta);
            this.grbValores.Controls.Add(this.txtBanco);
            this.grbValores.Controls.Add(this.lblDesc);
            this.grbValores.Controls.Add(this.lblValorPagto);
            this.grbValores.Controls.Add(this.lblBanco);
            this.grbValores.Controls.Add(this.txtValorPagto);
            this.grbValores.Controls.Add(this.txtNumCheque);
            this.grbValores.Controls.Add(this.txtJuros);
            this.grbValores.Controls.Add(this.textBox1);
            this.grbValores.Controls.Add(this.lblJuros);
            this.grbValores.Controls.Add(this.lblNumCheque);
            this.grbValores.Location = new System.Drawing.Point(16, 257);
            this.grbValores.Name = "grbValores";
            this.grbValores.Size = new System.Drawing.Size(514, 280);
            this.grbValores.TabIndex = 40;
            this.grbValores.TabStop = false;
            this.grbValores.Text = "Valores";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(115, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 49);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            // 
            // cbbCC
            // 
            this.cbbCC.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbbCC.FormattingEnabled = true;
            this.cbbCC.Location = new System.Drawing.Point(115, 31);
            this.cbbCC.Name = "cbbCC";
            this.cbbCC.Size = new System.Drawing.Size(182, 24);
            this.cbbCC.TabIndex = 38;
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(455, 552);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 41;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            // 
            // _TrackingTool6_db_TrackingToolEntitiesDataSet
            // 
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.DataSetName = "_TrackingTool6_db_TrackingToolEntitiesDataSet";
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Frm_Cadastar_Contas_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 588);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.grbValores);
            this.Controls.Add(this.grbContaPagar);
            this.Controls.Add(this.LbAddForn);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "Frm_Cadastar_Contas_Pagar";
            this.Text = "Cadastrar Contas a Pagar";
            this.Load += new System.EventHandler(this.Frm_Cadastar_Contas_Pagar_Load);
            this.grbContaPagar.ResumeLayout(false);
            this.grbContaPagar.PerformLayout();
            this.grbValores.ResumeLayout(false);
            this.grbValores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblForn;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.Label lblDesp;
        private System.Windows.Forms.Label lblCentroCusto;
        private System.Windows.Forms.Label lblDataPagto;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label lblNumCheque;
        private System.Windows.Forms.TextBox txtNumCheque;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtValorPagto;
        private System.Windows.Forms.Label lblValorPagto;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label LbAddForn;
        private System.Windows.Forms.GroupBox grbContaPagar;
        private System.Windows.Forms.GroupBox grbValores;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.ComboBox cbbForn;
        private _TrackingTool6_db_TrackingToolEntitiesDataSet _TrackingTool6_db_TrackingToolEntitiesDataSet;
        private System.Windows.Forms.ComboBox cbbCC;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}