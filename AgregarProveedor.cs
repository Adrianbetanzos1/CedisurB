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
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void LimpiarDatos()
        {
            TxtRfc.Clear();
            TxtIDProveedor.Clear();
            TxtNombreProv.Clear();
            DTPFecha.Value = DateTime.Now;
            CbTipo.ClearSelected();
            CbMoneda.ClearSelected();
            CLBEmpresa.ClearSelected();

        }

        private bool ExisteIDEnBaseDeDatos(string id)
        {
            string connectionString = "Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"; 
            string query = "SELECT COUNT(*) FROM Proveedor WHERE ID_proveedor = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // El ID ya existe en la base de datos
                        return true;
                    }
                }
            }

            // El ID no existe en la base de datos
            return false;
        }






        //Agrega los datos de los proveedores a la base de datos
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoID = TxtIDProveedor.Text;

            if (string.IsNullOrEmpty(TxtIDProveedor.Text) || string.IsNullOrEmpty(TxtNombreProv.Text) || string.IsNullOrEmpty(TxtRfc.Text) || CbTipo.CheckedItems.Count == 0 || CbMoneda.CheckedItems.Count == 0 || CLBEmpresa.CheckedItems.Count == 0)
            {
                MessageBox.Show("Colocar los datos faltantes antes de continuar");
            }
            else if (MessageBox.Show("Estas seguro que deseas agregar este nuevo proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
                {
                    //Se inicializa el sqlCommand
                    SqlCommand cmd = new SqlCommand("Insert into Proveedor(ID_proveedor,RfcProveedor, nombreProveedor, fechaDeRegistro, TipoDeProveedor, TipoDePago, EmpresaAsoc) values (@id_proveedor,@RfcProveedor, @nombreProveedor, @fechaDeRegistro, @TipoDeProveedor, @TipoDePago,@empresaAsoc)")
                    {
                        CommandType = CommandType.Text,
                        Connection = conexion
                    };
                    cmd.Parameters.AddWithValue("@id_proveedor", TxtIDProveedor.Text);
                    cmd.Parameters.AddWithValue("@RfcProveedor", TxtRfc.Text);
                    cmd.Parameters.AddWithValue("@nombreProveedor", TxtNombreProv.Text);
                    cmd.Parameters.AddWithValue("@fechaDeRegistro", DTPFecha.Value);
                    cmd.Parameters.AddWithValue("@TipoDeProveedor", CbTipo.SelectedItem);
                    cmd.Parameters.AddWithValue("@TipoDePago", CbMoneda.SelectedItem);
                    cmd.Parameters.AddWithValue("@empresaAsoc", CLBEmpresa.SelectedItem);

                    if (ExisteIDEnBaseDeDatos(nuevoID))
                    {
                        MessageBox.Show("El ID ya existe en la base de datos. No se puede duplicar.");
                    }
                    else
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado correctamente");
                        conexion.Close();
                        LimpiarDatos();
                    }
                    
                }

                    
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

        //Valida que sea un valor númerico el que se está poniendo
        private void TxtIDProveedor_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(TxtIDProveedor.Text, out float _))
            {
                MessageBox.Show("Ingrese un valor númerico");
                TxtIDProveedor.Focus();
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void CbTipo_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < CbTipo.Items.Count; i++)
            {
                if (i != e.Index) // No desmarca la opción actual
                {
                    CbTipo.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void CbMoneda_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < CbMoneda.Items.Count; i++)
            {
                if (i != e.Index) // No desmarca la opción actual
                {
                    CbMoneda.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
    }
}
