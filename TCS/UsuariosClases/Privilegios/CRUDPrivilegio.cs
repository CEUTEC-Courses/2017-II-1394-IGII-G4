using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;
using TCS.UsuariosClases;

namespace TCS.UsuariosClases
{
    public class CRUDPrivilegio
    {
        public List<string> consultarPrivilegios()
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();
                var queryObtenerPrivilegio = (from priv in conexion.privilegio select priv.Nombre).ToList();
                return queryObtenerPrivilegio;
            }
        }

        public int devolverIdPrivilegio(string nombreP)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();
                var queryObtenerId = (from obtenerId in conexion.privilegio
                                      where obtenerId.Nombre == nombreP
                                      select obtenerId.IdPrivilegio).FirstOrDefault();
                return queryObtenerId;
            }
        }

        public string devolverNombrePrivilegio(int id)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();
                var queryObtenerNombre = (from obtenerNombre in conexion.privilegio
                                      where obtenerNombre.IdPrivilegio == id
                                      select obtenerNombre.Nombre).FirstOrDefault();
                return queryObtenerNombre;
            }
        }

        public void agregarPrivilegio(string nombre)
        {         
                var nuevoPrivilegio = AppConfigurationManager.Instance().DbContext.privilegio.Add(new privilegio { Nombre=nombre });
                AppConfigurationManager.Instance().DbContext.SaveChanges();
        }

        public bool privilegioExiste(string nombre)
        {
            bool r = false;
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();
                var query = from consulta in conexion.privilegio select consulta.Nombre;

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

        public void eliminarPrivilegio(int id)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var queryEliminarPrivilegio = (from eliminar in conexion.privilegio where eliminar.IdPrivilegio == id
                                                select eliminar).FirstOrDefault();

                conexion.privilegio.Remove(queryEliminarPrivilegio);
                conexion.SaveChanges();
            }
        }
    }
}
