using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS.UsuariosClases
{
    public partial class NuevoUsuarioForm : Form
    {
        CRUDUsuario crud_usuario = new CRUDUsuario();
        CRUDPrivilegio crud_privilegios = new CRUDPrivilegio();
        ValidacionesUsuarios validacionesUsuariosExistentes = new ValidacionesUsuarios();
        public NuevoUsuarioForm()
        {
            InitializeComponent();
            agregarPrivilegioComboBox();
        }

        private void guardarUsuarioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validacionesUsuariosExistentes.validaciones(userTxt, contrasenaTxt, privilegioCmb));

            userTxt.Text = "";
            contrasenaTxt.Text = "";
            privilegioCmb.Text = "";


        }

        public void agregarPrivilegioComboBox()
        {
            foreach (var i in crud_privilegios.consultarPrivilegios())
            {
                privilegioCmb.Items.Add(i.ToString());
            }
        }

    }
}
