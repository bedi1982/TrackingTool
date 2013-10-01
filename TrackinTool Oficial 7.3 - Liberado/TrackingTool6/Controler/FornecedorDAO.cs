using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using TrackingTool6.Model;
using System.Windows.Forms;
using TrackingTool6.db;

namespace TrackingTool6.Controler
{
    class FornecedorDAO
    {
        public static bool AdicionaFornecedorEF(Fornecedor fornecedor)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Fornecedores.Add(fornecedor);
                db.SaveChanges();
                MessageBox.Show("Adicionado ao Banco");
            }
            catch
            {
                MessageBox.Show("Nao adicionou");
            }
            return true;
        }

        public static void ListaFornecedoresEF()
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            
            foreach (Fornecedor x in db.Fornecedores)
            {
                MessageBox.Show(x.nome);
            }
        }

        public static IOrderedEnumerable<Fornecedor> BuscaTodosFornecedores()
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                IOrderedEnumerable<Fornecedor> forn = db.Fornecedores.ToList().OrderBy(x => x.nome);
                return forn;
            }
            catch
            {
                return null;
            }
        }

        public static Fornecedor Procurar_Fornecedor_por_id(Fornecedor fornecedor)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            
            foreach (Fornecedor x in db.Fornecedores)
            {
                if (x.id.Equals(fornecedor.id))
                {
                    return x;
                }
            }
            return null;
        }

        public static Fornecedor Procurar_Fornecedor_por_nome(Fornecedor fornecedor)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

            foreach (Fornecedor x in db.Fornecedores)
            {
                // TODO Está case senstive
                if (x.nome.ToUpper().Contains(fornecedor.nome.ToUpper()))    
                {
                    return x;
                }
            }
            return null;
        }
        
        public static Fornecedor Remove_Fornecedor(Fornecedor fornecedor)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

            foreach (Fornecedor x in db.Fornecedores)
            {
                if (x.id.Equals(fornecedor.id))
                {
                    fornecedor = x;
                    break;
                }
            }

            db.Fornecedores.Remove(fornecedor);
            db.SaveChanges();
            MessageBox.Show("Fornecedor Removido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

    }
}
