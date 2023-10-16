using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace CedisurB.Clases
{
    class Facturas
    {

        public int ID_factura { get; set; }
        public string FacturaN { get; set; }

        //Datos de provisiones

        public DateTime FechaFactura { get; set; }
        public int DiasVencimiento { get; set; }
        public int Importe { get; set; }
        public int Abono { get; set; }
        public int SaldoMXP { get; set; }



        //Datos Totales

        public int SaldoPendiente { get; set; }
        public int ProvisionesAportadas { get; set; }


        public static DataTable MostrarFactura()
        {

            using (SqlConnection conexion = new SqlConnection("Server=SERVERDES; Database=Cedisur;  integrated security= true"))
            {
                SqlDataAdapter da = new SqlDataAdapter("DT_MostrarFacturasB", conexion);

                DataTable dt = new DataTable();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                conexion.Close();
                return dt;
            }

        }

        public static DataTable Mostrar(string args)
        {
            using (SqlConnection conexion = new SqlConnection("Server=SERVERDES; Database=Cedisur;  integrated security= true"))
            {
                conexion.Open();
                string consulta = "Select FacturaN, fechaFactura, diasVencimiento, importeMXP, importeUSD, abono, saldoMXP, saldoUSD, nombreProveedor, TipoDeCambio from Factura inner join Proveedor on Factura.ID_Proveedor = Proveedor.ID_proveedor where FacturaN like '%" + args + "%'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
                
                DataTable dt = new DataTable();
                
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
            

        }


        public static DataTable MostrarIDProveedor(string args)
        {
            using (SqlConnection conexion = new SqlConnection("Server=SERVERDES; Database=Cedisur;  integrated security= true"))
            {   
                string consulta = "Select FacturaN, fechaFactura, diasVencimiento, importeMXP, importeUSD, abono, saldoMXP, saldoUSD, Proveedor.nombreProveedor, TipoDeCambio from Factura inner join Proveedor on Factura.ID_Proveedor = Proveedor.ID_proveedor where nombreProveedor like '%" + args + "%'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;
            }
                
        }

        

    }
}
