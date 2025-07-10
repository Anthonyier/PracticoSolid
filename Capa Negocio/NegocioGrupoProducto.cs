using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    class NegocioGrupoProducto
    {
       
        public void RegistrarGrupoProducto(string nombreGrupoProducto)
        {
            DatosGrupoProducto objGrupoProducto = new DatosGrupoProducto();
            objGrupoProducto.CNmbProveedor = nombreGrupoProducto;
            objGrupoProducto.RegistrarGrupoProducto();
            
        }
    }
}
