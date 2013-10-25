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
using Tracking.Controler;

namespace Tracking.View
{
    public partial class Frm_Tela_Login : Form
    {
        public Frm_Tela_Login()
        {
            InitializeComponent();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.usuario = TxtUsuario.Text.ToString();
            user.senha = TxtSenha.Text.ToString();

            if (TxtUsuario.Text == "admin" && TxtSenha.Text == "admin")
            {
                Frm_Main main = new Frm_Main();
                main.Show();
                this.Hide();
            }

            else
            {
                if (UsuariosDAO.Procurar_Usuario(user) == null)
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
                else
                {
                    Frm_Main main = new Frm_Main();
                    main.Show();
                    this.Hide();
                }
            }


        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
