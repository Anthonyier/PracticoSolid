using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosProductosLacteos : DatosProducto
    {
        public DatosProductosLacteos()
        {
            IdGrupoProducto = 2;
        }
        public override void crearSkuAlternateProducto(string cSkuBase)
        {
            string skuAlternate = "-07-shg";
            string concatenacion = cSkuBase + skuAlternate;
            CSkuAlternante = concatenacion;
        }

        public override void crearSkuBase()
        {
            CSku = "Lacteo-";
        }

        public override string obtenerClasificacionProducto(int Id)
        {
            string clasificacion = "Estos Productos Son Lacteos";
            return clasificacion;
        }
    }
}
