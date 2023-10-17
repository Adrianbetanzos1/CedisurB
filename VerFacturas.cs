using CedisurB.Clases;
using CedisurB.Reportes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CedisurB
{
    public partial class VerFacturas : Form
    {

        private readonly SqlConnection conexion = new SqlConnection("server=SERVERDES ; database=Cedisur ; integrated security = true");
        DataTable datosInforme = new DataTable();

        readonly DataTable dt = new DataTable();
        //private readonly int pageSize = 15; // Número de registros a cargar por página
        //private int currentPage = 1;
        //private readonly string connectionString = "server=DESKTOP-717JV41\\SQLEXPRESS ; database=cedisur ; integrated security = true";


        private DataTable MostrarFactura()
        {

            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                SqlDataAdapter da = new SqlDataAdapter("DT_MostrarFacturasB", conexion);

               
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                conexion.Close();
                return dt;
            }

        }


        public VerFacturas()
        {
            InitializeComponent();
            DGVfacturas.DataSource = MostrarFactura();
            //LoadData(currentPage);

        }

        private void RestringirAccesos()
        {
            if (CacheInicioSesionUsuario.Nivel_seguridad == Cargos.usuario)
            {
                BtnEditar.Enabled = false;
            }
        }

        
        private void VerFacturas_Load(object sender, EventArgs e)
        {
            RestringirAccesos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBusqueda.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVfacturas.DataSource = Facturas.Mostrar(TxtBusqueda.Text);
            }
        }

        private void BtnBuscarID_Click(object sender, EventArgs e)
        {
            if (TxtBuscarID.Text.Equals(""))
            {
                MessageBox.Show("Necesita ingresar un dato antes", "Advertencia");
            }
            else
            {
                DGVfacturas.DataSource = Facturas.MostrarIDProveedor(TxtBuscarID.Text);
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (DGVfacturas.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else if (MessageBox.Show("Está seguro que desea generar un pago a la factura seleccionada?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var pago = new AgregarPagos
                {
                    ParentForm = this
                };
                
                pago.txtSaldoPendiente.Text = DGVfacturas.SelectedRows[0].Cells[6].Value.ToString();
                pago.txtSaldoUSD.Text = DGVfacturas.SelectedRows[0].Cells[7].Value.ToString();

                conexion.Open();
                string query = "select proveedor.ID_proveedor, Factura.FacturaN, Proveedor.nombreProveedor, Factura.abono " +
                    "from Factura " +
                    "inner join Proveedor on Factura.ID_proveedor = Proveedor.ID_proveedor " +
                    "where FacturaN ='" + DGVfacturas.SelectedRows[0].Cells[0].Value.ToString() + "'";



                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pago.TxtNombrePro.Text = reader["nombreProveedor"].ToString();
                            pago.TxtNombreFactura.Text = reader["FacturaN"].ToString();
                            pago.TxtID.Text = reader["ID_proveedor"].ToString();
                            pago.TxtAbono.Text = reader["abono"].ToString();
                        }
                    }



                }

                conexion.Close();
                this.Hide();
                pago.ShowDialog();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DGVfacturas.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {
                var facturas = new EditarFacturas
                {
                    ParentForm = this
                };

                
                facturas.TxtNombreFactura.Text = DGVfacturas.SelectedRows[0].Cells[0].Value.ToString();
                facturas.TxtNumContrato.Text = DGVfacturas.SelectedRows[0].Cells[1].Value.ToString();
                facturas.DTPFecha.Value = (DateTime)DGVfacturas.SelectedRows[0].Cells[2].Value;
                facturas.TxtDiasVencimiento.Text = DGVfacturas.SelectedRows[0].Cells[3].Value.ToString();
                facturas.TxtImporte.Text = DGVfacturas.SelectedRows[0].Cells[4].Value.ToString();
                facturas.TxtImporteUSD.Text = DGVfacturas.SelectedRows[0].Cells[5].Value.ToString();
                facturas.TxtAbono.Text = DGVfacturas.SelectedRows[0].Cells[6].Value.ToString();
                facturas.TxtSaldoMXP.Text = DGVfacturas.SelectedRows[0].Cells[7].Value.ToString();
                facturas.TxtSaldoUSD.Text = DGVfacturas.SelectedRows[0].Cells[8].Value.ToString();
                
                facturas.TxtNombreProveedor.Text = DGVfacturas.SelectedRows[0].Cells[9].Value.ToString();
                
                facturas.TxtDolar.Text = DGVfacturas.SelectedRows[0].Cells[11].Value.ToString();

                this.Hide();
                facturas.ShowDialog();
            }
        }


        //Obtener los datos del dgv para convertirlo en un data table y generarlo posteriormente en un reporte
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


        //Genera el reporte general, pero no está implementado
        private void BtnReporte_Click(object sender, EventArgs e)
        {
            ReportesFacturas reporte = new ReportesFacturas();
            reporte.ShowDialog();
        }

        
        //BOTON FILTRADO, que genera un reporte 

       
        private void Button1_Click(object sender, EventArgs e)
        {
            if (DGVfacturas.RowCount == 0)
            {
                MessageBox.Show("No hay datos existentes");
            }
            else
            {

                ShowCustomMessageBox();
            }


        }

        //Método para mostrar ventana emergente para seleccionar formato
        private void ShowCustomMessageBox()
        {
            SeleccionEmpresas customMessageBox = new SeleccionEmpresas();
            customMessageBox.Eleccion("Seleccione el diseño para el formato del reporte:", "CEDISUR", "CIESSA", "GICSSA");

            customMessageBox.ShowDialog();
            int selectedOption = customMessageBox.SelectedOption;
            datosInforme = ObtenerDatosDesdeDataGridView(DGVfacturas);

            if (selectedOption == 1)
            {
                ReporteFiltradoCedisur formularioViewer = new ReporteFiltradoCedisur(datosInforme);
                
                formularioViewer.TxtFechainicio.Text = DTPInicio.Value.ToString();
                formularioViewer.TxtFechaFinal.Text = DTPfinal.Value.ToString();
                formularioViewer.Show();

            }
            else if (selectedOption == 2)
            {
                ReporteFiltrado formularioViewer = new ReporteFiltrado(datosInforme);
                formularioViewer.TxtFechainicio.Text = DTPInicio.Value.ToString();
                formularioViewer.TxtFechaFinal.Text = DTPfinal.Value.ToString();

                formularioViewer.Show();
            }
            else if (selectedOption == 3)
            {
                ReporteFiltradoGicsa formularioViewer = new ReporteFiltradoGicsa(datosInforme);
             
                formularioViewer.TxtFechainicio.Text = DTPInicio.Value.ToString();
                formularioViewer.TxtFechaFinal.Text = DTPfinal.Value.ToString();
                formularioViewer.Show();
            }

        }





        //Da formato a las celdas de los saldos ya liquidados
        private void DGVfacturas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGVfacturas.Columns[e.ColumnIndex].Name == "saldoMXP")
            {
                // Comprueba la condición, por ejemplo, si el valor es mayor que 100
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int valor))
                {
                    if (valor == 0)
                    {
                        // Pinta la celda en verde
                        e.CellStyle.BackColor = Color.DarkSeaGreen;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /*
        private void LoadData(int page)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Consulta SQL paginada para cargar registros
                string sqlQuery = $"SELECT TOP {pageSize} FacturaN, fechaFactura, diasVencimiento, importeMXP, importeUSD, abono, saldoMXP, saldoUSD, ID_proveedor, TipoDeCambio FROM (SELECT ROW_NUMBER() OVER (ORDER BY ID_factura) AS RowNum, * FROM Factura) AS SubQuery WHERE RowNum > {pageSize * (page - 1)}";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                adapter.Fill(dataTable);
            }
        }
        */

        private void BtnMas_Click(object sender, EventArgs e)
        {
            /*
            currentPage++;
            LoadData(currentPage);
        */
            
        }


        //Boton para filtrar por medio de las fechas
        private void BtnBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = DTPInicio.Value;
            DateTime fechaFinal = DTPfinal.Value;
            DataView vista = dt.DefaultView;
            vista.RowFilter = $"fechaFactura >= '{fechaInicio}' and fechaFactura <= '{fechaFinal}' ";
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
                DGVfacturas.DataSource = dv.ToTable();
            }
            else
            {
                // Si no se selecciona ningún valor, muestra todos los registros
                DGVfacturas.DataSource = dt;
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

        private void DGVfacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
