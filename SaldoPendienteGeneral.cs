using CedisurB.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CedisurB
{
    public partial class SaldoPendienteGeneral : Form
    {
        readonly DataTable dt = new DataTable();
        public SaldoPendienteGeneral()
        {
            InitializeComponent();
        }

        private DataTable MostrarSaldos()
        {
            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                string consulta = "select Proveedor.nombreProveedor,numContrato, FacturaN, fechaFactura, diasVencimiento, importeMXP, importeUSD, abono, " +
                    "saldoMXP, saldoUSD, TipoDeCambio " +
                    "from Cedisur.dbo.Factura inner join Cedisur.dbo.Proveedor on Proveedor.ID_proveedor = Factura.ID_proveedor " +
                    "where Factura.saldoMXP != 0";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);


                da.Fill(dt);
                conexion.Close();
                return dt;
            }
        }

        private void SaldoPendienteGeneral_Load(object sender, EventArgs e)
        {
            DGVproveedores.DataSource = MostrarSaldos();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            VerProveedores ver = new VerProveedores();
            ver.Show();
        }

        

        private DataTable ObtenerDatosDesdeDataGridView(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();


            foreach (DataGridViewColumn dgvColumn in dataGridView.Columns)
            {
                dataTable.Columns.Add(dgvColumn.HeaderText);
            }

            // Recorre las filas del DataGridView y agrega los datos al DataTable.
            foreach (DataGridViewRow dgvRow in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                {
                    dataRow[dgvCell.ColumnIndex] = dgvCell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        DataTable datosInforme = new DataTable();
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (DGVproveedores.RowCount == 0)
            {
                MessageBox.Show("Generará un reporte sin datos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }


            datosInforme = ObtenerDatosDesdeDataGridView(DGVproveedores);

            ReporteSaldoGeneral formularioViewer = new ReporteSaldoGeneral(datosInforme);
            formularioViewer.TxtFechainicio.Text = DTPInicio.Value.ToString();
            formularioViewer.TxtFechaFinal.Text = DTPfinal.Value.ToString();
            formularioViewer.Show();
        }

        private void BtnBuscarFecha_Click(object sender, EventArgs e)
        {

            DateTime fechaInicio = DTPInicio.Value;
            DateTime fechaFinal = DTPfinal.Value;

            DataView vista = dt.DefaultView;
            vista.RowFilter = $"fechaFactura >= '{fechaInicio}' and fechaFactura <= '{fechaFinal}' ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SumaFacturas suma = new SumaFacturas();
            suma.Show();
            this.Close();
        }
    }
}
