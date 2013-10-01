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
            // TODO: This line of code loads data into the '_TrackingTool6_db_TrackingToolEntitiesDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this._TrackingTool6_db_TrackingToolEntitiesDataSet.Fornecedor);

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
