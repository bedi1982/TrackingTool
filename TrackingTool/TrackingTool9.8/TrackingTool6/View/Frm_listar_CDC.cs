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
    public partial class Frm_listar_CDC : Form
    {
        public Frm_listar_CDC()
        {
            InitializeComponent();
        }

        private void Frm_listar_CDC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_TrackingTool6_db_TrackingToolEntitiesDataSet.CentrosDeCusto' table. You can move, or remove it, as needed.
            this.centrosDeCustoTableAdapter.Fill(this._TrackingTool6_db_TrackingToolEntitiesDataSet.CentrosDeCusto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
