using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;

namespace TCS.Rutas
{
    public abstract class RutaBuilder
    {

        public abstract bool crearRuta(String nombre, punto origen, punto destino);
        public abstract bool crearRuta(String nombre, String nombreOrigen, String nombreDestino);
        public abstract ruta obtenerRuta();
    }
}
