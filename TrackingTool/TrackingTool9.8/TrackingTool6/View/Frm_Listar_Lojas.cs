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
    public partial class Frm_Listar_Lojas : Form
    {
        public Frm_Listar_Lojas()
        {
            InitializeComponent();
        }

        private void Frm_Listar_Lojas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TrackingTool6_db_TrackingToolEntitiesDataSet.Lojas' table. You can move, or remove it, as needed.
            this.lojasTableAdapter.Fill(this._TrackingTool6_db_TrackingToolEntitiesDataSet.Lojas);

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lojas_com_Saldo_ZeradoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lojasTableAdapter.Lojas_com_Saldo_Zerado(this._TrackingTool6_db_TrackingToolEntitiesDataSet.Lojas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lojas_com_Saldo_PositivoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lojasTableAdapter.Lojas_com_Saldo_Positivo(this._TrackingTool6_db_TrackingToolEntitiesDataSet.Lojas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lojas_com_Saldo_PositivoToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.lojasTableAdapter.Lojas_com_Saldo_Positivo(this._TrackingTool6_db_TrackingToolEntitiesDataSet.Lojas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
