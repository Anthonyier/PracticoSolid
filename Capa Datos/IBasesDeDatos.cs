using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capa_Datos
{
    interface IBasesDeDatos
    {
        SqlConnection conectar();
     }
}
