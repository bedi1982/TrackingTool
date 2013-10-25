namespace Tracking.View
{
    partial class Frm_Listar_Contas_Pagar
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
            this.DGContasAPagar = new System.Windows.Forms.DataGridView();
            this.BtnContaPaga = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtNovoValor = new System.Windows.Forms.TextBox();
            this.LblNovoValor = new System.Windows.Forms.Label();
            this.LbPagar = new System.Windows.Forms.Label();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.idCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastradoCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRecebeCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LojaCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CentroCustoCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGContasAPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // DGContasAPagar
            // 
            this.DGContasAPagar.AllowUserToDeleteRows = false;
            this.DGContasAPagar.AllowUserToOrderColumns = true;
            this.DGContasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGContasAPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCP,
            this.dataCadastradoCP,
            this.dataRecebeCP,
            this.CodigoCP,
            this.LojaCP,
            this.FornecedorCP,
            this.TipoCP,
            this.DescricaoCP,
            this.CentroCustoCP,
            this.ValorCP});
            this.DGContasAPagar.Location = new System.Drawing.Point(12, 76);
            this.DGContasAPagar.Name = "DGContasAPagar";
            this.DGContasAPagar.ReadOnly = true;
            this.DGContasAPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGContasAPagar.Size = new System.Drawing.Size(1087, 519);
            this.DGContasAPagar.TabIndex = 1;
            // 
            // BtnContaPaga
            // 
            this.BtnContaPaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContaPaga.Location = new System.Drawing.Point(484, 636);
            this.BtnContaPaga.Name = "BtnContaPaga";
            this.BtnContaPaga.Size = new System.Drawing.Size(103, 23);
            this.BtnContaPaga.TabIndex = 4;
            this.BtnContaPaga.TabStop = false;
            this.BtnContaPaga.Text = "Pagar Conta";
            this.BtnContaPaga.UseVisualStyleBackColor = true;
            this.BtnContaPaga.Click += new System.EventHandler(this.BtnContaPaga_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.ForeColor = System.Drawing.Color.Black;
            this.BtnVoltar.Location = new System.Drawing.Point(996, 636);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(103, 23);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.TabStop = false;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExcluir.Location = new System.Drawing.Point(12, 636);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 23);
            this.BtnExcluir.TabIndex = 30;
            this.BtnExcluir.TabStop = false;
            this.BtnExcluir.Text = "Excluir Conta";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Location = new System.Drawing.Point(421, 637);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(43, 20);
            this.BtnOK.TabIndex = 35;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Visible = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtNovoValor
            // 
            this.TxtNovoValor.AcceptsTab = true;
            this.TxtNovoValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtNovoValor.Location = new System.Drawing.Point(291, 633);
            this.TxtNovoValor.Name = "TxtNovoValor";
            this.TxtNovoValor.Size = new System.Drawing.Size(124, 26);
            this.TxtNovoValor.TabIndex = 33;
            this.TxtNovoValor.Visible = false;
            // 
            // LblNovoValor
            // 
            this.LblNovoValor.AutoSize = true;
            this.LblNovoValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblNovoValor.Location = new System.Drawing.Point(186, 640);
            this.LblNovoValor.Name = "LblNovoValor";
            this.LblNovoValor.Size = new System.Drawing.Size(99, 19);
            this.LblNovoValor.TabIndex = 34;
            this.LblNovoValor.Text = "Novo Valor:";
            this.LblNovoValor.Visible = false;
            // 
            // LbPagar
            // 
            this.LbPagar.AutoSize = true;
            this.LbPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPagar.Location = new System.Drawing.Point(782, 609);
            this.LbPagar.Name = "LbPagar";
            this.LbPagar.Size = new System.Drawing.Size(157, 19);
            this.LbPagar.TabIndex = 37;
            this.LbPagar.Text = "Valor Total a Pagar:";
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.AcceptsTab = true;
            this.TxtTotalPagar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TxtTotalPagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TxtTotalPagar.ForeColor = System.Drawing.Color.Red;
            this.TxtTotalPagar.Location = new System.Drawing.Point(945, 602);
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(124, 26);
            this.TxtTotalPagar.TabIndex = 36;
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoExcel.Location = new System.Drawing.Point(12, 604);
            this.txtArquivoExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(329, 24);
            this.txtArquivoExcel.TabIndex = 1;
            this.txtArquivoExcel.Text = "C:\\Users\\Thiago\\Desktop\\Contas a Pagar";
            // 
            // BtnExcel
            // 
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Location = new System.Drawing.Point(349, 605);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(103, 23);
            this.BtnExcel.TabIndex = 2;
            this.BtnExcel.TabStop = false;
            this.BtnExcel.Text = "Gerar Relatório";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.ForeColor = System.Drawing.Color.Blue;
            this.BtnAtualizar.Image = global::Tracking.Properties.Resources.reload_arrow;
            this.BtnAtualizar.Location = new System.Drawing.Point(1072, 605);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(27, 23);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.TabStop = false;
            this.BtnAtualizar.Tag = "";
            this.BtnAtualizar.Text = "...";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // idCP
            // 
            this.idCP.HeaderText = "ID";
            this.idCP.Name = "idCP";
            this.idCP.ReadOnly = true;
            this.idCP.Width = 80;
            // 
            // dataCadastradoCP
            // 
            this.dataCadastradoCP.HeaderText = "Data do Cadastro";
            this.dataCadastradoCP.Name = "dataCadastradoCP";
            this.dataCadastradoCP.ReadOnly = true;
            this.dataCadastradoCP.Width = 110;
            // 
            // dataRecebeCP
            // 
            this.dataRecebeCP.HeaderText = "Data do Recebimento";
            this.dataRecebeCP.Name = "dataRecebeCP";
            this.dataRecebeCP.ReadOnly = true;
            this.dataRecebeCP.Width = 110;
            // 
            // CodigoCP
            // 
            this.CodigoCP.HeaderText = "Código";
            this.CodigoCP.Name = "CodigoCP";
            this.CodigoCP.ReadOnly = true;
            // 
            // LojaCP
            // 
            this.LojaCP.HeaderText = "Loja";
            this.LojaCP.Name = "LojaCP";
            this.LojaCP.ReadOnly = true;
            // 
            // FornecedorCP
            // 
            this.FornecedorCP.HeaderText = "Fornecedor";
            this.FornecedorCP.Name = "FornecedorCP";
            this.FornecedorCP.ReadOnly = true;
            // 
            // TipoCP
            // 
            this.TipoCP.HeaderText = "Tipo";
            this.TipoCP.Name = "TipoCP";
            this.TipoCP.ReadOnly = true;
            // 
            // DescricaoCP
            // 
            this.DescricaoCP.HeaderText = "Descrição da Conta";
            this.DescricaoCP.Name = "DescricaoCP";
            this.DescricaoCP.ReadOnly = true;
            this.DescricaoCP.Width = 150;
            // 
            // CentroCustoCP
            // 
            this.CentroCustoCP.HeaderText = "Centro de Custo";
            this.CentroCustoCP.Name = "CentroCustoCP";
            this.CentroCustoCP.ReadOnly = true;
            // 
            // ValorCP
            // 
            this.ValorCP.HeaderText = "Valor R$";
            this.ValorCP.Name = "ValorCP";
            this.ValorCP.ReadOnly = true;
            this.ValorCP.Width = 95;
            // 
            // Frm_Listar_Contas_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 671);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.LbPagar);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtNovoValor);
            this.Controls.Add(this.LblNovoValor);
            this.Controls.Add(this.BtnContaPaga);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.DGContasAPagar);
            this.Name = "Frm_Listar_Contas_Pagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.DGContasAPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGContasAPagar;
        private System.Windows.Forms.Button BtnContaPaga;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.TextBox TxtNovoValor;
        private System.Windows.Forms.Label LblNovoValor;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Label LbPagar;
        private System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastradoCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebeCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LojaCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CentroCustoCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCP;
    }
}