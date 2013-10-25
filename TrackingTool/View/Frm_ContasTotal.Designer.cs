namespace Tracking.View
{
    partial class Frm_ContasTotal
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
            this.DGContasTotal = new System.Windows.Forms.DataGridView();
            this.idCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastradoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebeCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LojaCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCustoCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnOK = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.LbCentro = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.CBCentros = new System.Windows.Forms.ComboBox();
            this.TxtPagar = new System.Windows.Forms.TextBox();
            this.TxtRecebido = new System.Windows.Forms.TextBox();
            this.TxtReceber = new System.Windows.Forms.TextBox();
            this.TxtPago = new System.Windows.Forms.TextBox();
            this.LbPagar = new System.Windows.Forms.Label();
            this.LbPago = new System.Windows.Forms.Label();
            this.LbRecebido = new System.Windows.Forms.Label();
            this.LbReceber = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LblDataInicio = new System.Windows.Forms.Label();
            this.LbDataFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGContasTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // DGContasTotal
            // 
            this.DGContasTotal.AllowUserToDeleteRows = false;
            this.DGContasTotal.AllowUserToOrderColumns = true;
            this.DGContasTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGContasTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCR,
            this.dataCadastradoCR,
            this.dataRecebeCR,
            this.CodigoCR,
            this.LojaCR,
            this.FornecedorCR,
            this.DescricaoCR,
            this.TipoCR,
            this.CentroCustoCR,
            this.ValorCR,
            this.StatusConta});
            this.DGContasTotal.Location = new System.Drawing.Point(12, 75);
            this.DGContasTotal.Name = "DGContasTotal";
            this.DGContasTotal.ReadOnly = true;
            this.DGContasTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGContasTotal.Size = new System.Drawing.Size(1172, 519);
            this.DGContasTotal.TabIndex = 1;
            // 
            // idCR
            // 
            this.idCR.HeaderText = "ID";
            this.idCR.Name = "idCR";
            this.idCR.ReadOnly = true;
            this.idCR.Width = 70;
            // 
            // dataCadastradoCR
            // 
            this.dataCadastradoCR.HeaderText = "Data do Cadastro";
            this.dataCadastradoCR.Name = "dataCadastradoCR";
            this.dataCadastradoCR.ReadOnly = true;
            // 
            // dataRecebeCR
            // 
            this.dataRecebeCR.HeaderText = "Data do Recebimento";
            this.dataRecebeCR.Name = "dataRecebeCR";
            this.dataRecebeCR.ReadOnly = true;
            // 
            // CodigoCR
            // 
            this.CodigoCR.HeaderText = "Código";
            this.CodigoCR.Name = "CodigoCR";
            this.CodigoCR.ReadOnly = true;
            // 
            // LojaCR
            // 
            this.LojaCR.HeaderText = "Loja";
            this.LojaCR.Name = "LojaCR";
            this.LojaCR.ReadOnly = true;
            // 
            // FornecedorCR
            // 
            this.FornecedorCR.HeaderText = "Fornecedor";
            this.FornecedorCR.Name = "FornecedorCR";
            this.FornecedorCR.ReadOnly = true;
            // 
            // DescricaoCR
            // 
            this.DescricaoCR.HeaderText = "Descrição da Conta";
            this.DescricaoCR.Name = "DescricaoCR";
            this.DescricaoCR.ReadOnly = true;
            this.DescricaoCR.Width = 160;
            // 
            // TipoCR
            // 
            this.TipoCR.HeaderText = "Tipo";
            this.TipoCR.Name = "TipoCR";
            this.TipoCR.ReadOnly = true;
            // 
            // CentroCustoCR
            // 
            this.CentroCustoCR.HeaderText = "Centro de Custo";
            this.CentroCustoCR.Name = "CentroCustoCR";
            this.CentroCustoCR.ReadOnly = true;
            // 
            // ValorCR
            // 
            this.ValorCR.HeaderText = "Valor R$";
            this.ValorCR.Name = "ValorCR";
            this.ValorCR.ReadOnly = true;
            // 
            // StatusConta
            // 
            this.StatusConta.HeaderText = "Status";
            this.StatusConta.Name = "StatusConta";
            this.StatusConta.ReadOnly = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(1109, 636);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(12, 624);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(329, 24);
            this.txtArquivoExcel.TabIndex = 9;
            this.txtArquivoExcel.Text = "C:\\Users\\Thiago\\Desktop\\Todas as Contas";
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Location = new System.Drawing.Point(346, 624);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(103, 23);
            this.BtnExcel.TabIndex = 10;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "Gerar Relatório";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // LbCentro
            // 
            this.LbCentro.AutoSize = true;
            this.LbCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCentro.Location = new System.Drawing.Point(9, 46);
            this.LbCentro.Name = "LbCentro";
            this.LbCentro.Size = new System.Drawing.Size(122, 16);
            this.LbCentro.TabIndex = 12;
            this.LbCentro.Text = "Centro de Custo:";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Location = new System.Drawing.Point(749, 43);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 13;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // CBCentros
            // 
            this.CBCentros.FormattingEnabled = true;
            this.CBCentros.Location = new System.Drawing.Point(138, 40);
            this.CBCentros.Name = "CBCentros";
            this.CBCentros.Size = new System.Drawing.Size(168, 21);
            this.CBCentros.TabIndex = 14;
            // 
            // TxtPagar
            // 
            this.TxtPagar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtPagar.Enabled = false;
            this.TxtPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.TxtPagar.ForeColor = System.Drawing.Color.Red;
            this.TxtPagar.Location = new System.Drawing.Point(568, 600);
            this.TxtPagar.Name = "TxtPagar";
            this.TxtPagar.Size = new System.Drawing.Size(85, 24);
            this.TxtPagar.TabIndex = 15;
            // 
            // TxtRecebido
            // 
            this.TxtRecebido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtRecebido.Enabled = false;
            this.TxtRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.TxtRecebido.ForeColor = System.Drawing.Color.Red;
            this.TxtRecebido.Location = new System.Drawing.Point(793, 635);
            this.TxtRecebido.Name = "TxtRecebido";
            this.TxtRecebido.Size = new System.Drawing.Size(85, 24);
            this.TxtRecebido.TabIndex = 16;
            // 
            // TxtReceber
            // 
            this.TxtReceber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtReceber.Enabled = false;
            this.TxtReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.TxtReceber.ForeColor = System.Drawing.Color.Red;
            this.TxtReceber.Location = new System.Drawing.Point(793, 600);
            this.TxtReceber.Name = "TxtReceber";
            this.TxtReceber.Size = new System.Drawing.Size(85, 24);
            this.TxtReceber.TabIndex = 17;
            // 
            // TxtPago
            // 
            this.TxtPago.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtPago.Enabled = false;
            this.TxtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.TxtPago.ForeColor = System.Drawing.Color.Red;
            this.TxtPago.Location = new System.Drawing.Point(568, 635);
            this.TxtPago.Name = "TxtPago";
            this.TxtPago.Size = new System.Drawing.Size(85, 24);
            this.TxtPago.TabIndex = 18;
            // 
            // LbPagar
            // 
            this.LbPagar.AutoSize = true;
            this.LbPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPagar.Location = new System.Drawing.Point(471, 608);
            this.LbPagar.Name = "LbPagar";
            this.LbPagar.Size = new System.Drawing.Size(91, 16);
            this.LbPagar.TabIndex = 19;
            this.LbPagar.Text = "A Pagar R$:";
            // 
            // LbPago
            // 
            this.LbPago.AutoSize = true;
            this.LbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPago.Location = new System.Drawing.Point(490, 643);
            this.LbPago.Name = "LbPago";
            this.LbPago.Size = new System.Drawing.Size(72, 16);
            this.LbPago.TabIndex = 20;
            this.LbPago.Text = "Pago R$:";
            // 
            // LbRecebido
            // 
            this.LbRecebido.AutoSize = true;
            this.LbRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRecebido.Location = new System.Drawing.Point(684, 643);
            this.LbRecebido.Name = "LbRecebido";
            this.LbRecebido.Size = new System.Drawing.Size(103, 16);
            this.LbRecebido.TabIndex = 21;
            this.LbRecebido.Text = "Recebido R$:";
            // 
            // LbReceber
            // 
            this.LbReceber.AutoSize = true;
            this.LbReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbReceber.Location = new System.Drawing.Point(678, 608);
            this.LbReceber.Name = "LbReceber";
            this.LbReceber.Size = new System.Drawing.Size(109, 16);
            this.LbReceber.TabIndex = 22;
            this.LbReceber.Text = "A Receber R$:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(493, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(493, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // LblDataInicio
            // 
            this.LblDataInicio.AutoSize = true;
            this.LblDataInicio.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblDataInicio.Location = new System.Drawing.Point(411, 12);
            this.LblDataInicio.Name = "LblDataInicio";
            this.LblDataInicio.Size = new System.Drawing.Size(76, 16);
            this.LblDataInicio.TabIndex = 62;
            this.LblDataInicio.Text = "Data Inicial:";
            // 
            // LbDataFinal
            // 
            this.LbDataFinal.AutoSize = true;
            this.LbDataFinal.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LbDataFinal.Location = new System.Drawing.Point(416, 50);
            this.LbDataFinal.Name = "LbDataFinal";
            this.LbDataFinal.Size = new System.Drawing.Size(71, 16);
            this.LbDataFinal.TabIndex = 63;
            this.LbDataFinal.Text = "Data Final:";
            // 
            // Frm_ContasTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 671);
            this.Controls.Add(this.LbDataFinal);
            this.Controls.Add(this.LblDataInicio);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LbReceber);
            this.Controls.Add(this.LbRecebido);
            this.Controls.Add(this.LbPago);
            this.Controls.Add(this.LbPagar);
            this.Controls.Add(this.TxtPago);
            this.Controls.Add(this.TxtReceber);
            this.Controls.Add(this.TxtRecebido);
            this.Controls.Add(this.TxtPagar);
            this.Controls.Add(this.CBCentros);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.LbCentro);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.DGContasTotal);
            this.Name = "Frm_ContasTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todas as Contas";
            ((System.ComponentModel.ISupportInitialize)(this.DGContasTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGContasTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastradoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebeCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn LojaCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCustoCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusConta;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Label LbCentro;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.ComboBox CBCentros;
        private System.Windows.Forms.TextBox TxtPagar;
        private System.Windows.Forms.TextBox TxtRecebido;
        private System.Windows.Forms.TextBox TxtReceber;
        private System.Windows.Forms.TextBox TxtPago;
        private System.Windows.Forms.Label LbPagar;
        private System.Windows.Forms.Label LbPago;
        private System.Windows.Forms.Label LbRecebido;
        private System.Windows.Forms.Label LbReceber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LblDataInicio;
        private System.Windows.Forms.Label LbDataFinal;
    }
}