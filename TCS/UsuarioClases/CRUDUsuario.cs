using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;

namespace TCS.UsuarioClases
{
    public class CRUDUsuario
    {
        public void agregarUsuario(UsuarioModelo user)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                var nuevoUsuario = new usuario()
                {
                    Usuario1 = user.Usuario,
                    Contrasena = user.password,
                    IdPrivilegio = user.IdPrivilegio
                };

                conexion.usuario.Add(nuevoUsuario);
                conexion.SaveChanges();
            }
        }

        public List<string> consultarUsuarios()
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                var queryConsultarUsuario = (from consulta in conexion.usuario select consulta.Usuario1).ToList();
                return queryConsultarUsuario;
            }
        }


    }
}
