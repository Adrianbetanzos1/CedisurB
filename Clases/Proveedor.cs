using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CedisurB.Clases
{
    
     class Proveedor
    {

        public int ID_proveedor { get; set; }
        public string RfcProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public DateTime FechaRegistro { get; set; }

        public string TipoDeProveedor { get; set; }
        public string TipoDePago { get; set; }


        public static DataTable MostrarProveedores()
        {

            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                SqlDataAdapter da = new SqlDataAdapter("DT_MostrarProveedor", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dta = new DataTable();
                da.Fill(dta);
                conexion.Close();
                return dta;
            }
                
        }


        public static DataTable MostrarNombreProveedores(string args)
        {

            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                string consulta = "select * from Proveedor where nombreProveedor like '%" + args + "%'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.Close();
                return dt;

            }
            
        }


        public static DataTable MostrarRFCProveedores(string args)
        {

            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                string consulta = "select * from Proveedor where RfcProveedor like '%" + args + "%'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

                DataTable dt = new DataTable();
               
                da.Fill(dt);
                conexion.Close();
                return dt;

            }
                
        }

        public static DataTable Mostrar(string args)
        {

            using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-717JV41\\SQLEXPRESS; Database=Cedisur;  integrated security= true"))
            {
                string consulta = "select * from Proveedor where RfcProveedor like '%" + args + "%'";
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);

                DataTable dt = new DataTable();

                da.Fill(dt);
                conexion.Close();
                return dt;

            }

        }

    }
}
