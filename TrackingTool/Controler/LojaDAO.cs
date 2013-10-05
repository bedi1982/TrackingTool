using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackingTool6.db;
using TrackingTool6.Model;
using System.Windows.Forms;

namespace TrackingTool6.Controler
{
    class LojaDAO
    {

        public static bool AdicionaLojaEF(Loja loja)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Lojas.Add(loja);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Nao adicionou");
            }

            MessageBox.Show("Adicionado ao Banco");
            return true;
        }

        public static Loja Procurar_Loja_por_nome(Loja loja)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

            foreach (Loja x in db.Lojas)
            {
                // TODO Está case senstive
                if (x.nome.ToUpper().Contains(loja.nome.ToUpper()))
                {
                    return x;
                }
            }
            return null;
        }
        public static Loja Procurar_Loja_por_numero(Loja loja)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;
            foreach (Loja x in db.Lojas)
            {
                if(x.codigo_hiperfarma.Equals(loja.codigo_hiperfarma)){
                return x;
                }
            }

            return null;

        }

        //A função de remover não remove, apenas inativa//
        public static Loja Remove_Loja(Loja loja)
        {
            TrackingToolEntities db = SingletonObjectContext.Instance.Context;

            foreach (Loja x in db.Lojas)
            {
                if (x.id.Equals(loja.id))
                {
                    loja = x;
                    break;
                }
            }
            loja.status = false;
            db.SaveChanges();
            MessageBox.Show("Loja Removida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }
}
