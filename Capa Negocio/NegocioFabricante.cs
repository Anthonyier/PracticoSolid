using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
   public class NegocioFabricante
    {
        public string getNombre()
        {
            DatosFabricante objFabricante = new DatosFabricante();
            return objFabricante.obtenerFabricante();
        }
    }
}
