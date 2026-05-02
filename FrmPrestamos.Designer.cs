namespace SistemaBiblioteca
{
    partial class FrmPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamos));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtLibro = new System.Windows.Forms.TextBox();
            this.txtLector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnGuardarPrestamos = new System.Windows.Forms.Button();
            this.btnBucarLector = new System.Windows.Forms.Button();
            this.btnBucarLibro = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(549, 617);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 61);
            this.btnNuevo.TabIndex = 71;
            this.btnNuevo.Text = "Salir";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(818, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 70;
            this.label3.Text = "Datos Reporte";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(673, 51);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(90, 19);
            this.Cantidad.TabIndex = 67;
            this.Cantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(674, 72);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(108, 24);
            this.txtCantidad.TabIndex = 66;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(48, 123);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(930, 150);
            this.dgvDetalle.TabIndex = 63;
            // 
            // txtLibro
            // 
            this.txtLibro.Location = new System.Drawing.Point(48, 72);
            this.txtLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLibro.Name = "txtLibro";
            this.txtLibro.Size = new System.Drawing.Size(143, 24);
            this.txtLibro.TabIndex = 76;
            // 
            // txtLector
            // 
            this.txtLector.Location = new System.Drawing.Point(387, 72);
            this.txtLector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLector.Name = "txtLector";
            this.txtLector.Size = new System.Drawing.Size(123, 24);
            this.txtLector.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Libro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 79;
            this.label4.Text = "Lector:";
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(48, 415);
            this.dgvReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 24;
            this.dgvReporte.Size = new System.Drawing.Size(930, 142);
            this.dgvReporte.TabIndex = 80;
            this.dgvReporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporte_CellClick);
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnVerReporte.Image")));
            this.btnVerReporte.Location = new System.Drawing.Point(225, 617);
            this.btnVerReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(123, 61);
            this.btnVerReporte.TabIndex = 81;
            this.btnVerReporte.Text = "Buscar Reportes";
            this.btnVerReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(58, 617);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(123, 61);
            this.btnReporte.TabIndex = 82;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(387, 617);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(123, 61);
            this.btnDevolver.TabIndex = 72;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregarLibro.ForeColor = System.Drawing.Color.MintCream;
            this.btnAgregarLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLibro.Image")));
            this.btnAgregarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarLibro.Location = new System.Drawing.Point(822, 59);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(144, 39);
            this.btnAgregarLibro.TabIndex = 64;
            this.btnAgregarLibro.Text = "       Agregar libro";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnGuardarPrestamos
            // 
            this.btnGuardarPrestamos.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardarPrestamos.ForeColor = System.Drawing.Color.MintCream;
            this.btnGuardarPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPrestamos.Image")));
            this.btnGuardarPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPrestamos.Location = new System.Drawing.Point(48, 307);
            this.btnGuardarPrestamos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarPrestamos.Name = "btnGuardarPrestamos";
            this.btnGuardarPrestamos.Size = new System.Drawing.Size(133, 74);
            this.btnGuardarPrestamos.TabIndex = 65;
            this.btnGuardarPrestamos.Text = "Guardar Prestamos";
            this.btnGuardarPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPrestamos.UseVisualStyleBackColor = false;
            this.btnGuardarPrestamos.Click += new System.EventHandler(this.btnGuardarPrestamos_Click);
            // 
            // btnBucarLector
            // 
            this.btnBucarLector.Image = ((System.Drawing.Image)(resources.GetObject("btnBucarLector.Image")));
            this.btnBucarLector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBucarLector.Location = new System.Drawing.Point(516, 55);
            this.btnBucarLector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBucarLector.Name = "btnBucarLector";
            this.btnBucarLector.Size = new System.Drawing.Size(137, 41);
            this.btnBucarLector.TabIndex = 74;
            this.btnBucarLector.Text = "     Bucar Lector";
            this.btnBucarLector.UseVisualStyleBackColor = true;
            this.btnBucarLector.Click += new System.EventHandler(this.btnBuscarLector_Click);
            // 
            // btnBucarLibro
            // 
            this.btnBucarLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnBucarLibro.Image")));
            this.btnBucarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBucarLibro.Location = new System.Drawing.Point(197, 53);
            this.btnBucarLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBucarLibro.Name = "btnBucarLibro";
            this.btnBucarLibro.Size = new System.Drawing.Size(137, 43);
            this.btnBucarLibro.TabIndex = 75;
            this.btnBucarLibro.Text = "      Bucar Libros";
            this.btnBucarLibro.UseVisualStyleBackColor = true;
            this.btnBucarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnQuitar.ForeColor = System.Drawing.Color.MintCream;
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(197, 307);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(138, 74);
            this.btnQuitar.TabIndex = 73;
            this.btnQuitar.Text = "Quitar fila";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 708);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnBucarLector);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.btnBucarLibro);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.btnGuardarPrestamos);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLector);
            this.Controls.Add(this.txtLibro);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dgvDetalle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "FrmPrestamos";
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txtLibro;
        private System.Windows.Forms.TextBox txtLector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnGuardarPrestamos;
        private System.Windows.Forms.Button btnBucarLector;
        private System.Windows.Forms.Button btnBucarLibro;
        private System.Windows.Forms.Button btnQuitar;
    }
}