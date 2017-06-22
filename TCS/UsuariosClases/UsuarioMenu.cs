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
            agregarPrivilegioComboBox();
            crud_usuarios.consultarUsuarios(ref mostrarUsuarioLV);
        }

        private void guardarUsuarioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validacionesUsuariosExistentes.validaciones(userTxt, contrasenaTxt, privilegioCmb));

            userTxt.Text = "";
            contrasenaTxt.Text = "";
            privilegioCmb.Text = "";
            mostrarUsuarioLV.Items.Clear();
            crud_usuarios.consultarUsuarios(ref mostrarUsuarioLV);
        }

        public void agregarPrivilegioComboBox()
        {
            foreach (var i in crud_privilegios.consultar())
            {
                privilegioCmb.Items.Add(i.ToString());
            }
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarUsuariosBtn_Click(object sender, EventArgs e)
        {
                var idUsuarioAEliminar = Convert.ToInt32(mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[0].Text);
                crud_usuarios.eliminar(idUsuarioAEliminar);
                MessageBox.Show("Usuario Eliminado");
                mostrarUsuarioLV.Items.Clear();
                crud_usuarios.consultarUsuarios(ref mostrarUsuarioLV);
                        
        }

        private void privilegiosBtn_Click(object sender, EventArgs e)
        {
            PrivilegiosForm pf = new PrivilegiosForm();
            pf.ShowDialog();
        }

        private void modificarUsuariosBtn_Click(object sender, EventArgs e)
        {
            userTxt.Enabled = true;
            contrasenaTxt.Enabled = true;
            privilegioCmb.Enabled = true;

            mostrarUsuarioLV.Items.Clear();
            crud_usuarios.consultarUsuarios(ref mostrarUsuarioLV);
        }

        private void mostrarUsuarioLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            usuarioSeleccionado = e.ItemIndex;

            userTxt.Text= mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[1].Text;
            contrasenaTxt.Text = mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[2].Text;
            privilegioCmb.Text = mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[3].Text;
        }

        private void refrescarBtn_Click(object sender, EventArgs e)
        {
            privilegioCmb.Items.Clear();
            agregarPrivilegioComboBox();
        }

        private void nuevoUsuarioBtn_Click(object sender, EventArgs e)
        {
            userTxt.Enabled = true;
            contrasenaTxt.Enabled = true;
            privilegioCmb.Enabled = true;
        }
    }
}
