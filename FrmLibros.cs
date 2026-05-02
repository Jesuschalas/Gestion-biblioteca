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

    public partial class FrmLibros : Form

    {
        LibroBLL bll = new LibroBLL();
        AutorBLL bllAutor = new AutorBLL();
        GeneroBLL bllGenero = new GeneroBLL();
        UbicacionBLL bllUbicacion = new UbicacionBLL();

      
        int idLibro = 0;
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {


            CargarAutores();
            CargarGeneros();
            CargarUbicaciones();
            CargarLibros();
          
            cbAutor.DropDownStyle = ComboBoxStyle.DropDown;

            EstiloDataGrid();

            dgvLibros.Columns["id_Libro"].Visible = false;
            dgvLibros.Columns["id_Autor"].Visible = false;
            dgvLibros.Columns["id_Genero"].Visible = false;
            dgvLibros.Columns["id_Ubicacion"].Visible = false;
        }

        private void CargarLibros()
        {
            dgvLibros.DataSource = bll.Listar();
        }
        private void Limpiar()
        {
            idLibro = 0;

            txtTitulo.Clear();
            txtISBN.Clear();
            txtPaginas.Clear();
            txtStock.Clear();

            cbAutor.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            cbUbicacion.SelectedIndex = -1;

            btnGuardar.Text = "Guardar 💾";
        }
        private void CargarUbicaciones()
        {
            cbUbicacion.DataSource = bllUbicacion.Listar();
            cbUbicacion.DisplayMember = "UbicacionCompleta"; // 🔥 lo bonito
            cbUbicacion.ValueMember = "id_Ubicacion"; // 🔥 el ID real
        }

        private void CargarAutores()
        {
            cbAutor.DataSource = bllAutor.Listar();
            cbAutor.DisplayMember = "Nom_Autor";
            cbAutor.ValueMember = "id_Autor";
        }

        private void CargarGeneros()
        {
            cbGenero.DataSource = bllGenero.Listar();
            cbGenero.DisplayMember = "Nom_Genero";
            cbGenero.ValueMember = "id_Genero";

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int idAutor = Convert.ToInt32(cbAutor.SelectedValue);

            if (idLibro == 0)
            {
                // INSERTAR
                bll.Insertar(
                    txtTitulo.Text,
                    Convert.ToInt32(cbGenero.SelectedValue),
                    idAutor,
                    txtISBN.Text,
                    int.Parse(txtPaginas.Text),
                    Convert.ToInt32(cbUbicacion.SelectedValue),
                    int.Parse(txtStock.Text)
                );

                MessageBox.Show("Libro agregado 💖");
            }
            else
            {
                // ACTUALIZAR
                bll.Actualizar(
                    idLibro,
                    txtTitulo.Text,
                    int.Parse(txtStock.Text)
                );

                MessageBox.Show("Libro actualizado 🔥");
            }

            Limpiar();
            CargarLibros();


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
        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idLibro = Convert.ToInt32(dgvLibros.CurrentRow.Cells["id_Libro"].Value);

                txtTitulo.Text = dgvLibros.CurrentRow.Cells["Titulo_Libro"].Value.ToString();
                txtISBN.Text = dgvLibros.CurrentRow.Cells["Isbn"].Value.ToString();
                txtPaginas.Text = dgvLibros.CurrentRow.Cells["Cant_Paginas"].Value.ToString();
                txtStock.Text = dgvLibros.CurrentRow.Cells["Stock"].Value.ToString();

                // 🔥 AQUÍ ESTÁ LA CLAVE
                cbAutor.SelectedValue = dgvLibros.CurrentRow.Cells["id_Autor"].Value;
                cbGenero.SelectedValue = dgvLibros.CurrentRow.Cells["id_Genero"].Value;
                cbUbicacion.SelectedValue = dgvLibros.CurrentRow.Cells["id_Ubicacion"].Value;

                btnGuardar.Text = "Actualizar 😏";
            
        }
        }

 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idLibro > 0)
            {
                bll.Eliminar(idLibro);
                MessageBox.Show("Libro eliminado 💔");

                Limpiar();
                CargarLibros();
            }
            
            
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                CargarLibros();
            else
                dgvLibros.DataSource = bll.Buscar(txtBuscar.Text);
        }
    }
}
