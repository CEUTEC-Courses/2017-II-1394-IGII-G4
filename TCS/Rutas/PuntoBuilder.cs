using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;

namespace TCS.Rutas
{
    public abstract class PuntoBuilder
    {

        public abstract bool crearPunto(String nombre);

        public abstract punto obtenerPunto();

    }
}
