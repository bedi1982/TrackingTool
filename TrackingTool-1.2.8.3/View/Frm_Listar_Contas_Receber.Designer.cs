namespace Tracking.View
{
    partial class Frm_Listar_Contas_Receber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Listar_Contas_Receber));
            this.DGContasReceber = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnContaRecebida = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtNovoValor = new System.Windows.Forms.TextBox();
            this.LblNovoValor = new System.Windows.Forms.Label();
            this.TxtTotalReceber = new System.Windows.Forms.TextBox();
            this.LbTotal = new System.Windows.Forms.Label();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.BtnExcel = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // DGContasReceber
            // 
            this.DGContasReceber.AllowUserToDeleteRows = false;
            this.DGContasReceber.AllowUserToOrderColumns = true;
            this.DGContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGContasReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCR,
            this.dataCadastradoCR,
            this.dataRecebeCR,
            this.CodigoCR,
            this.LojaCR,
            this.FornecedorCR,
            this.DescricaoCR,
            this.TipoCR,
            this.CentroCustoCR,
            this.ValorCR});
            this.DGContasReceber.Location = new System.Drawing.Point(12, 12);
            this.DGContasReceber.Name = "DGContasReceber";
            this.DGContasReceber.ReadOnly = true;
            this.DGContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGContasReceber.Size = new System.Drawing.Size(1087, 582);
            this.DGContasReceber.TabIndex = 0;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Red;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.Location = new System.Drawing.Point(12, 650);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(113, 33);
            this.BtnExcluir.TabIndex = 27;
            this.BtnExcluir.TabStop = false;
            this.BtnExcluir.Text = "Excluir Conta";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.BtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoltar.Image")));
            this.BtnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVoltar.Location = new System.Drawing.Point(1005, 650);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(94, 33);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.TabStop = false;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnContaRecebida
            // 
            this.BtnContaRecebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContaRecebida.Image = ((System.Drawing.Image)(resources.GetObject("BtnContaRecebida.Image")));
            this.BtnContaRecebida.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnContaRecebida.Location = new System.Drawing.Point(507, 605);
            this.BtnContaRecebida.Name = "BtnContaRecebida";
            this.BtnContaRecebida.Size = new System.Drawing.Size(126, 32);
            this.BtnContaRecebida.TabIndex = 4;
            this.BtnContaRecebida.TabStop = false;
            this.BtnContaRecebida.Text = "Receber Conta";
            this.BtnContaRecebida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContaRecebida.UseVisualStyleBackColor = true;
            this.BtnContaRecebida.Click += new System.EventHandler(this.BtnContaRecebida_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Image = ((System.Drawing.Image)(resources.GetObject("BtnOK.Image")));
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOK.Location = new System.Drawing.Point(421, 650);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(54, 33);
            this.BtnOK.TabIndex = 32;
            this.BtnOK.Text = "OK";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Visible = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtNovoValor
            // 
            this.TxtNovoValor.AcceptsTab = true;
            this.TxtNovoValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtNovoValor.Location = new System.Drawing.Point(282, 653);
            this.TxtNovoValor.Name = "TxtNovoValor";
            this.TxtNovoValor.Size = new System.Drawing.Size(124, 26);
            this.TxtNovoValor.TabIndex = 30;
            this.TxtNovoValor.Visible = false;
            // 
            // LblNovoValor
            // 
            this.LblNovoValor.AutoSize = true;
            this.LblNovoValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblNovoValor.Location = new System.Drawing.Point(177, 656);
            this.LblNovoValor.Name = "LblNovoValor";
            this.LblNovoValor.Size = new System.Drawing.Size(99, 19);
            this.LblNovoValor.TabIndex = 31;
            this.LblNovoValor.Text = "Novo Valor:";
            this.LblNovoValor.Visible = false;
            // 
            // TxtTotalReceber
            // 
            this.TxtTotalReceber.AcceptsTab = true;
            this.TxtTotalReceber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtTotalReceber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtTotalReceber.ForeColor = System.Drawing.Color.Red;
            this.TxtTotalReceber.Location = new System.Drawing.Point(917, 606);
            this.TxtTotalReceber.Name = "TxtTotalReceber";
            this.TxtTotalReceber.Size = new System.Drawing.Size(124, 26);
            this.TxtTotalReceber.TabIndex = 33;
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTotal.Location = new System.Drawing.Point(735, 611);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(176, 19);
            this.LbTotal.TabIndex = 34;
            this.LbTotal.Text = "Valor Total a Receber:";
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.ForeColor = System.Drawing.Color.Blue;
            this.BtnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAtualizar.Image")));
            this.BtnAtualizar.Location = new System.Drawing.Point(1063, 608);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(36, 36);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.TabStop = false;
            this.BtnAtualizar.Tag = "";
            this.BtnAtualizar.Text = "...";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(11, 613);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(329, 24);
            this.txtArquivoExcel.TabIndex = 1;
            this.txtArquivoExcel.Text = "C:\\Users\\Thiago\\Desktop\\Contas A Receber";
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcel.Image")));
            this.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcel.Location = new System.Drawing.Point(349, 605);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(126, 32);
            this.BtnExcel.TabIndex = 2;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "Gerar Relatório";
            this.BtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // idCR
            // 
            this.idCR.HeaderText = "ID";
            this.idCR.Name = "idCR";
            this.idCR.ReadOnly = true;
            this.idCR.Width = 80;
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
            // Frm_Listar_Contas_Receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 693);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.LbTotal);
            this.Controls.Add(this.TxtTotalReceber);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtNovoValor);
            this.Controls.Add(this.LblNovoValor);
            this.Controls.Add(this.BtnContaRecebida);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.DGContasReceber);
            this.Name = "Frm_Listar_Contas_Receber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            ((System.ComponentModel.ISupportInitialize)(this.DGContasReceber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGContasReceber;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnContaRecebida;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtNovoValor;
        private System.Windows.Forms.Label LblNovoValor;
        private System.Windows.Forms.TextBox TxtTotalReceber;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Button BtnExcel;
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
    }
}