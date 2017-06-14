using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.UsuarioClases
{
    public class CRUDUsuario
    {
        public void agregarUsuario(UsuarioModelo user)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

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

        public bool usuarioExiste(string nombre)
        {
            bool r = false;
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

               var query = from consulta in conexion.usuario select consulta.Usuario1;
               
                foreach(var i in query)
                {
                    if (i.ToString() == nombre)
                    {
                        r = true;
                    }
                }             
            }
            return r;    
        }

        public List<string> consultarUsuarios()
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var queryConsultarUsuario = (from consulta in conexion.usuario select consulta.Usuario1).ToList();
                return queryConsultarUsuario;
            }
        }
    }
}
