namespace SistemaBiblioteca
{
    partial class FrmBuscarLector
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
            this.Buscar = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvLectores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(104, 107);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(49, 16);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(390, 97);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(92, 33);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(174, 104);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 22);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvLectores
            // 
            this.dgvLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectores.Location = new System.Drawing.Point(50, 148);
            this.dgvLectores.Name = "dgvLectores";
            this.dgvLectores.RowHeadersWidth = 51;
            this.dgvLectores.RowTemplate.Height = 24;
            this.dgvLectores.Size = new System.Drawing.Size(641, 222);
            this.dgvLectores.TabIndex = 4;
            this.dgvLectores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLectores_CellDoubleClick);
            // 
            // FrmBuscarLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 398);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvLectores);
            this.Name = "FrmBuscarLector";
            this.Text = "FrmBuscarLector";
            this.Load += new System.EventHandler(this.FrmBuscarLector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvLectores;
    }
}