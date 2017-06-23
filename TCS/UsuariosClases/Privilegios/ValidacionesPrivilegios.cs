using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.UsuariosClases.Privilegios
{
    public class ValidacionesPrivilegios
    {
        CRUDPrivilegio crud_privilegios = new CRUDPrivilegio();
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

        public string validacionesPr(TextBox nombre)
        {
            string mensaje = " ";

            var camposVacios = nombre.Text == "";

            if (camposVacios)
            {
                return mensaje = "Llene todos los campos";
            }

            var verificarPrivilegioExiste = privilegioExiste(nombre.Text);

            if (verificarPrivilegioExiste)
            {
                return mensaje = "El privilegio ya existe";
            }
            else
            { 
                crud_privilegios.agregarPrivilegio(nombre.Text.Trim());
                return mensaje = "Privilegio creado correctamente";
            }

            return mensaje;
        }
    }
}
