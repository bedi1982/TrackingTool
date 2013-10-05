namespace TrackingTool6.View
{
    partial class Frm_Listar_Lojas
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
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lojasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._TrackingTool6_db_TrackingToolEntitiesDataSet = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSet();
            this.lojasTableAdapter = new TrackingTool6._TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.LojasTableAdapter();
            this.BtnOK = new System.Windows.Forms.Button();
            this.lojas_com_Saldo_ZeradoToolStrip = new System.Windows.Forms.ToolStrip();
            this.lojas_com_Saldo_ZeradoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lojas_com_Saldo_PositivoToolStrip = new System.Windows.Forms.ToolStrip();
            this.lojas_com_Saldo_PositivoToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).BeginInit();
            this.lojas_com_Saldo_ZeradoToolStrip.SuspendLayout();
            this.lojas_com_Saldo_PositivoToolStrip.SuspendLayout();
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
            this.telefoneDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lojasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 350);
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
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
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
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "codigo_hiperfarma";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "codigo_hiperfarma";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // lojasBindingSource
            // 
            this.lojasBindingSource.DataMember = "Lojas";
            this.lojasBindingSource.DataSource = this._TrackingTool6_db_TrackingToolEntitiesDataSet;
            // 
            // _TrackingTool6_db_TrackingToolEntitiesDataSet
            // 
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.DataSetName = "_TrackingTool6_db_TrackingToolEntitiesDataSet";
            this._TrackingTool6_db_TrackingToolEntitiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lojasTableAdapter
            // 
            this.lojasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(693, 409);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lojas_com_Saldo_ZeradoToolStrip
            // 
            this.lojas_com_Saldo_ZeradoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojas_com_Saldo_ZeradoToolStripButton});
            this.lojas_com_Saldo_ZeradoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.lojas_com_Saldo_ZeradoToolStrip.Name = "lojas_com_Saldo_ZeradoToolStrip";
            this.lojas_com_Saldo_ZeradoToolStrip.Size = new System.Drawing.Size(788, 25);
            this.lojas_com_Saldo_ZeradoToolStrip.TabIndex = 2;
            this.lojas_com_Saldo_ZeradoToolStrip.Text = "lojas_com_Saldo_ZeradoToolStrip";
            // 
            // lojas_com_Saldo_ZeradoToolStripButton
            // 
            this.lojas_com_Saldo_ZeradoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lojas_com_Saldo_ZeradoToolStripButton.Name = "lojas_com_Saldo_ZeradoToolStripButton";
            this.lojas_com_Saldo_ZeradoToolStripButton.Size = new System.Drawing.Size(225, 22);
            this.lojas_com_Saldo_ZeradoToolStripButton.Text = "Clique para listas as  Lojas com Saldo Zerado";
            this.lojas_com_Saldo_ZeradoToolStripButton.Click += new System.EventHandler(this.lojas_com_Saldo_ZeradoToolStripButton_Click);
            // 
            // lojas_com_Saldo_PositivoToolStrip
            // 
            this.lojas_com_Saldo_PositivoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lojas_com_Saldo_PositivoToolStripButton});
            this.lojas_com_Saldo_PositivoToolStrip.Location = new System.Drawing.Point(0, 25);
            this.lojas_com_Saldo_PositivoToolStrip.Name = "lojas_com_Saldo_PositivoToolStrip";
            this.lojas_com_Saldo_PositivoToolStrip.Size = new System.Drawing.Size(788, 25);
            this.lojas_com_Saldo_PositivoToolStrip.TabIndex = 3;
            this.lojas_com_Saldo_PositivoToolStrip.Text = "lojas_com_Saldo_PositivoToolStrip";
            // 
            // lojas_com_Saldo_PositivoToolStripButton
            // 
            this.lojas_com_Saldo_PositivoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lojas_com_Saldo_PositivoToolStripButton.Name = "lojas_com_Saldo_PositivoToolStripButton";
            this.lojas_com_Saldo_PositivoToolStripButton.Size = new System.Drawing.Size(225, 22);
            this.lojas_com_Saldo_PositivoToolStripButton.Text = "Clique para listas as Lojas com Saldo Positivo";
            this.lojas_com_Saldo_PositivoToolStripButton.Click += new System.EventHandler(this.lojas_com_Saldo_PositivoToolStripButton_Click);
            // 
            // Frm_Listar_Lojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 452);
            this.Controls.Add(this.lojas_com_Saldo_PositivoToolStrip);
            this.Controls.Add(this.lojas_com_Saldo_ZeradoToolStrip);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_Listar_Lojas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Lojas";
            this.Load += new System.EventHandler(this.Frm_Listar_Lojas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._TrackingTool6_db_TrackingToolEntitiesDataSet)).EndInit();
            this.lojas_com_Saldo_ZeradoToolStrip.ResumeLayout(false);
            this.lojas_com_Saldo_ZeradoToolStrip.PerformLayout();
            this.lojas_com_Saldo_PositivoToolStrip.ResumeLayout(false);
            this.lojas_com_Saldo_PositivoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _TrackingTool6_db_TrackingToolEntitiesDataSet _TrackingTool6_db_TrackingToolEntitiesDataSet;
        private System.Windows.Forms.BindingSource lojasBindingSource;
        private _TrackingTool6_db_TrackingToolEntitiesDataSetTableAdapters.LojasTableAdapter lojasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.ToolStrip lojas_com_Saldo_ZeradoToolStrip;
        private System.Windows.Forms.ToolStripButton lojas_com_Saldo_ZeradoToolStripButton;
        private System.Windows.Forms.ToolStrip lojas_com_Saldo_PositivoToolStrip;
        private System.Windows.Forms.ToolStripButton lojas_com_Saldo_PositivoToolStripButton;
    }
}