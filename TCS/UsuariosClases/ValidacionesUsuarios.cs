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
    public class ValidacionesUsuarios
    {
        CRUDUsuario crud_Usuario = new CRUDUsuario();
        CRUDPrivilegio crud_Privilegio = new CRUDPrivilegio();
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

        public bool usuarioIdExiste(int idUsuario)
        {
            bool r = false;
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var query = (from consulta in conexion.usuario select consulta.UsuarioID).ToList();

                foreach (var i in query)
                {
                    if (i == idUsuario)
                    {
                        r = true;
                        return r;                      
                    }
                }
            }
            return r;
        }

        public string validaciones(TextBox nombre, TextBox contraseña, ComboBox id)
        {
            string mensaje=" ";
            int idDevuelto;

            var camposVacios = nombre.Text == "" || contraseña.Text == "" || id.Text == "";
            if(camposVacios)
            {
                return mensaje = "Llene todos los campos";
            }

            var existe = usuarioIdExiste(crud_Usuario.devolverIdUsuario(nombre.Text));

            if (existe)
            {
                idDevuelto = crud_Privilegio.devolverIdPrivilegio(id.Text);
                crud_Usuario.modificarUsuario(nombre.Text, contraseña.Text,idDevuelto);
                return mensaje = "Usuario Modificado";
            }

            if(!existe)
            {
                var verificarUsuarioExiste = usuarioExiste(nombre.Text);
                if (verificarUsuarioExiste)
                {
                    return mensaje = "El usuario ya existe";
                }

                crud_Usuario.agregarUsuario(nombre.Text, contraseña.Text, crud_Privilegio.devolverIdPrivilegio(id.Text));
                return mensaje="Usuario creado correctamente";
                
                nombre.Enabled = false;
                contraseña.Enabled = false;
                id.Enabled = false;

            }

            return null;
        }
    }
}
