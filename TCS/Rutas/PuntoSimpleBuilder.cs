using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.Rutas
{
    class PuntoSimpleBuilder : PuntoBuilder
    {
        private  punto _punto;
        public override bool crearPunto(string nombre)
        {
            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                var punto = context.punto.Add(new punto { NombrePunto = nombre });
                _punto = punto;
                context.SaveChanges();
                return true;
            }
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
