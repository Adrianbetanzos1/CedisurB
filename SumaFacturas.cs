using CedisurB.Clases;
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
    public partial class SumaFacturas : Form
    {
        private int suma = 0;
        readonly DataTable dt = new DataTable();
        private readonly HashSet<int> valoresUnicos = new HashSet<int>();
        public SumaFacturas()
        {
            InitializeComponent();
          
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
            SaldoPendienteGeneral ver = new SaldoPendienteGeneral();
            ver.Show();
        }

        private void DGVproveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVproveedores.Columns["saldoMXP"].Index && e.RowIndex >= 0)
            {
                // Obtener el valor de la celda seleccionada
                DataGridViewCell celdaSeleccionada = DGVproveedores.Rows[e.RowIndex].Cells[3];
                int valorCelda = Convert.ToInt32(celdaSeleccionada.Value);

                DataGridViewCell celdaSeleccionadaFactura = DGVproveedores.Rows[e.RowIndex].Cells[2];
                int valorCeldaFactura = Convert.ToInt32(celdaSeleccionadaFactura.Value);

                if (valoresUnicos.Contains(valorCeldaFactura))
                {
                    MessageBox.Show("Este valor ya ha sido seleccionado.", "Valor Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Agregar el nuevo valor de la celda seleccionada
                    suma += valorCelda;
                    valoresUnicos.Add(valorCelda);
                    // Actualizar el TextBox de suma con la nueva suma
                    TxtSuma.Text = "$" + suma.ToString();

                    string columna1 = DGVproveedores.Rows[e.RowIndex].Cells["nombreProveedor"].Value.ToString();
                    string columna2 = DGVproveedores.Rows[e.RowIndex].Cells["numContrato"].Value.ToString();
                    string columna3 = DGVproveedores.Rows[e.RowIndex].Cells["FacturaN"].Value.ToString();
                    string columna4 = DGVproveedores.Rows[e.RowIndex].Cells["saldoMXP"].Value.ToString();
                    string columna5 = DGVproveedores.Rows[e.RowIndex].Cells["saldoUSD"].Value.ToString();

                    // Agregar los datos al DataGridView de destino
                    DGVProveedor1.Rows.Add(columna1, columna2, columna3, columna4, columna5);
                }
     
            }
            
        }


        private DataTable MostrarSaldos()
        {
            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                string consulta = "select Proveedor.nombreProveedor,numContrato, FacturaN, " +
                    "saldoMXP, saldoUSD " +
                    "from Cedisur.dbo.Factura inner join Cedisur.dbo.Proveedor on Proveedor.ID_proveedor = Factura.ID_proveedor " +
                    "where Factura.saldoMXP != 0";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);


                da.Fill(dt);
                conexion.Close();
                return dt;
            }
        }

        private void SumaFacturas_Load(object sender, EventArgs e)
        {
           
            DGVproveedores.DataSource = MostrarSaldos();
            //Añade los valores de la columna de un dgv a otro
            DGVProveedor1.Columns.Add("nombreProveedor", "nombreProveedor");
            DGVProveedor1.Columns.Add("numContrato", "numContrato");
            DGVProveedor1.Columns.Add("facturaN", "facturaN");
            DGVProveedor1.Columns.Add("saldoMXP","saldoMXP");
            DGVProveedor1.Columns.Add("saldoUSD", "saldoUSD");

            TxtSuma.Text = "0";
                

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (DGVProveedor1.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else 
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DGVProveedor1.SelectedRows[0];

                // Obtener el valor de la celda "Valor" de la fila seleccionada
                int valorCelda = Convert.ToInt32(filaSeleccionada.Cells["saldoMXP"].Value);

                // Restar el valor de la fila eliminada de la suma total
                suma -= valorCelda;

                // Actualizar el TextBox de suma con la nueva suma
                TxtSuma.Text = "$"+suma.ToString();

                // Eliminar la fila seleccionada del DataGridView de registros seleccionados
                DGVProveedor1.Rows.Remove(filaSeleccionada);


            }
            
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
            if (DGVProveedor1.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {

                ShowCustomMessageBox();
            }

        }


        private void ShowCustomMessageBox()
        {
            SeleccionEmpresas customMessageBox = new SeleccionEmpresas();
            customMessageBox.Eleccion("Seleccione el diseño para el formato del reporte:", "CEDISUR", "CIESSA", "GICSA");

            customMessageBox.ShowDialog();
            int selectedOption = customMessageBox.SelectedOption;
            datosInforme = ObtenerDatosDesdeDataGridView(DGVProveedor1);
            if (selectedOption.Equals(1))
            {
                ReporteSumaSaldosCedisur formularioViewer = new ReporteSumaSaldosCedisur(datosInforme);
                formularioViewer.Show();

            }
            else if (selectedOption == 2)
            {
                ReporteSumaSaldos formularioViewer = new ReporteSumaSaldos(datosInforme);
                formularioViewer.Show();
            }
            else if(selectedOption == 3)
            {
                ReporteSumaSaldosGicsa formularioViewer = new ReporteSumaSaldosGicsa(datosInforme);
                formularioViewer.Show();
            }
            
        }

        
    }
}
