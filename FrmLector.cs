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
    public partial class FrmLector : Form
    {
        LectorBLL bll = new LectorBLL();
        int idLector = 0;
        public FrmLector()
        {
            InitializeComponent();
        }

        private void FrmLector_Load(object sender, EventArgs e)
        {
            CargarLectores();
        }
        public void CargarLectores()
        {
            EstiloDataGrid();
            dgvLectores.DataSource = bll.Listar();
            dgvLectores.Columns["id_Lector"].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvLectores.DataSource = bll.Buscar(txtBuscar.Text);
        }

        private void dgvLectores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLectores.Rows[e.RowIndex];

                idLector = Convert.ToInt32(fila.Cells["id_Lector"].Value);
                txtNombre.Text = fila.Cells["Nom_Lector"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direc_Lector"].Value.ToString();
                txtTelefono.Text = fila.Cells["Tel_Lector"].Value.ToString();
                txtEmail.Text = fila.Cells["Email_Lector"].Value.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idLector == 0)
            {
                // INSERTAR
                bll.Insertar(
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtEmail.Text
                );

                MessageBox.Show("Lector agregado 💖");
            }
            else
            {
                // ACTUALIZAR
                bll.Actualizar(
                    idLector,
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtEmail.Text
                );

                MessageBox.Show("Lector actualizado 🔥");
            }

            Limpiar();
            CargarLectores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idLector != 0)
            {
                bll.Eliminar(idLector);
                MessageBox.Show("Lector eliminado");

                Limpiar();
                CargarLectores();
            }
        }

        private void EstiloDataGrid()
        {
            // Fondo general
            dgvLectores.BackgroundColor = Color.FromArgb(245, 245, 245); // gris claro

            // Bordes
            dgvLectores.BorderStyle = BorderStyle.None;
            dgvLectores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLectores.GridColor = Color.LightGray;

            // Encabezado (Header)
            dgvLectores.EnableHeadersVisualStyles = false;
                dgvLectores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLectores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200); // gris medio
            dgvLectores.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvLectores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas normales
            dgvLectores.DefaultCellStyle.BackColor = Color.White;
            dgvLectores.DefaultCellStyle.ForeColor = Color.Black;

            // Selección (azul suave moderno)
            dgvLectores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // azul claro
            dgvLectores.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas (efecto zebra suave)
            dgvLectores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);

            // Ajustes extra
            dgvLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLectores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLectores.ReadOnly = true;
            dgvLectores.AllowUserToAddRows = false;
            dgvLectores.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            idLector = 0;
        }
    }
}
