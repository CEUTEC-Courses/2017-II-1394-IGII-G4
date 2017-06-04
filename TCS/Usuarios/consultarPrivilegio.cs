using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;

namespace TCS.Usuarios
{
    public class consultarPrivilegio
    {
        public List<string> consulta()
        {
            using (DatabaseModelContainer conexion = new DatabaseModelContainer())
            {
                var queryObtenerPrivilegio = (from priv in conexion.privilegios select priv.Nombre).ToList();
                return queryObtenerPrivilegio;
            }
        }
    }
}
