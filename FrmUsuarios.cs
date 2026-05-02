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
    public partial class FrmUsuarios : Form
    {
        UsuarioBLL bll = new UsuarioBLL();
        RolBLL bllRol = new RolBLL();

        int idUsuario = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            EstiloDataGrid();
            CargarUsuarios();
            CargarRoles();
        }

        private void CargarRoles()
        {
            cbRol.DataSource = bllRol.Listar();
            cbRol.DisplayMember = "Nom_Rol";
            cbRol.ValueMember = "id_Rol";
        }
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = bll.Listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Completa los campos 😡");
                return;
            }

            if (idUsuario == 0)
            {
                // INSERTAR
                bll.Insertar(
                    txtNombre.Text,
                    txtEmail.Text,
                    txtTelefono.Text,
                    txtUsuario.Text,
                    txtClave.Text,
                    Convert.ToInt32(cbRol.SelectedValue)
                );

                MessageBox.Show("Usuario creado 💖");
            }
            else
            {
                // ACTUALIZAR
                bll.Actualizar(
                    idUsuario,
                    txtNombre.Text,
                    txtEmail.Text,
                    txtTelefono.Text,
                    Convert.ToInt32(cbRol.SelectedValue)
                );

                MessageBox.Show("Usuario actualizado 🔥");
            }

            Limpiar();
            CargarUsuarios();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id_Usuario"].Value);

                txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nom_Usuario"].Value.ToString();
                txtEmail.Text = dgvUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                txtTelefono.Text = dgvUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtClave.Text = dgvUsuarios.CurrentRow.Cells["Clave"].Value.ToString();

                cbRol.SelectedValue = dgvUsuarios.CurrentRow.Cells["id_Rol"].Value;

                btnGuardar.Text = "Actualizar 😏";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        
            if (idUsuario > 0)
            {
                bll.Eliminar(idUsuario);
                MessageBox.Show("Usuario eliminado 💔");

                Limpiar();
                CargarUsuarios();
            }
        
    }
        private void Limpiar()
        {
            idUsuario = 0;

            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtUsuario.Clear();
            txtClave.Clear();

            cbRol.SelectedIndex = -1;

            btnGuardar.Text = "Guardar 💾";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void EstiloDataGrid()
        {
            // Fondo general
            dgvUsuarios.BackgroundColor = Color.FromArgb(245, 245, 245); // gris claro

            // Bordes
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.GridColor = Color.LightGray;

            // Encabezado (Header)
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200); // gris medio
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas normales
            dgvUsuarios.DefaultCellStyle.BackColor = Color.White;
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.Black;

            // Selección (azul suave moderno)
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // azul claro
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas (efecto zebra suave)
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);

            // Ajustes extra
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
    }
}
