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
            if(tipo=="NuevoUsuarioForm")
            {
                return new NuevoUsuarioForm();
            }

            if(tipo=="PrivilegiosForm")
            {
                return new PrivilegiosForm();
            }

            return new UsuarioMenu();
        }
    }
}
