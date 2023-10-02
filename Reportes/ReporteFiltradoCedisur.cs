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
    public partial class ReporteFiltradoCedisur : Form
    {
        private readonly DataTable datosInforme;
        public ReporteFiltradoCedisur(DataTable datosInforme)
        {
            InitializeComponent();
            this.datosInforme = datosInforme;
        }

        private void ReporteFiltradoCedisur_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report11.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", datosInforme);

            // Asigna el origen de datos al informe.
            ReportParameter parameter1 = new ReportParameter("ParametroFechaInicio", TxtFechainicio.Text);
            ReportParameter parameter2 = new ReportParameter("ParametroFechaFinal", TxtFechaFinal.Text);
            reportViewer1.LocalReport.SetParameters(parameter1);
            reportViewer1.LocalReport.SetParameters(parameter2);

            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
