using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Tracking.Model;
using System.Windows.Forms;
using Tracking.Tool;

namespace Tracking.Controler
{
    class FornecedorDAO
    {
        public static bool AdicionaFornecedorEF(Fornecedor fornecedor)
        {
            banco db = SingletonObjectContext.Instance.Context;
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
            banco db = SingletonObjectContext.Instance.Context;
            
            foreach (Fornecedor x in db.Fornecedores)
            {
                MessageBox.Show(x.nome);
            }
        }

        public static Fornecedor Procurar_Fornecedor_por_codigo_hiperfarma(Fornecedor fornecedor)
        {
            banco db = SingletonObjectContext.Instance.Context;
            
            Fornecedor encontrado = new Fornecedor();
            encontrado = null;
            try
            {
                foreach (Fornecedor x in db.Fornecedores)
                {
                    if (x.codigo_hiperfarma.Equals(fornecedor.codigo_hiperfarma) && x.status == true)
                    {
                        encontrado = x;
                        break;
                    }
                }

                if (encontrado != null)
                {
                    return encontrado;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
            
        

        public static Fornecedor Procurar_Fornecedor_por_nome(Fornecedor fornecedor)
        {
            banco db = SingletonObjectContext.Instance.Context;

            foreach (Fornecedor x in db.Fornecedores)
            {
                // TODO Está case senstive
                if (x.nome.ToUpper().Contains(fornecedor.nome.ToUpper()) && x.status == true)    
                {
                    return x;
                }
            }
            return null;
        }
        
        //A função de remover não remove, apenas inativa//
        public static void Remove_Fornecedor(Fornecedor fornecedor)
        {
            banco db = SingletonObjectContext.Instance.Context;

            foreach (Fornecedor x in db.Fornecedores)
            {
                if (x.id.Equals(fornecedor.id))
                {
                    fornecedor.status = false;
                    
                    break;
                }
            }
            db.SaveChanges();
            MessageBox.Show("Fornecedor Removido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        public static void Editar_Fornecedor(Fornecedor fornecedor)
        {
            banco db = SingletonObjectContext.Instance.Context;
            try
            {
                db.SaveChanges();
            }

            catch
            {
                MessageBox.Show("Erro");
            }
        }


    }
}
