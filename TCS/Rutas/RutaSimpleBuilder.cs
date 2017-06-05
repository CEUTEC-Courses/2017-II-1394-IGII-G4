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

        private Ruta _ruta;

        public override void CrearRuta(string nombre, String origen, String destino)
        {
            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                var ruta = context.ruta.Add(new ruta { NombreRuta = nombre });
                var puntoOrigen = context.punto.Add(new punto { NombrePunto = origen });
                var puntoDestino = context.punto.Add(new punto { NombrePunto = destino });
                var rutaOrigen = context.rutapunto.Add(new rutapunto { RutaID = ruta.RutaID, PuntoID = puntoOrigen.PuntoID });
                var rutaDestino = context.rutapunto.Add(new rutapunto { RutaID = ruta.RutaID, PuntoID = puntoDestino.PuntoID });

                _ruta = new Ruta(ruta.NombreRuta, puntoOrigen.NombrePunto, puntoDestino.NombrePunto);
                context.SaveChanges();
            }
        }

        public override void AgregarPunto(string nombre)
        {
            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                var ruta = context.ruta.Where(r => r.NombreRuta == _ruta.NombreRuta).FirstOrDefault<ruta>();
                var nuevoPunto = context.punto.Add(new punto { NombrePunto = nombre });
                var nuevoPuntoRuta = context.rutapunto.Add(new rutapunto { RutaID = ruta.RutaID, PuntoID = nuevoPunto.PuntoID });
                _ruta.Puntos.Add(new Punto(nuevoPunto.NombrePunto));
                context.SaveChanges();
            }
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
