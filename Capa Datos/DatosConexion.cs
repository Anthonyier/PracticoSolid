using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DatosConexion
    {
        private static DatosConexion connection = null;

        public DatosConexion() { }

        public static DatosConexion getInstance()
        {
            if (connection == null)
            {
                connection = new DatosConexion();
            }
            return connection;
        }

        public SqlConnection conectar()
        {
            SqlConnection Conexion = new SqlConnection("Data Source = SERVIDOR; Initial Catalog = SOLID; Integrated Security = True");
            return Conexion;
        }
        
    }
}
