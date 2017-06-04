using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.UsuariosCarpeta
{
    class usuarioProgram
    {
        public List<string> consultarPrivilegio()
        {
            using (tcsdbEntities conexion = new tcsdbEntities())
            {
              var queryObtenerPrivilegio = (from priv in conexion.privilegio select priv.Nombre).ToList();
              return queryObtenerPrivilegio;
            }
        }

        public void insertarUsuario()
        {
            using (tcsdbEntities conexion = new tcsdbEntities())
            {
                var queryInsertarUsuario = ()
              
            }
        }
    }
}
