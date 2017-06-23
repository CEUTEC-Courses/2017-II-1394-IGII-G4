using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.Rutas
{
    public class PuntoSimpleBuilder : PuntoBuilder
    {
        private  punto _punto;
        public override bool crearPunto(string nombre)
        {
            var punto = AppConfigurationManager.Instance().DbContext.punto.Add(new punto { NombrePunto = nombre });
            _punto = punto;
            AppConfigurationManager.Instance().DbContext.SaveChanges();
            return true;
        }

        public override punto obtenerPunto()
        {
            if (_punto != null)
                return _punto;
            else
                return null;
        }
    }
}
