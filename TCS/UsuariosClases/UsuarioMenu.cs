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
        CRUDPrivilegio c = new CRUDPrivilegio();
        CRUDUsuario cu = new CRUDUsuario();

        public int usuarioSeleccionado
        {
            get;
            set;
        }
       public UsuarioMenu()
        {
            InitializeComponent();
            agregarPrivilegioComboBox();
            cu.consultarUsuarios(ref mostrarUsuarioLV);
        }

        private void guardarUsuarioBtn_Click(object sender, EventArgs e)
        {
            UsuarioModelo nuevo = new UsuarioModelo();
            nuevo.Usuario = userTxt.Text;
            nuevo.password = contrasenaTxt.Text;
            nuevo.IdPrivilegio = c.devolverIdPrivilegio(privilegioCmb.Text);

            CRUDUsuario agregarU = new CRUDUsuario();
           
            if(cu.usuarioExiste(userTxt.Text))
            {
                MessageBox.Show("El usuario ya existe");
            }
            else if(userTxt.Text==""||contrasenaTxt.Text==""||privilegioCmb.Text=="")
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                agregarU.agregarUsuario(nuevo);
                MessageBox.Show("Usuario creado correctamente");
                userTxt.Text = "";
                contrasenaTxt.Text = "";
                privilegioCmb.Text = "";
            }
            mostrarUsuarioLV.Items.Clear();
            cu.consultarUsuarios(ref mostrarUsuarioLV);
        }

        private void privilegioCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrivilegiosForm pf = new PrivilegiosForm();
        }

        public void agregarPrivilegioComboBox()
        {
            var Lista=c.consultar();

            foreach (var i in Lista)
            {
                privilegioCmb.Items.Add(i.ToString());
            }
        }

        private void UsuarioMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarUsuariosBtn_Click(object sender, EventArgs e)
        {
                var idUsuarioAEliminar = Convert.ToInt32(mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[0].Text);
                cu.eliminar(idUsuarioAEliminar);
                MessageBox.Show("Usuario Eliminado");
            mostrarUsuarioLV.Items.Clear();
            cu.consultarUsuarios(ref mostrarUsuarioLV);
                        
        }

        private void privilegiosBtn_Click(object sender, EventArgs e)
        {
            PrivilegiosForm pf = new PrivilegiosForm();
            pf.ShowDialog();
        }

        private void modificarUsuariosBtn_Click(object sender, EventArgs e)
        {
            UsuarioModelo us = new UsuarioModelo();
            var idUsuario = Convert.ToInt32(mostrarUsuarioLV.Items[usuarioSeleccionado].SubItems[0].Text);
            us.Usuario = userTxt.Text;
            us.password = contrasenaTxt.Text;
            us.IdPrivilegio = c.devolverIdPrivilegio(privilegioCmb.Text);

            cu.modificarUsuario(us);
            mostrarUsuarioLV.Items.Clear();
            cu.consultarUsuarios(ref mostrarUsuarioLV);

            modificarUsuariosBtn.Enabled=false;
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
    }
}
