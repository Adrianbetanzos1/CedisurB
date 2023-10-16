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

        //Método para mostrar los saldos pendientes en el datagridview
        private DataTable MostrarSaldos()
        {
            using (SqlConnection conexion = new SqlConnection("Server=SERVERDES; Database=Cedisur;  integrated security= true"))
            {
                string consulta = "select Proveedor.nombreProveedor,numContrato, FacturaN, fechaFactura, diasVencimiento, importeMXP, importeUSD, abono, " +
                    "saldoMXP, saldoUSD, TipoDeCambio, Proveedor.EmpresaAsoc " +
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

        
        //Método para obtener los datos de un datagridview 
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

        //Manda a llamar el método
        DataTable datosInforme = new DataTable();
        
        private void Button1_Click(object sender, EventArgs e)
        {
            bool alMenosUnNoSeleccionado = true;
            for (int i = 0; i < CLBEmpresa.Items.Count; i++)
            {
                if (CLBEmpresa.GetItemChecked(i))
                {
                    alMenosUnNoSeleccionado = false;
                    break;
                }
            }

            if (alMenosUnNoSeleccionado)
            {
                MessageBox.Show("Seleccione una empresa antes de continuar");
            }
            else if (DGVproveedores.RowCount == 0)
            {
                MessageBox.Show("Generará un reporte sin datos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                ShowCustomMessageBox();
            }



        }


        //Método para mostrar ventana emergente para seleccionar formato
        private void ShowCustomMessageBox()
        {
            
            datosInforme = ObtenerDatosDesdeDataGridView(DGVproveedores);
            if (CLBEmpresa.SelectedItem.Equals("CEDISUR"))
            {
                ReporteSaldoGeneralCedisur formularioViewer = new ReporteSaldoGeneralCedisur(datosInforme);
                formularioViewer.TxtFechainicio.Text = DTPInicio.Value.ToString();
                formularioViewer.TxtFechaFinal.Text = DTPfinal.Value.ToString();
                formularioViewer.Show();

            }
            else if (CLBEmpresa.SelectedItem.Equals("CIESSA"))
            {
                ReporteSaldoGeneral formularioViewer = new ReporteSaldoGeneral(datosInforme);
                formularioViewer.TxtFechainicio.Text = DTPInicio.Value.ToString();
                formularioViewer.TxtFechaFinal.Text = DTPfinal.Value.ToString();
                formularioViewer.Show();
            }
            else if (CLBEmpresa.SelectedItem.Equals("GICSSA"))
            {
                ReporteSaldoGeneralGicsa formularioViewer = new ReporteSaldoGeneralGicsa(datosInforme);
                formularioViewer.TxtFechainicio.Text = DTPInicio.Value.ToString();
                formularioViewer.TxtFechaFinal.Text = DTPfinal.Value.ToString();
                formularioViewer.Show();
            }

        }


        private void BtnBuscarFecha_Click(object sender, EventArgs e)
        {

            DateTime fechaInicio = DTPInicio.Value;
            DateTime fechaFinal = DTPfinal.Value;

            DataView vista = dt.DefaultView;
            vista.RowFilter = $"fechaFactura >= '{fechaInicio}' and fechaFactura <= '{fechaFinal}' ";
        }

        //Manda a llamar al formulario donde se suman las facturas
        private void Button2_Click(object sender, EventArgs e)
        {
            SumaFacturas suma = new SumaFacturas();
            suma.Show();
            this.Close();
        }

        private void CLBEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = CLBEmpresa.CheckedItems;

            if (selectedItems.Count == 1)
            {
                string selectedItem = selectedItems[0].ToString();
                // Realiza la filtración basada en el valor seleccionado
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"EmpresaAsoc = '{selectedItem}'"; // Reemplaza 'ColumnName' con el nombre de la columna que deseas filtrar
                DGVproveedores.DataSource = dv.ToTable();
            }
            else
            {
                // Si no se selecciona ningún valor, muestra todos los registros
                DGVproveedores.DataSource = dt;
            }
        }

        private void CLBEmpresa_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < CLBEmpresa.Items.Count; i++)
            {
                if (i != e.Index) // No desmarca la opción actual
                {
                    CLBEmpresa.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
    }
}
