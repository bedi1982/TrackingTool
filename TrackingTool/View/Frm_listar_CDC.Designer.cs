namespace TrackingTool6.View
{
    partial class Frm_listar_CDC
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
            this._TrackingTool6_db_TrackingToolEntitiesDataSet = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSet();
            this.trackingTool6dbTrackingToolEntitiesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centrosDeCustoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centrosDeCustoTableAdapter = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.CentrosDeCustoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigohiperfarmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackingTool6dbTrackingToolEntitiesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosDeCustoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.codigohiperfarmaDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.centrosDeCustoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // _TrackingTool6_db_TrackingToolEntitiesDataSet
            // 
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.DataSetName = "_TrackingTool6_db_TrackingToolEntitiesDataSet";
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trackingTool6dbTrackingToolEntitiesDataSetBindingSource
            // 
            this.trackingTool6dbTrackingToolEntitiesDataSetBindingSource.DataSource = this._TrackingTool6_db_TrackingToolEntitiesDataSet;
            this.trackingTool6dbTrackingToolEntitiesDataSetBindingSource.Position = 0;
            // 
            // centrosDeCustoBindingSource
            // 
            this.centrosDeCustoBindingSource.DataMember = "CentrosDeCusto";
            this.centrosDeCustoBindingSource.DataSource = this.trackingTool6dbTrackingToolEntitiesDataSetBindingSource;
            // 
            // centrosDeCustoTableAdapter
            // 
            this.centrosDeCustoTableAdapter.ClearBeforeFill = true;
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
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigohiperfarmaDataGridViewTextBoxColumn
            // 
            this.codigohiperfarmaDataGridViewTextBoxColumn.DataPropertyName = "codigo_hiperfarma";
            this.codigohiperfarmaDataGridViewTextBoxColumn.HeaderText = "codigo_hiperfarma";
            this.codigohiperfarmaDataGridViewTextBoxColumn.Name = "codigohiperfarmaDataGridViewTextBoxColumn";
            this.codigohiperfarmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            this.saldoDataGridViewTextBoxColumn.HeaderText = "saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_listar_CDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_listar_CDC";
            this.Text = "Listar Centros de Custo";
            this.Load += new System.EventHandler(this.Frm_listar_CDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackingTool6dbTrackingToolEntitiesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centrosDeCustoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trackingTool6dbTrackingToolEntitiesDataSetBindingSource;
        private _TrackingTool6_db_TrackingToolEntitiesDataSet _TrackingTool6_db_TrackingToolEntitiesDataSet;
        private System.Windows.Forms.BindingSource centrosDeCustoBindingSource;
        private _TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.CentrosDeCustoTableAdapter centrosDeCustoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigohiperfarmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}