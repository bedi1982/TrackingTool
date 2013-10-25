using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tracking.Tool;
using Tracking.Model;
using System.Windows.Forms;

namespace Tracking.Controler
{
    class UsuariosDAO
    {
        public static Usuarios Procurar_Usuario(Usuarios user)
        {
            banco db = SingletonObjectContext.Instance.Context;

            foreach (Usuarios x in db.Usuarios)
            {
                
                if (x.usuario.Equals(user.usuario.ToString()) && x.senha.Equals(user.senha.ToString()))
                {
                    return x;
                }
            }
            return null;
        }


    }
}
