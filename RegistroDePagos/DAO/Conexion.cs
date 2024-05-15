using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Conexion
    {
        public static SqlConnection GetConexion()
        {
            string connectionString = @"Data Source=DESKTOP-7PDCPH1;Initial Catalog=BDCONTROLDEPAGOS;User ID=sa;Password=123;";
            //string connectionString = @"Data Source=JCHUMPITAZ;Initial Catalog=BDCONTROLDEPAGOS;User ID=sa;Password=123456789;";

            SqlConnection cn = new SqlConnection();

            try
            {
                cn = new SqlConnection(connectionString);
                return cn;
            }
            catch (Exception ex)
            {
                throw;
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }
    }
}
