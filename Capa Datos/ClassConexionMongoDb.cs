using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class ClassConexionMongoDb : IBasesDeDatos
    {
        public SqlConnection conectar()
        {
            SqlConnection Conexion = new SqlConnection("Data Source = SERVIDOR; Initial Catalog = SOLID; Integrated Security = True");
            return Conexion;
        }
    }
}
