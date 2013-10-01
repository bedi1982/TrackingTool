namespace TrackingTool6.View
{
    partial class Frm_Baixa_Conta_A_Pagar
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
            this.LbAddForn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDadosConta = new System.Windows.Forms.GroupBox();
            this.lblValorPagto = new System.Windows.Forms.Label();
            this.txtValorPagto = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblNumCheque = new System.Windows.Forms.Label();
            this.txtNumCheque = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblCentroCusto = new System.Windows.Forms.Label();
            this.cbbCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDesp = new System.Windows.Forms.Label();
            this.txtDesp = new System.Windows.Forms.TextBox();
            this.dateVencimento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.dateEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.cbbForn = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centro_de_custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbDadosConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbAddForn
            // 
            this.LbAddForn.AutoSize = true;
            this.LbAddForn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddForn.Location = new System.Drawing.Point(260, 16);
            this.LbAddForn.Name = "LbAddForn";
            this.LbAddForn.Size = new System.Drawing.Size(157, 24);
            this.LbAddForn.TabIndex = 39;
            this.LbAddForn.Text = "Contas a Pagar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grbDadosConta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.lblDesp);
            this.groupBox1.Controls.Add(this.txtDesp);
            this.groupBox1.Controls.Add(this.dateVencimento);
            this.groupBox1.Controls.Add(this.lblVencimento);
            this.groupBox1.Controls.Add(this.lblEmissao);
            this.groupBox1.Controls.Add(this.dateEmissao);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.lblDoc);
            this.groupBox1.Controls.Add(this.cbbForn);
            this.groupBox1.Controls.Add(this.lblFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 587);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Pagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(8, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Selecione uma Conta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(99, 544);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "Quitar Conta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fornecedor,
            this.documento,
            this.despesa,
            this.centro_de_custo,
            this.valor_documento,
            this.vencimento});
            this.dataGridView1.Location = new System.Drawing.Point(11, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(639, 206);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(504, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Pendente";
            // 
            // grbDadosConta
            // 
            this.grbDadosConta.Controls.Add(this.lblValorPagto);
            this.grbDadosConta.Controls.Add(this.txtValorPagto);
            this.grbDadosConta.Controls.Add(this.lblDesc);
            this.grbDadosConta.Controls.Add(this.textBox2);
            this.grbDadosConta.Controls.Add(this.txtJuros);
            this.grbDadosConta.Controls.Add(this.lblJuros);
            this.grbDadosConta.Controls.Add(this.lblNumCheque);
            this.grbDadosConta.Controls.Add(this.txtNumCheque);
            this.grbDadosConta.Controls.Add(this.textBox1);
            this.grbDadosConta.Controls.Add(this.label3);
            this.grbDadosConta.Controls.Add(this.txtConta);
            this.grbDadosConta.Controls.Add(this.lblConta);
            this.grbDadosConta.Controls.Add(this.txtBanco);
            this.grbDadosConta.Controls.Add(this.lblBanco);
            this.grbDadosConta.Controls.Add(this.lblCentroCusto);
            this.grbDadosConta.Controls.Add(this.cbbCC);
            this.grbDadosConta.Location = new System.Drawing.Point(11, 392);
            this.grbDadosConta.Name = "grbDadosConta";
            this.grbDadosConta.Size = new System.Drawing.Size(598, 146);
            this.grbDadosConta.TabIndex = 53;
            this.grbDadosConta.TabStop = false;
            this.grbDadosConta.Text = "Dados da Conta";
            // 
            // lblValorPagto
            // 
            this.lblValorPagto.AutoSize = true;
            this.lblValorPagto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblValorPagto.Location = new System.Drawing.Point(7, 100);
            this.lblValorPagto.Name = "lblValorPagto";
            this.lblValorPagto.Size = new System.Drawing.Size(95, 16);
            this.lblValorPagto.TabIndex = 63;
            this.lblValorPagto.Text = "Valor Pago R$:";
            // 
            // txtValorPagto
            // 
            this.txtValorPagto.AcceptsTab = true;
            this.txtValorPagto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorPagto.Location = new System.Drawing.Point(10, 116);
            this.txtValorPagto.Name = "txtValorPagto";
            this.txtValorPagto.ReadOnly = true;
            this.txtValorPagto.Size = new System.Drawing.Size(90, 20);
            this.txtValorPagto.TabIndex = 62;
            this.txtValorPagto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDesc.Location = new System.Drawing.Point(7, 60);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(67, 16);
            this.lblDesc.TabIndex = 61;
            this.lblDesc.Text = "Desconto:";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Location = new System.Drawing.Point(10, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 60;
            // 
            // txtJuros
            // 
            this.txtJuros.AcceptsTab = true;
            this.txtJuros.Location = new System.Drawing.Point(105, 77);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.ReadOnly = true;
            this.txtJuros.Size = new System.Drawing.Size(58, 20);
            this.txtJuros.TabIndex = 59;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblJuros.Location = new System.Drawing.Point(102, 60);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(43, 16);
            this.lblJuros.TabIndex = 58;
            this.lblJuros.Text = "Juros:";
            // 
            // lblNumCheque
            // 
            this.lblNumCheque.AutoSize = true;
            this.lblNumCheque.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblNumCheque.Location = new System.Drawing.Point(369, 100);
            this.lblNumCheque.Name = "lblNumCheque";
            this.lblNumCheque.Size = new System.Drawing.Size(78, 16);
            this.lblNumCheque.TabIndex = 57;
            this.lblNumCheque.Text = "Nº  Cheque:";
            // 
            // txtNumCheque
            // 
            this.txtNumCheque.AcceptsTab = true;
            this.txtNumCheque.Location = new System.Drawing.Point(372, 116);
            this.txtNumCheque.Name = "txtNumCheque";
            this.txtNumCheque.ReadOnly = true;
            this.txtNumCheque.Size = new System.Drawing.Size(119, 20);
            this.txtNumCheque.TabIndex = 56;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(372, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(369, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Agência:";
            // 
            // txtConta
            // 
            this.txtConta.AcceptsTab = true;
            this.txtConta.Location = new System.Drawing.Point(453, 77);
            this.txtConta.Name = "txtConta";
            this.txtConta.ReadOnly = true;
            this.txtConta.Size = new System.Drawing.Size(119, 20);
            this.txtConta.TabIndex = 53;
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblConta.Location = new System.Drawing.Point(452, 60);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(46, 16);
            this.lblConta.TabIndex = 52;
            this.lblConta.Text = "Conta:";
            // 
            // txtBanco
            // 
            this.txtBanco.AcceptsTab = true;
            this.txtBanco.Location = new System.Drawing.Point(372, 32);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.ReadOnly = true;
            this.txtBanco.Size = new System.Drawing.Size(119, 20);
            this.txtBanco.TabIndex = 51;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblBanco.Location = new System.Drawing.Point(369, 16);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(49, 16);
            this.lblBanco.TabIndex = 50;
            this.lblBanco.Text = "Banco:";
            // 
            // lblCentroCusto
            // 
            this.lblCentroCusto.AutoSize = true;
            this.lblCentroCusto.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblCentroCusto.Location = new System.Drawing.Point(6, 16);
            this.lblCentroCusto.Name = "lblCentroCusto";
            this.lblCentroCusto.Size = new System.Drawing.Size(106, 16);
            this.lblCentroCusto.TabIndex = 40;
            this.lblCentroCusto.Text = "Centro de Custo:";
            // 
            // cbbCC
            // 
            this.cbbCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCC.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbbCC.FormattingEnabled = true;
            this.cbbCC.Location = new System.Drawing.Point(9, 33);
            this.cbbCC.Name = "cbbCC";
            this.cbbCC.Size = new System.Drawing.Size(182, 24);
            this.cbbCC.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(439, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "0,00";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(381, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(117, 39);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = "Valor do documento:";
            // 
            // lblDesp
            // 
            this.lblDesp.AutoSize = true;
            this.lblDesp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDesp.Location = new System.Drawing.Point(6, 65);
            this.lblDesp.Name = "lblDesp";
            this.lblDesp.Size = new System.Drawing.Size(63, 16);
            this.lblDesp.TabIndex = 50;
            this.lblDesp.Text = "Despesa:";
            // 
            // txtDesp
            // 
            this.txtDesp.AcceptsTab = true;
            this.txtDesp.Location = new System.Drawing.Point(9, 84);
            this.txtDesp.Name = "txtDesp";
            this.txtDesp.ReadOnly = true;
            this.txtDesp.Size = new System.Drawing.Size(218, 20);
            this.txtDesp.TabIndex = 49;
            // 
            // dateVencimento
            // 
            this.dateVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVencimento.Location = new System.Drawing.Point(507, 81);
            this.dateVencimento.Name = "dateVencimento";
            this.dateVencimento.Size = new System.Drawing.Size(101, 20);
            this.dateVencimento.TabIndex = 47;
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblVencimento.Location = new System.Drawing.Point(504, 65);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(80, 16);
            this.lblVencimento.TabIndex = 46;
            this.lblVencimento.Text = "Vencimento:";
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblEmissao.Location = new System.Drawing.Point(378, 65);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(63, 16);
            this.lblEmissao.TabIndex = 45;
            this.lblEmissao.Text = "Emissão:";
            // 
            // dateEmissao
            // 
            this.dateEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEmissao.Location = new System.Drawing.Point(381, 81);
            this.dateEmissao.Name = "dateEmissao";
            this.dateEmissao.Size = new System.Drawing.Size(100, 20);
            this.dateEmissao.TabIndex = 44;
            // 
            // txtDocumento
            // 
            this.txtDocumento.AcceptsTab = true;
            this.txtDocumento.Location = new System.Drawing.Point(381, 42);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(269, 20);
            this.txtDocumento.TabIndex = 43;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDoc.Location = new System.Drawing.Point(378, 22);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(78, 16);
            this.lblDoc.TabIndex = 42;
            this.lblDoc.Text = "Documento:";
            // 
            // cbbForn
            // 
            this.cbbForn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cbbForn.FormattingEnabled = true;
            this.cbbForn.Location = new System.Drawing.Point(9, 38);
            this.cbbForn.Name = "cbbForn";
            this.cbbForn.Size = new System.Drawing.Size(327, 24);
            this.cbbForn.TabIndex = 38;
            this.cbbForn.SelectedIndexChanged += new System.EventHandler(this.cbbForn_SelectedIndexChanged);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblFornecedor.Location = new System.Drawing.Point(6, 22);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(77, 16);
            this.lblFornecedor.TabIndex = 6;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // fornecedor
            // 
            this.fornecedor.HeaderText = "Fornecedor";
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // despesa
            // 
            this.despesa.HeaderText = "Despesa";
            this.despesa.Name = "despesa";
            this.despesa.ReadOnly = true;
            // 
            // centro_de_custo
            // 
            this.centro_de_custo.HeaderText = "Centro de Custo";
            this.centro_de_custo.Name = "centro_de_custo";
            this.centro_de_custo.ReadOnly = true;
            // 
            // valor_documento
            // 
            this.valor_documento.HeaderText = "Valor do documento";
            this.valor_documento.Name = "valor_documento";
            this.valor_documento.ReadOnly = true;
            // 
            // vencimento
            // 
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.ReadOnly = true;
            // 
            // Frm_Baixa_Conta_A_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 669);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbAddForn);
            this.Name = "Frm_Baixa_Conta_A_Pagar";
            this.Text = "Frm_Baixa_Conta_A_Pagar";
            this.Load += new System.EventHandler(this.Frm_Baixa_Conta_A_Pagar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbDadosConta.ResumeLayout(false);
            this.grbDadosConta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAddForn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cbbForn;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.DateTimePicker dateEmissao;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.DateTimePicker dateVencimento;
        private System.Windows.Forms.TextBox txtDesp;
        private System.Windows.Forms.Label lblDesp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbDadosConta;
        private System.Windows.Forms.ComboBox cbbCC;
        private System.Windows.Forms.Label lblCentroCusto;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumCheque;
        private System.Windows.Forms.Label lblNumCheque;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtValorPagto;
        private System.Windows.Forms.Label lblValorPagto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn despesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn centro_de_custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
    }
}