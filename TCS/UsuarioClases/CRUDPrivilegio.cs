using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;

namespace TCS.UsuarioClases
{
    public class CRUDPrivilegio
    {
        public List<string> consultar()
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                var queryObtenerPrivilegio = (from priv in conexion.privilegio select priv.Nombre).ToList();
                return queryObtenerPrivilegio;
            }
        }
    }
}
