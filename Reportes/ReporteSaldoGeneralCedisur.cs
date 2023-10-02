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
    public partial class ReporteSaldoGeneralCedisur : Form
    {
        private readonly DataTable datosInforme;
        public new Form ParentForm;
        public ReporteSaldoGeneralCedisur(DataTable datosInforme)
        {
            InitializeComponent();
            this.datosInforme = datosInforme;
        }

        private void ReporteSaldoGeneralCedisur_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report7.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", datosInforme);

            ReportParameter parameter1 = new ReportParameter("ParametroFechaInicio", TxtFechainicio.Text);
            ReportParameter parameter2 = new ReportParameter("ParametroFechaFinal", TxtFechaFinal.Text);
            reportViewer1.LocalReport.SetParameters(parameter2);
            reportViewer1.LocalReport.SetParameters(parameter1);

            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
