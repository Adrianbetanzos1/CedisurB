using CedisurB.Clases;
using CedisurB.Reportes;
using CedisurB.Reportes.DsSistemaTableAdapters;
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
    public partial class SaldoPendienteProveedor : Form
    {
        readonly VerProveedores prov = new VerProveedores();
        public new Form ParentForm;
        readonly DataTable dt = new DataTable();
        public SaldoPendienteProveedor()
        {
            InitializeComponent();
            

        }

        private DataTable MostrarSaldos()
        {
            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                string consulta = "select Proveedor.nombreProveedor, FacturaN, fechaFactura, diasVencimiento, importeMXP, importeUSD, abono, " +
                    "saldoMXP, saldoUSD, TipoDeCambio " +
                    "from Factura inner join Proveedor on Proveedor.ID_proveedor = Factura.ID_proveedor " +
                    "where Proveedor.nombreProveedor = '" + TxtProveedor.Text + "' and Factura.saldoMXP != 0";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

                
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
        }

        private void SaldoPendienteProveedor_Load(object sender, EventArgs e)
        {
            DGVproveedores.DataSource = MostrarSaldos();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            prov.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            if (DGVproveedores.RowCount==0)
            {
                MessageBox.Show("Generará un reporte sin datos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            

            datosInforme = ObtenerDatosDesdeDataGridView(DGVproveedores);

            ReporteSaldos formularioViewer = new ReporteSaldos(datosInforme);
            formularioViewer.TxtProveedor.Text = TxtProveedor.Text;
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
    }
}
