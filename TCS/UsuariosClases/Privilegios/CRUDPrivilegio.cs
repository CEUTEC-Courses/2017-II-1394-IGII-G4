using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.UsuariosClases
{
    public class CRUDPrivilegio
    {
        public List<string> consultar()
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();
                var queryObtenerPrivilegio = (from priv in conexion.privilegio select priv.Nombre).ToList();
                return queryObtenerPrivilegio;
            }
        }
    }
}
