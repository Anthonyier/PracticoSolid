using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosProductosEnlatados : DatosProducto
    {
        public DatosProductosEnlatados()
        {
            IdGrupoProducto = 4;
        }
        public override void crearSkuAlternateProducto(string cSkuBase)
        {
            string skuAlternate = "-4237-wdsg";
            string concatenacion = cSkuBase + skuAlternate;
            CSkuAlternante = concatenacion;
        }

        public override void crearSkuBase()
        {
            CSku = "Enlatados-";
        }

        public override string obtenerClasificacionProducto()
        {
            string clasificacion = "Estos Productos Son Enlatados";
            return clasificacion;
        }
    }
}
