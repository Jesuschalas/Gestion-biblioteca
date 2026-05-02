using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmVisitante : Form
    {
        LibroBLL bll = new LibroBLL();
        public FrmVisitante()
        {
            InitializeComponent();
        }

        private void FrmVisitante_Load(object sender, EventArgs e)
        {
            CargarLibros();
                EstiloDataGrid();

            dgvLibros.Columns["id_Libro"].Visible = false;
            dgvLibros.Columns["id_Autor"].Visible = false;
            dgvLibros.Columns["id_Genero"].Visible = false;
            dgvLibros.Columns["id_Ubicacion"].Visible = false;
            dgvLibros.Columns["Isbn"].Visible = false;

            // ✏️ Renombrar columnas
            dgvLibros.Columns["Titulo_Libro"].HeaderText = "Título";
            dgvLibros.Columns["Nom_Autor"].HeaderText = "Autor";
            dgvLibros.Columns["Nom_Genero"].HeaderText = "Género";
            dgvLibros.Columns["Cant_Paginas"].HeaderText = "Páginas";
            dgvLibros.Columns["Stock"].HeaderText = "Stock";

            // 📏 Tamaños (para que no se vea apretado)
            dgvLibros.Columns["Titulo_Libro"].FillWeight = 180;
            dgvLibros.Columns["Nom_Autor"].FillWeight = 120;
            dgvLibros.Columns["Nom_Genero"].FillWeight = 100;
            dgvLibros.Columns["Cant_Paginas"].FillWeight = 70;
            dgvLibros.Columns["Stock"].FillWeight = 60;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLibros.Columns["Cant_Paginas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void dgvLibros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLibros.Columns[e.ColumnIndex].Name == "Stock")
            {
                if (e.Value != null && Convert.ToInt32(e.Value) <= 2)
                {
                    dgvLibros.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230);
                }
            }
        }
        private void CargarLibros()
        {
            dgvLibros.DataSource = bll.Listar();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                CargarLibros();
            else
                dgvLibros.DataSource = bll.Buscar(txtBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogin().Show();
        }
    }
}
