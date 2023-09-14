using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CedisurB.Reportes
{
    public partial class ReporteSaldos : Form
    {
        private readonly DataTable datosInforme;
        public new Form ParentForm;
        public ReporteSaldos(DataTable datosInforme)
        {
            InitializeComponent();
            this.datosInforme = datosInforme;
        }

        private void ReporteSaldos_Load(object sender, EventArgs e)
        {

            

            reportViewer1.LocalReport.ReportEmbeddedResource = "CedisurB.Reportes.Report2.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DsSaldosPendientes", datosInforme);

            // TODO: This line of code loads data into the 'dsSistema.DT_MostrarSaldos' table. You can move, or remove it, as needed.
            

            
            ReportParameter parameter = new ReportParameter("ParametroNombre",TxtProveedor.Text );
            ReportParameter parameter1 = new ReportParameter("ParametroFechaInicio", TxtFechainicio.Text);
            ReportParameter parameter2 = new ReportParameter("ParametroFechaFinal", TxtFechaFinal.Text);
            reportViewer1.LocalReport.SetParameters(parameter);
            reportViewer1.LocalReport.SetParameters(parameter1);
            reportViewer1.LocalReport.SetParameters(parameter2);

            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            reportViewer1.RefreshReport();
        }


    }
}
