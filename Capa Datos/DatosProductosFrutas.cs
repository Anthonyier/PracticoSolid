using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosProductosFrutas : DatosProducto
    {
        public DatosProductosFrutas()
        {
            IdGrupoProducto = 3;
        }
        public override void crearSkuAlternateProducto(string cSkuBase)
        {
            string skuAlternate = "-21-dsc";
            string concatenacion = cSkuBase + skuAlternate;
            CSkuAlternante = concatenacion;
        }

        public override void crearSkuBase()
        {
            CSku = "Frutas-";
        }

        public override string obtenerClasificacionProducto()
        {
            string clasificacion = "Estos Productos Son Frutas";
            return clasificacion;
        }
    }
}
