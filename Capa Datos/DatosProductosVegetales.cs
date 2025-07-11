using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosProductosVegetales : DatosProducto
    {
        public DatosProductosVegetales()
        {
            IdGrupoProducto = 1;
        }
        public override void crearSkuAlternateProducto(string cSkuBase)
        {
            string skuAlternate = "-107-710";
            string concatenacion = cSkuBase + skuAlternate;
            CSkuAlternante = concatenacion;
        }

        public override void crearSkuBase()
        {
            CSku = "Vegetales-";
        }

        public override string obtenerClasificacionProducto()
        {
            string clasificacion = "Estos Productos Son Vegetales";
            return clasificacion;
        }
    }
}
