using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaBiblioteca.FrmLogin;

namespace SistemaBiblioteca
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            lblUsuario.Text = "Bienvenido: " + Sesion.Nombre;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            new FrmLogin().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmLibros().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormAutores ().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FrmLector().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmPrestamos().ShowDialog();
        }
    }

}
