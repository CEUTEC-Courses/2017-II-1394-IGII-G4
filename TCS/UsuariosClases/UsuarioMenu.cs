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
            crud_usuarios.consultarUsuarios(mostrarUsuarioLV);
            agregarPrivilegioComboBox();
        }
              
        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarUsuariosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var idUsuarioAEliminar = Convert.ToInt32(mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[0].Text);
                crud_usuarios.eliminarUsuarios(idUsuarioAEliminar);
                MessageBox.Show("Usuario Eliminado");
                mostrarUsuarioLV.Items.Clear();
                crud_usuarios.consultarUsuarios(mostrarUsuarioLV);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione un usuario");
            }                       
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
            try
            {     
                userTxt.Text = mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[1].Text;
                contrasenaTxt.Text = mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[2].Text;
                privilegioCmb.Text = crud_privilegios.devolverNombrePrivilegio(Convert.ToInt32(mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[3].Text));
                userTxt.Enabled = true;
                contrasenaTxt.Enabled = true;
                privilegioCmb.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione un usuario");
            }

            mostrarUsuarioLV.Items.Clear();
            crud_usuarios.consultarUsuarios(mostrarUsuarioLV);
        }

        private void mostrarUsuarioLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            usuarioSeleccionado = e.ItemIndex;
        }

        private void nuevoUsuarioBtn_Click(object sender, EventArgs e)
        {
            userTxt.Clear();
            contrasenaTxt.Clear();
            privilegioCmb.Text = "";
            userTxt.Enabled = true;
            contrasenaTxt.Enabled = true;
            privilegioCmb.Enabled = true;
        }

        private void guardarUsuarioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validacionesUsuariosExistentes.validaciones(userTxt, contrasenaTxt, privilegioCmb));
            mostrarUsuarioLV.Items.Clear();
            crud_usuarios.consultarUsuarios(mostrarUsuarioLV);
            
            userTxt.Enabled = false;
            contrasenaTxt.Enabled = false;
            privilegioCmb.Enabled = false;
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