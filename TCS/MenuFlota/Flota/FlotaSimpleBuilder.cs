using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.MenuFlota.Flota
{
    public class FlotaSimpleBuilder : FlotaBuilder
    {
        private FlotaModelo _flota;
        public override bool CrearFlota(FlotaModelo flota)
        {
             using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                ValidacionesFlota validaciones = new ValidacionesFlota();

                if (validaciones.ExitenValidaciones(flota))
                {
                    return false;
                }

                var nuevaFlota = new flota()
                {
                    Empresa=flota.Empresa,
                    Dueno=flota.Dueno,
                    Codigo=flota.Codigo
                };
                conexion.flota.Add(nuevaFlota);
                conexion.SaveChanges();
                _flota = flota;
                return true;
           }
     }

        public override FlotaModelo obtenerFlota()
        {
           if (_flota == null)
            {
                return _flota;
            }
            else
            {
                return null;
            }
        }

        public override int obtenerIDFlota()
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var idFlota = conexion.flota.Where(x => x.Empresa == _flota.Empresa).Select(x =>x.FlotaID).FirstOrDefault();
                return Convert.ToInt32(idFlota);
              
            }
        }
    }
}
