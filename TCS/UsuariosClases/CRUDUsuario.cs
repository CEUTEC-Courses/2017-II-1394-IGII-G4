using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.UsuariosClases
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

                foreach (var i in query)
                {
                    if (i.ToString() == nombre)
                    {
                        r = true;
                    }
                }
            }
            return r;
        }

        public void consultarUsuarios(ref ListView listaDeUsuarios)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var queryConsultarUsuario = from user in conexion.usuario
                                            select new
                                            {
                                                idUsuario = user.UsuarioID,
                                                usuario = user.Usuario1,
                                                contra = user.Contrasena,
                                                idPrivilegio = user.IdPrivilegio,
                                              };

                foreach (var item in queryConsultarUsuario)
                {
                    ListViewItem lista = listaDeUsuarios.Items.Add(item.idUsuario.ToString());
                    lista.SubItems.Add(item.usuario.ToString());
                    lista.SubItems.Add(item.contra.ToString());
                    lista.SubItems.Add(item.idPrivilegio.ToString());
                    
                }
            }
        }

        public void eliminar(int id)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                usuario queryEliminarUsuario = (from eliminar in conexion.usuario
                                                where eliminar.UsuarioID == id
                                                select eliminar).FirstOrDefault();

                conexion.usuario.Remove(queryEliminarUsuario);
                conexion.SaveChanges();
            }
        }

        public void modificarUsuario(UsuarioModelo nombre)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var query = (from modificar in conexion.usuario
                            where modificar.Usuario1 == nombre.Usuario
                            select modificar).FirstOrDefault();
                query.Usuario1 = nombre.Usuario;
                query.Contrasena = nombre.password;
                query.IdPrivilegio = nombre.IdPrivilegio;

                conexion.SaveChanges();
            }

        }
    }
}
