﻿using System;
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

        }

        //Agrega los datos de los proveedores a la base de datos
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIDProveedor.Text) || string.IsNullOrEmpty(TxtNombreProv.Text) || string.IsNullOrEmpty(TxtRfc.Text) || CbTipo.CheckedItems.Count == 0 || CbMoneda.CheckedItems.Count == 0)
            {
                MessageBox.Show("Colocar los datos faltantes antes de continuar");
            }
            else if (MessageBox.Show("Estas seguro que deseas agregar este nuevo proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
                {
                    //Se inicializa el sqlCommand
                    SqlCommand cmd = new SqlCommand("Insert into Proveedor(ID_proveedor,RfcProveedor, nombreProveedor, fechaDeRegistro, TipoDeProveedor, TipoDePago) values (@id_proveedor,@RfcProveedor, @nombreProveedor, @fechaDeRegistro, @TipoDeProveedor, @TipoDePago)")
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

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado correctamente");
                    conexion.Close();
                    LimpiarDatos();
                }

                    
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
