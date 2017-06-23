using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.MenuFlota.Flota
{
    public class FlotaUnidadSimpleBuilder : FlotaUnidadBuilder
    {
        private FlotaUnidadModelo _flotaUnidad;
        public override void CrearFlotaUnidad(FlotaUnidadModelo FlotaUnidad)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var nuevaFlotaUnidad = new flotaunidad()
                {
                    FlotaID = FlotaUnidad.FlotaID,
                    UnidadID = FlotaUnidad.UnidadID
                };
                conexion.flotaunidad.Add(nuevaFlotaUnidad);
                conexion.SaveChanges();
                _flotaUnidad = FlotaUnidad;
            }
        }

        public override FlotaUnidadModelo ObtenerFlotaUnidad()
        {
            if (_flotaUnidad == null)
            {
                return _flotaUnidad;
            }
            else
            {
                return null;
            }
        }
    }
}
