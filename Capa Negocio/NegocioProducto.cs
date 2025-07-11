using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public abstract class NegocioProducto
    {

       protected DatosProducto objProducto;

        public void RegistrarProducto(string nombre,decimal peso,string um,decimal precioLista,string codBarra,int idFabrica)
        {
            objProducto.crearSkuBase();
            objProducto.crearSkuAlternateProducto(objProducto.CSku);
            objProducto.CNombre = nombre;
            objProducto.NPeso = peso;
            objProducto.CUM = um;
            objProducto.NPrecioLista = precioLista;
            objProducto.CCodBarra = codBarra;
            objProducto.IdCodFabricante = idFabrica;
            objProducto.IdProveedor = 1;

            objProducto.RegistrarProducto();
        }

        public string obtenerClasificacion()
        {
            return objProducto.obtenerClasificacionProducto();
        }
    }
}
