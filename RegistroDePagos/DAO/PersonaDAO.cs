using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;

namespace DAO
{
    public class PersonaDAO
    {
        SqlConnection cn = Conexion.GetConexion();
        SqlCommand cmd = new SqlCommand();

        public List<PersonaE> Listado()
        {
            List<PersonaE> lst = new List<PersonaE>();

            try
            {
                cn = Conexion.GetConexion();
                cn.Open();
                cmd = new SqlCommand("sp_ListaPersonas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PersonaE personaE = new PersonaE();
                    personaE.IdPersona = Convert.ToInt32(dr["IdPersona"]);
                    personaE.Nombres = Convert.ToString(dr["Nombres"]);
                    personaE.ApellidoP = Convert.ToString(dr["ApellidoP"]);
                    personaE.ApellidoM = Convert.ToString(dr["ApellidoM"]);

                    lst.Add(personaE);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! : " + ex.ToString());
                throw;
            }
            finally
            {
                cn.Close();
            }

            return lst;
        }
    }
}
