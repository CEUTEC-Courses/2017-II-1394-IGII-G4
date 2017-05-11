using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Rutas
{
    public abstract class RutaBuilder
    {

        public abstract void CrearRuta(String nombre, String origen, String destino);
        public abstract void AgregarPunto(String nombre);
        public abstract Ruta ObtenerRuta();
    }
}
