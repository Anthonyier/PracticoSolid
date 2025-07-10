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

        public string cSkuFabricante;
        public string cNmbFabricante;

        public string CSkuFabricante
        {
            get => cSkuFabricante; set => cSkuFabricante = value;
        }
        public string CNmbFabricante
        {
            get => cNmbFabricante; set => cNmbFabricante = value;
        }

        public string obtenerFabricante()
        {
            SqlCommand comando = null;
            IBasesDeDatos objConexion = new DatosConexionSqlServer();
            SqlConnection conex = objConexion.conectar();
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
        
        public DataTable obtenerTodosLosFabricantes()
        {
            
            IBasesDeDatos objConexion = new DatosConexionSqlServer();
            SqlConnection conex = objConexion.conectar();
            DataTable tabla = new DataTable();
            try
            {
                conex.Open();
                string query = "SELECT id,nombre FROM fabricante";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conex);
                adapter.Fill(tabla);
                conex.Close();
                return tabla;
            }
            catch(Exception ex)
            {
                return tabla;
            }

        }
    }
}
