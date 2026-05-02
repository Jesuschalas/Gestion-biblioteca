using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class FrmPrestamos : Form
    {
        PrestamoBLL bll = new PrestamoBLL();
        DataTable detalle = new DataTable();

        int idPrestamo = 0;
        int idUsuario = 1;

        int idLibro = 0;
        int idLector = 0;

        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)

        {

            EstiloDataGrids();
            EstiloDataGrid();
            detalle.Columns.Add("idLibro");
            detalle.Columns.Add("Libro");
            detalle.Columns.Add("Cantidad");

            dgvDetalle.DataSource = detalle;
            dgvDetalle.Columns["idLibro"].Visible = false;
            
        }

        // 🔍 BUSCAR LECTOR
        private void btnBuscarLector_Click(object sender, EventArgs e)
        {
            FrmBuscarLector frm = new FrmBuscarLector();
            frm.ShowDialog();

            if (frm.IdLector != 0)
            {
                idLector = frm.IdLector;
                txtLector.Text = frm.NombreLector;
            }
        }

        // 🔍 BUSCAR LIBRO
        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            FrmBuscarLibro frm = new FrmBuscarLibro();
            frm.ShowDialog();

            if (frm.IdLibro != 0)
            {
                idLibro = frm.IdLibro;
                txtLibro.Text = frm.NombreLibro;
                txtCantidad.Focus();
            }
        }

        // ➕ AGREGAR LIBRO
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese cantidad");
                return;
            }

            foreach (DataRow row in detalle.Rows)
            {
                if (Convert.ToInt32(row["idLibro"]) == idLibro)
                {
                    MessageBox.Show("Libro ya agregado");
                    return;
                }
            }

            DataRow fila = detalle.NewRow();

            fila["idLibro"] = idLibro;
            fila["Libro"] = txtLibro.Text;
            fila["Cantidad"] = txtCantidad.Text;

            detalle.Rows.Add(fila);
        }
        private void EstiloDataGrids()
        {
            // Fondo general
            dgvDetalle.BackgroundColor = Color.FromArgb(245, 245, 245); // gris claro

            // Bordes
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetalle.GridColor = Color.LightGray;

            // Encabezado (Header)
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200); // gris medio
            dgvDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvDetalle.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas normales
            dgvDetalle.DefaultCellStyle.BackColor = Color.White;
            dgvDetalle.DefaultCellStyle.ForeColor = Color.Black;

            // Selección (azul suave moderno)
            dgvDetalle.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // azul claro
            dgvDetalle.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas (efecto zebra suave)
            dgvDetalle.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);

            // Ajustes extra
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.ReadOnly = true;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        private void EstiloDataGrid()
        {
            // Fondo general
            dgvReporte.BackgroundColor = Color.FromArgb(245, 245, 245); // gris claro

            // Bordes
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporte.GridColor = Color.LightGray;

            // Encabezado (Header)
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReporte.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200); // gris medio
            dgvReporte.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvReporte.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas normales
            dgvReporte.DefaultCellStyle.BackColor = Color.White;
            dgvReporte.DefaultCellStyle.ForeColor = Color.Black;

            // Selección (azul suave moderno)
            dgvReporte.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 216, 230); // azul claro
            dgvReporte.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Filas alternas (efecto zebra suave)
            dgvReporte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);

            // Ajustes extra
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.ReadOnly = true;
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // ❌ QUITAR
       
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
            }
        }

        // 💾 GUARDAR
        private void btnGuardarPrestamos_Click(object sender, EventArgs e)
        {


            try
            {
                if (idLector == 0)
                {
                    MessageBox.Show("Seleccione un lector");
                    return;
                }

                if (detalle.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue libros");
                    return;
                }

                bll.Registrar(idLector, idUsuario, detalle);

                MessageBox.Show("Préstamo guardado 🔥📚");

                // limpiar todo
                detalle.Clear();
                txtLector.Clear();
                txtLibro.Clear();
                txtCantidad.Clear();

                idLector = 0;
                idLibro = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvReporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReporte.CurrentRow != null)
            {
                idPrestamo = Convert.ToInt32(dgvReporte.CurrentRow.Cells["id_Prestamo"].Value);
            }
        }
        // 🔄 DEVOLVER
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (idPrestamo != 0)
            {
                bll.Devolver(idPrestamo);
                MessageBox.Show("Libros devueltos 🔄");
            }
            else
            {
                MessageBox.Show("Seleccione un préstamo");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            dgvReporte.DataSource = bll.ListarPrestamos();                                                                                                                                       
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {


            int idPrestamo = Convert.ToInt32(
        dgvReporte.CurrentRow.Cells["id_Prestamo"].Value
    );

            PrestamoBLL bl = new PrestamoBLL();
            DataTable dt = bl.ObtenerReporte(idPrestamo);

            FrmReportePrestamos frm = new FrmReportePrestamos();
            frm.dtReporte = dt;
            frm.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
