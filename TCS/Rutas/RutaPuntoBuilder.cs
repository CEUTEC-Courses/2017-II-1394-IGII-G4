using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;

namespace TCS.Rutas
{
    public abstract class RutaPuntoBuilder
    {

        public abstract bool crearRutaPunto(ruta ruta, punto punto);

        public abstract rutapunto obtenerRutaPunto();

    }
}
