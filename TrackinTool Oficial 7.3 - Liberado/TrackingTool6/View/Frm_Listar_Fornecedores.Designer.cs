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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._TrackingTool6_db_TrackingToolEntitiesDataSet1 = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSet();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._TrackingTool6_db_TrackingToolEntitiesDataSet = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSet();
            this.fornecedorTableAdapter = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.FornecedorTableAdapter();
            this.BtnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.telefoneResDataGridViewTextBoxColumn,
            this.telefoneCelDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fornecedorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // telefoneResDataGridViewTextBoxColumn
            // 
            this.telefoneResDataGridViewTextBoxColumn.DataPropertyName = "telefoneRes";
            this.telefoneResDataGridViewTextBoxColumn.HeaderText = "telefoneRes";
            this.telefoneResDataGridViewTextBoxColumn.Name = "telefoneResDataGridViewTextBoxColumn";
            // 
            // telefoneCelDataGridViewTextBoxColumn
            // 
            this.telefoneCelDataGridViewTextBoxColumn.DataPropertyName = "telefoneCel";
            this.telefoneCelDataGridViewTextBoxColumn.HeaderText = "telefoneCel";
            this.telefoneCelDataGridViewTextBoxColumn.Name = "telefoneCelDataGridViewTextBoxColumn";
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
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
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this._TrackingTool6_db_TrackingToolEntitiesDataSet;
            // 
            // _TrackingTool6_db_TrackingToolEntitiesDataSet
            // 
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.DataSetName = "_TrackingTool6_db_TrackingToolEntitiesDataSet";
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(464, 305);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // Frm_Listar_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 347);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_Listar_Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Fornecedores";
            this.Load += new System.EventHandler(this.Frm_Lista_Fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _TrackingTool6_db_TrackingToolEntitiesDataSet _TrackingTool6_db_TrackingToolEntitiesDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private _TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private _TrackingTool6_db_TrackingToolEntitiesDataSet _TrackingTool6_db_TrackingToolEntitiesDataSet1;
        private System.Windows.Forms.BindingSource fornecedorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnOK;

    }
}