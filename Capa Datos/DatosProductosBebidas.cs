using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosProductosBebidas : DatosProducto
    {
        public DatosProductosBebidas()
        {
            IdGrupoProducto = 5;
        }
        public override void crearSkuAlternateProducto(string cSkuBase)
        {
            string skuAlternate = "-14-htef";
            string concatenacion = cSkuBase + skuAlternate;
            CSkuAlternante = concatenacion;
        }

        public override void crearSkuBase()
        {
            CSku = "Bebidas-";
        }

        public override string obtenerClasificacionProducto()
        {
            string clasificacion = "Estos Productos Son Bebidas";
            return clasificacion;
        }
    }
}
