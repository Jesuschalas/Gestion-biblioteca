using Capanegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmLogin : Form
    {

        UsuarioBLL bll = new UsuarioBLL();

        public FrmLogin()
        {
            InitializeComponent();
        }

        public static class Sesion
        {
            public static int IdUsuario;
            public static string Nombre;
            public static string Rol;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Completa los campos");
                return;
            }
            DataTable dt = bll.Login(txtUsuario.Text, txtClave.Text);

            if (dt.Rows.Count > 0)
            {
                Sesion.IdUsuario = Convert.ToInt32(dt.Rows[0]["id_Usuario"]);
                Sesion.Nombre = dt.Rows[0]["Nom_Usuario"].ToString();
                Sesion.Rol = dt.Rows[0]["Nom_Rol"].ToString();

                this.Hide();

                if (Sesion.Rol == "Administrador")
                    new FrmAdmin().Show();
                else if (Sesion.Rol == "Bibliotecario")
                    new FrmBibliotecario().Show();
                
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos");
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmVisitante().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
