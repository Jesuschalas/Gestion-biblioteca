using Microsoft.Reporting.WinForms;
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
    public partial class FrmReportePrestamos : Form
    {
        public DataTable dtReporte;
        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

      
              private void FrmReportePrestamos_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();

            reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\ReportePrestamo.rdlc";

            ReportDataSource rds = new ReportDataSource("DataSet1", dtReporte);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

            
        

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
