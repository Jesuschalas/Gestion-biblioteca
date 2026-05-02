using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmBuscarLibro : Form
    {
        LibroBLL bll = new LibroBLL();

        public int IdLibro { get; set; }
        public string NombreLibro { get; set; }

        public FrmBuscarLibro()
        {
            InitializeComponent();
        }

        private void FrmBuscarLibro_Load(object sender, EventArgs e)
        {
            EstiloDataGrid();
            CargarLibros();
        }

        private void CargarLibros()
        {
            dgvLibros.DataSource = bll.Mostrar();

            dgvLibros.Columns["id_Libro"].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvLibros.DataSource = bll.Buscar(txtBuscar.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarLibro();
        }

        private void EstiloDataGrid()
        {
            // Fondo general
            dgvLibros.BackgroundColor = Color.FromArgb(245, 245, 245); // gris claro

            // Bordes
            dgvLibros.BorderStyle = BorderStyle.None;
            dgvLibros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLibros.GridColor = Color.LightGray;

            // Encabezado (Header)
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLibros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200); // gris medio
            dgvLibros.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvLibros.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas normales
            dgvLibros.DefaultCellStyle.BackColor = Color.White;
            dgvLibros.DefaultCellStyle.ForeColor = Color.Black;

            // Selección (azul suave moderno)
            dgvLibros.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // azul claro
            dgvLibros.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas (efecto zebra suave)
            dgvLibros.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);

            // Ajustes extra
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.ReadOnly = true;
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarLibro();
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvLibros.Rows.Count > 0)
            {
                SeleccionarLibro();
            }
        }
        private void SeleccionarLibro()
        {
            if (dgvLibros.CurrentRow != null)
            {
                IdLibro = Convert.ToInt32(dgvLibros.CurrentRow.Cells["id_Libro"].Value);
                NombreLibro = dgvLibros.CurrentRow.Cells["Titulo_Libro"].Value.ToString();

                this.Close();
            }
        }
    }
}