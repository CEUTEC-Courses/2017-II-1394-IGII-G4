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
            var rutapunto = AppConfigurationManager.Instance().DbContext.rutapunto.Add(new rutapunto { RutaID = ruta.RutaID, PuntoID = punto.PuntoID });
            _rutapunto = rutapunto;
            AppConfigurationManager.Instance().DbContext.SaveChanges();
            return true;

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
