namespace TrackingTool6.View
{
    partial class Frm_Listar_Fornecedores
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigohiperfarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroenderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._TrackingTool6_db_TrackingToolEntitiesDataSet1 = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSet();
            this.fornecedorTableAdapter = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.FornecedorTableAdapter();
            this.BtnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lista_removidosToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lista_removidosToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lista_apenas_os_com_status_não_falseToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lista_apenas_os_com_status_não_falseToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet1)).BeginInit();
            this.lista_removidosToolStrip1.SuspendLayout();
            this.lista_apenas_os_com_status_não_falseToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigohiperfarmaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.telefoneResDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.numeroenderecoDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.fornecedorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(947, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigohiperfarmaDataGridViewTextBoxColumn
            // 
            this.codigohiperfarmaDataGridViewTextBoxColumn.DataPropertyName = "codigo_hiperfarma";
            this.codigohiperfarmaDataGridViewTextBoxColumn.HeaderText = "codigo_hiperfarma";
            this.codigohiperfarmaDataGridViewTextBoxColumn.Name = "codigohiperfarmaDataGridViewTextBoxColumn";
            this.codigohiperfarmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            this.cNPJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneResDataGridViewTextBoxColumn
            // 
            this.telefoneResDataGridViewTextBoxColumn.DataPropertyName = "telefoneRes";
            this.telefoneResDataGridViewTextBoxColumn.HeaderText = "telefoneRes";
            this.telefoneResDataGridViewTextBoxColumn.Name = "telefoneResDataGridViewTextBoxColumn";
            this.telefoneResDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroenderecoDataGridViewTextBoxColumn
            // 
            this.numeroenderecoDataGridViewTextBoxColumn.DataPropertyName = "numero_endereco";
            this.numeroenderecoDataGridViewTextBoxColumn.HeaderText = "numero_endereco";
            this.numeroenderecoDataGridViewTextBoxColumn.Name = "numeroenderecoDataGridViewTextBoxColumn";
            this.numeroenderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.FalseValue = "Removido";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fornecedorBindingSource1
            // 
            this.fornecedorBindingSource1.DataMember = "Fornecedor";
            this.fornecedorBindingSource1.DataSource = this._TrackingTool6_db_TrackingToolEntitiesDataSet1;
            // 
            // _TrackingTool6_db_TrackingToolEntitiesDataSet1
            // 
            this._TrackingTool6_db_TrackingToolEntitiesDataSet1.DataSetName = "_TrackingTool6_db_TrackingToolEntitiesDataSet";
            this._TrackingTool6_db_TrackingToolEntitiesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(872, 499);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aqui você pode ver vários relatórios sobre seus Fornecedores:";
            // 
            // lista_removidosToolStrip1
            // 
            this.lista_removidosToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lista_removidosToolStripButton1});
            this.lista_removidosToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.lista_removidosToolStrip1.Name = "lista_removidosToolStrip1";
            this.lista_removidosToolStrip1.Size = new System.Drawing.Size(967, 25);
            this.lista_removidosToolStrip1.TabIndex = 6;
            this.lista_removidosToolStrip1.Text = "Listar Apenas Removidos";
            // 
            // lista_removidosToolStripButton1
            // 
            this.lista_removidosToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lista_removidosToolStripButton1.Name = "lista_removidosToolStripButton1";
            this.lista_removidosToolStripButton1.Size = new System.Drawing.Size(215, 22);
            this.lista_removidosToolStripButton1.Text = "Clique para listar Fornecedores Removidos";
            this.lista_removidosToolStripButton1.ToolTipText = "Clique para listar todos os Fornecedores Removidos do Sistema";
            this.lista_removidosToolStripButton1.Click += new System.EventHandler(this.lista_removidosToolStripButton1_Click);
            // 
            // lista_apenas_os_com_status_não_falseToolStrip1
            // 
            this.lista_apenas_os_com_status_não_falseToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lista_apenas_os_com_status_não_falseToolStripButton1});
            this.lista_apenas_os_com_status_não_falseToolStrip1.Location = new System.Drawing.Point(0, 25);
            this.lista_apenas_os_com_status_não_falseToolStrip1.Name = "lista_apenas_os_com_status_não_falseToolStrip1";
            this.lista_apenas_os_com_status_não_falseToolStrip1.Size = new System.Drawing.Size(967, 25);
            this.lista_apenas_os_com_status_não_falseToolStrip1.TabIndex = 7;
            this.lista_apenas_os_com_status_não_falseToolStrip1.Text = "lista_apenas_os_com_status_não_falseToolStrip1";
            // 
            // lista_apenas_os_com_status_não_falseToolStripButton1
            // 
            this.lista_apenas_os_com_status_não_falseToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lista_apenas_os_com_status_não_falseToolStripButton1.Name = "lista_apenas_os_com_status_não_falseToolStripButton1";
            this.lista_apenas_os_com_status_não_falseToolStripButton1.Size = new System.Drawing.Size(204, 22);
            this.lista_apenas_os_com_status_não_falseToolStripButton1.Text = "Clique para listar todos os Fornecedores";
            this.lista_apenas_os_com_status_não_falseToolStripButton1.Click += new System.EventHandler(this.lista_apenas_os_com_status_não_falseToolStripButton1_Click_1);
            // 
            // Frm_Listar_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(967, 542);
            this.Controls.Add(this.lista_apenas_os_com_status_não_falseToolStrip1);
            this.Controls.Add(this.lista_removidosToolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_Listar_Fornecedores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Fornecedores";
            this.Load += new System.EventHandler(this.Frm_Lista_Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet1)).EndInit();
            this.lista_removidosToolStrip1.ResumeLayout(false);
            this.lista_removidosToolStrip1.PerformLayout();
            this.lista_apenas_os_com_status_não_falseToolStrip1.ResumeLayout(false);
            this.lista_apenas_os_com_status_não_falseToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private _TrackingTool6_db_TrackingToolEntitiesDataSet _TrackingTool6_db_TrackingToolEntitiesDataSet1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigohiperfarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroenderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStrip lista_removidosToolStrip1;
        private System.Windows.Forms.ToolStripButton lista_removidosToolStripButton1;
        private System.Windows.Forms.ToolStrip lista_apenas_os_com_status_não_falseToolStrip1;
        private System.Windows.Forms.ToolStripButton lista_apenas_os_com_status_não_falseToolStripButton1;

    }
}