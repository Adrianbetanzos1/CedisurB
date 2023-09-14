using CedisurB.Clases;
using CedisurB.Reportes.DsSistemaTableAdapters;
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
    public partial class ReporteFiltrado : Form
    {
        private readonly DataTable datosInforme;
        public ReporteFiltrado(DataTable datosInforme)
        {
            InitializeComponent();

            this.datosInforme = datosInforme;
        }

        private void ReporteFiltrado_Load(object sender, EventArgs e)
        {
            

            reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DsFacturas", datosInforme);

            // Asigna el origen de datos al informe.
            ReportParameter parameter1 = new ReportParameter("ParametroFechaInicio", TxtFechainicio.Text);
            ReportParameter parameter2 = new ReportParameter("ParametroFechaFinal", TxtFechaFinal.Text);
            reportViewer1.LocalReport.SetParameters(parameter1);
            reportViewer1.LocalReport.SetParameters(parameter2);

            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            
            // Refresca el informe para mostrar los datos.
            reportViewer1.RefreshReport();

        }

        
    }
}
