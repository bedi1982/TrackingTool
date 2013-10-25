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
    public partial class Frm_ListarLojasContas : Form
    {
        public Frm_ListarLojasContas()
        {
            InitializeComponent();
            
            banco db = SingletonObjectContext.Instance.Context;
            DGFornecedores.Rows.Clear();
            foreach (Loja x in db.Lojas)
            {
                if (x.status == true)//Os inativos não queremos ver:
                {
                    DGFornecedores.Rows.Add(x.codigo_hiperfarma, x.nome);
                }
            }
        }

        
    }
}
