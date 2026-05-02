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
    public partial class FormAutores : Form
    {
        AutorBLL bll = new AutorBLL();
        int idAutor = 0;
        public FormAutores()
        {
            InitializeComponent();
        }

        private void FormAutores_Load(object sender, EventArgs e)
        {
            EstiloDataGrid();
                
            CargarAutores();
        }

        private void CargarAutores()
        {
            dgvAutores.DataSource = bll.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text == "")
            {
                MessageBox.Show("Escribe el nombre 😡");
                return;
            }

            if (idAutor == 0)
            {
                bll.InsertarAutor(txtAutor.Text);
                MessageBox.Show("Autor agregado 💖");
            }
            else
            {
                bll.ActualizarAutor(idAutor, txtAutor.Text);
                MessageBox.Show("Autor actualizado 🔥");
            }

            Limpiar();
            CargarAutores();
        }

        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idAutor = Convert.ToInt32(dgvAutores.CurrentRow.Cells["id_Autor"].Value);
                txtAutor.Text = dgvAutores.CurrentRow.Cells["Nom_Autor"].Value.ToString();

                btnGuardar.Text = "Actualizar 😏";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idAutor > 0)
            {
                bll.EliminarAutor(idAutor);
                MessageBox.Show("Autor eliminado 💔");

                Limpiar();
                CargarAutores();
            }
        }
        private void EstiloDataGrid()
        {
            // Fondo general
            dgvAutores.BackgroundColor = Color.FromArgb(245, 245, 245); // gris claro

            // Bordes
            dgvAutores.BorderStyle = BorderStyle.None;
            dgvAutores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAutores.GridColor = Color.LightGray;

            // Encabezado (Header)
            dgvAutores.EnableHeadersVisualStyles = false;
            dgvAutores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAutores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200); // gris medio
            dgvAutores.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvAutores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas normales
            dgvAutores.DefaultCellStyle.BackColor = Color.White;
            dgvAutores.DefaultCellStyle.ForeColor = Color.Black;

            // Selección (azul suave moderno)
            dgvAutores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // azul claro
            dgvAutores.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas (efecto zebra suave)
            dgvAutores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);

            // Ajustes extra
            dgvAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutores.ReadOnly = true;
            dgvAutores.AllowUserToAddRows = false;
            dgvAutores.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        private void Limpiar()
        {
            txtAutor.Clear();
            idAutor = 0;
            btnGuardar.Text = "Guardar 😎";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
             
        }
    }
}
