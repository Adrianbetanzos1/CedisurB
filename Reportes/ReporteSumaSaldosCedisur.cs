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

namespace CedisurB.Reportes
{
    public partial class ReporteSumaSaldosCedisur : Form
    {

        private readonly DataTable datosInforme;
        public ReporteSumaSaldosCedisur(DataTable datosInforme)
        {
            InitializeComponent();
            this.datosInforme = datosInforme;
        }

        private void ReporteSumaSaldosCedisur_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report5.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", datosInforme);

            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
