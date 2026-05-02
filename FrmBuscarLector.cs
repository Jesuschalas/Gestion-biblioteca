using Capanegocios;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmBuscarLector : Form
    {
        LectorBLL bll = new LectorBLL();

        public int IdLector { get; set; }
        public string NombreLector { get; set; }

        public FrmBuscarLector()
        {
            InitializeComponent();
        }

        private void FrmBuscarLector_Load(object sender, EventArgs e)

        {
            EstiloDataGrid();
            CargarLectores();

        }

        private void CargarLectores()
        {
            dgvLectores.DataSource = bll.Mostrar();

            dgvLectores.Columns["id_Lector"].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvLectores.DataSource = bll.Buscar(txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarLector();
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvLectores.Rows.Count > 0)
            {
                SeleccionarLector();
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
        private void dgvLectores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarLector();
        }

        private void SeleccionarLector()
        {
            if (dgvLectores.CurrentRow != null)
            {
                IdLector = Convert.ToInt32(dgvLectores.CurrentRow.Cells["id_Lector"].Value);
                NombreLector = dgvLectores.CurrentRow.Cells["Nom_Lector"].Value.ToString();

                this.Close();
            }
        }
    }
}