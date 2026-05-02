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
    public partial class FrmBibliotecario : Form
    {
        public FrmBibliotecario()
        {
            InitializeComponent();
            lblUsuario.Text = "Bienvenido: " + Sesion.Nombre;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            new FormAutores().ShowDialog(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FrmPrestamos().ShowDialog();
        }
    }
}
