using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.Rutas
{
    public class RutaSimpleBuilder : RutaBuilder
    {
        private ruta _ruta;

        public override bool crearRuta(string nombre, punto origen, punto destino)
        {
            var ruta = AppConfigurationManager.Instance().DbContext.ruta.Add(new ruta { NombreRuta = nombre, IDPuntoOrigen = origen.PuntoID, IDPuntoDestino = destino.PuntoID });
            _ruta = ruta;
            AppConfigurationManager.Instance().DbContext.SaveChanges();
            return true;
        }

        public override bool crearRuta(string nombre, string nombreOrigen, string nombreDestino)
        {
            var puntoOrigen = AppConfigurationManager.Instance().DbContext.punto.Where(p => p.NombrePunto == nombreOrigen).FirstOrDefault<punto>();
            var puntoDestino = AppConfigurationManager.Instance().DbContext.punto.Where(p => p.NombrePunto == nombreDestino).FirstOrDefault<punto>();
            if (puntoOrigen != null && puntoDestino != null)
            {
                var nuevaRuta = AppConfigurationManager.Instance().DbContext.ruta.Add(new ruta { NombreRuta = nombre, IDPuntoOrigen = puntoOrigen.PuntoID, IDPuntoDestino = puntoDestino.PuntoID });
                AppConfigurationManager.Instance().DbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ruta obtenerRuta()
        {
            if (_ruta != null)
                return _ruta;
            else
                return null;
        }


    }
}
