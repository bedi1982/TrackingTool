using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tracking.Tool;
using Tracking.Model;

namespace Tracking.View
{
    public partial class Frm_ListarFornContas : Form
    {
        public Frm_ListarFornContas()
        {
            InitializeComponent();

            banco db = SingletonObjectContext.Instance.Context;
            DGFornecedores.Rows.Clear();
            foreach (Fornecedor x in db.Fornecedores)
            {
                if (x.status == true)
                {
                    DGFornecedores.Rows.Add(x.codigo_hiperfarma, x.nome);
                }
            }
        }

        
    }
}
