using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.UsuariosClases;

namespace TCS
{
    public partial class UsuarioMenu : Form
    {
        CRUDPrivilegio crud_privilegios = new CRUDPrivilegio();
        CRUDUsuario crud_usuarios = new CRUDUsuario();
        ValidacionesUsuarios validacionesUsuariosExistentes = new ValidacionesUsuarios();


        public int usuarioSeleccionado
        {
            get;
            set;
        }
       public UsuarioMenu()
        {
            InitializeComponent();
            crud_usuarios.consultarUsuarios(ref mostrarUsuarioLV);
        }

       
        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarUsuariosBtn_Click(object sender, EventArgs e)
        {
                var idUsuarioAEliminar = Convert.ToInt32(mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[0].Text);
                crud_usuarios.eliminarUsuarios(idUsuarioAEliminar);
                MessageBox.Show("Usuario Eliminado");
                mostrarUsuarioLV.Items.Clear();
                crud_usuarios.consultarUsuarios(ref mostrarUsuarioLV);
                        
        }

        private void privilegiosBtn_Click(object sender, EventArgs e)
        {
            Form miform;
            FormsFactory formularios=new FormsFactory();
            miform = formularios.getForms("PrivilegiosForm");
            miform.ShowDialog();
        }

        private void modificarUsuariosBtn_Click(object sender, EventArgs e)
        {
            NuevoUsuarioForm nu = new NuevoUsuarioForm();
    
            nu.userTxt.Text= mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[1].Text;
            nu.contrasenaTxt.Text = mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[2].Text;
            nu.privilegioCmb.Text = crud_privilegios.devolverNombrePrivilegio(Convert.ToInt32(mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[3].Text));
            nu.ShowDialog();
            mostrarUsuarioLV.Items.Clear();
            crud_usuarios.consultarUsuarios(ref mostrarUsuarioLV);
        }

        private void mostrarUsuarioLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            usuarioSeleccionado = e.ItemIndex;
        }


        private void nuevoUsuarioBtn_Click(object sender, EventArgs e)
        {
            Form miform;
            FormsFactory formularios = new FormsFactory();
            miform = formularios.getForms("NuevoUsuarioForm");
            miform.ShowDialog();
        }
    }
}
