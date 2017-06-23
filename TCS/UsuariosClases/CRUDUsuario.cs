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
        public void agregarUsuario(string nombreUsuario, string contraseña, int idPrivilegio)
        {
                var nuevoUsuario = AppConfigurationManager.Instance().DbContext.usuario.Add(new usuario { Usuario1=nombreUsuario, Contrasena=contraseña, IdPrivilegio=idPrivilegio });
                AppConfigurationManager.Instance().DbContext.SaveChanges();
        }

        public void consultarUsuarios( ListView listaDeUsuarios)
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

        public void eliminarUsuarios(int id)
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

        public void modificarUsuario(string nombreUsuario, string contraseña, int idPrivilegio)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                CRUDUsuario validarId = new CRUDUsuario();
                int id = validarId.devolverIdUsuario(nombreUsuario);
                var query = (from modificar in conexion.usuario
                            where modificar.UsuarioID == id
                            select modificar).FirstOrDefault();

                query.Usuario1 = nombreUsuario;
                query.Contrasena = contraseña;
                query.IdPrivilegio = idPrivilegio;
                conexion.SaveChanges();
            }
        }

        public int devolverIdUsuario(string nombreUsuario)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var queryObtenerId = (from obtenerId in conexion.usuario
                                      where obtenerId.Usuario1==nombreUsuario
                                      select obtenerId.UsuarioID).FirstOrDefault();

                return queryObtenerId;
            }
        }
    }
}
