using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
   public class NegocioFabricante
    {

        DatosFabricante objFabricante = new DatosFabricante();

        public string getNombre()
        {
            return objFabricante.obtenerFabricante();
        }

        public DataTable obtenerFabricantes()
        {
            return objFabricante.obtenerTodosLosFabricantes();
        }
    }
}
