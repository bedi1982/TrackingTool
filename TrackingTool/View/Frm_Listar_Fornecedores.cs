using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrackingTool6.View
{
    public partial class Frm_Listar_Fornecedores : Form
    {
        public Frm_Listar_Fornecedores()
        {
            InitializeComponent();
        }

        private void Frm_Lista_Fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TrackingTool6_db_TrackingToolEntitiesDataSet1.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this._TrackingTool6_db_TrackingToolEntitiesDataSet1.Fornecedor);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lista_apenas_os_com_status_não_falseToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.fornecedorTableAdapter.Lista_apenas_os_com_status_não_false(this._TrackingTool6_db_TrackingToolEntitiesDataSet1.Fornecedor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lista_removidosToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.fornecedorTableAdapter.lista_removidos(this._TrackingTool6_db_TrackingToolEntitiesDataSet1.Fornecedor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lista_apenas_os_com_status_não_falseToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.fornecedorTableAdapter.Lista_apenas_os_com_status_não_false(this._TrackingTool6_db_TrackingToolEntitiesDataSet1.Fornecedor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
