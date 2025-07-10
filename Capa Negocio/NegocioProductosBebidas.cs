using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
   public class NegocioProductosBebidas:NegocioProducto 
    {
        public NegocioProductosBebidas()
        {
            objProducto = new DatosProductosBebidas();
        }

    }
}
