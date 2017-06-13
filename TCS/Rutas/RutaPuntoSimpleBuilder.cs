using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.Rutas
{
    public class RutaPuntoSimpleBuilder : RutaPuntoBuilder
    {

        private rutapunto _rutapunto;

        public override bool crearRutaPunto(ruta ruta, punto punto)
        {
            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                var rutapunto = context.rutapunto.Add(new rutapunto { RutaID = ruta.RutaID, PuntoID = punto.PuntoID });
                _rutapunto = rutapunto;
                context.SaveChanges();
                return true;
            }
        }

        public override rutapunto obtenerRutaPunto()
        {
            if (_rutapunto != null)
                return _rutapunto;
            else
                return null;
        }
    }
}
