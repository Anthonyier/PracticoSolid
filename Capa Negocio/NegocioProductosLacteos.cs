﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class NegocioProductosLacteos:NegocioProducto
    {
        public NegocioProductosLacteos()
        {
            objProducto = new DatosProductosLacteos();
        }

    }
}
