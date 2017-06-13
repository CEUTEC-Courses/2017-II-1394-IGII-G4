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
            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                var ruta = context.ruta.Add(new ruta { NombreRuta = nombre, IDPuntoOrigen = origen.PuntoID, IDPuntoDestino = destino.PuntoID });
                _ruta = ruta;
                context.SaveChanges();
                return true;
            }
        }

        public override bool crearRuta(string nombre, string nombreOrigen, string nombreDestino)
        {
            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                var puntoOrigen = context.punto.Where(p => p.NombrePunto == nombreOrigen).FirstOrDefault<punto>();
                var PuntoDestino = context.punto.Where(p => p.NombrePunto == nombreDestino).FirstOrDefault<punto>();
                var nuevaRuta = context.ruta.Add(new ruta { NombreRuta = nombre, IDPuntoOrigen = puntoOrigen.PuntoID, IDPuntoDestino = PuntoDestino.PuntoID });
                context.SaveChanges();
                return true;
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
