using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Rutas
{
    public class RutaSimpleBuilder : RutaBuilder
    {

        private Ruta _ruta;

        public override void CrearRuta(string nombre, String origen, String destino)
        {
            _ruta = new Ruta(nombre, origen, destino);
        }

        public override void AgregarPunto(string nombre)
        {
 	        _ruta.Puntos.Add(new Punto(nombre));
        }

        public override Ruta ObtenerRuta()
        {
            if (_ruta != null)
                return _ruta;
            else
                return null;
        }


    }
}
