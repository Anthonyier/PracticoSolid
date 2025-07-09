using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Datos;

namespace Capa_Datos
{
    public class DatosFabricante
    {
        public int id;
        public string nombre;

        public string obtenerFabricante()
        {
            SqlCommand comando = null;
            SqlConnection conex = DatosConexion.getInstance().conectar();
            SqlDataReader lector = null;
            string nombrefabricante = "";
           try
            {
                comando = new SqlCommand("Select nombre from fabricante where id=1", conex);
                comando.CommandType = CommandType.Text;
                conex.Open();
                lector = comando.ExecuteReader();
                lector.Read();
                nombrefabricante = lector["nombre"].ToString();
            }
            catch
            {
                nombrefabricante = "";
            }
            finally
            {
                conex.Close();
            }
            return nombrefabricante;
        }
        

    }
}
