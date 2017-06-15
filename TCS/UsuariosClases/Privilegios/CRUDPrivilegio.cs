using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;
using TCS.UsuariosClases.Privilegios;


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

        public void agregarPrivilegio(PrivilegioModelo privilegiomodel)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var nuevoPrivilegio = new privilegio()
                {
                    Nombre = privilegiomodel.nombrePrivilegio
                };

                conexion.privilegio.Add(nuevoPrivilegio);
                conexion.SaveChanges();
            }
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
    }
}
