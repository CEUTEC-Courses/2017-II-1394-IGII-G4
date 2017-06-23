using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS.UsuariosClases
{
    class FormsFactory
    {
        public Form getForms(string tipo)
        {
            if(tipo=="PrivilegiosForm")
            {
                return new PrivilegiosForm();
            }

            if(tipo=="UsuarioMenu")
            {
                return new UsuarioMenu();
            }
            return new UsuarioMenu();
        }
    }
}
