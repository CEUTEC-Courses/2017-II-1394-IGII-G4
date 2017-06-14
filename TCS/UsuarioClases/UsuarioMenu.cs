using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.UsuarioClases;

namespace TCS
{
    public partial class UsuarioMenu : Form
    {
        CRUDPrivilegio c = new CRUDPrivilegio();
        CRUDUsuario cu = new CRUDUsuario();
        public UsuarioMenu()
        {
            InitializeComponent();
            agregarPrivilegioComboBox();
            agregarUsuario();
        }

        private void guardarUsuarioBtn_Click(object sender, EventArgs e)
        {
            UsuarioModelo nuevo = new UsuarioModelo();
            nuevo.Usuario = userTxt.Text;
            nuevo.password = contrasenaTxt.Text;
            nuevo.IdPrivilegio = privilegioCmb.SelectedIndex + 1;

            CRUDUsuario agregarU = new CRUDUsuario();
            agregarU.agregarUsuario(nuevo);

            MessageBox.Show("Usuario creado correctamente");
            mostrarUsuarioLV.Items.Clear();
            agregarUsuario();

        }

        private void privilegioCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void agregarPrivilegioComboBox()
        {
            var Lista=c.consultar();

            foreach (var i in Lista)
            {
                privilegioCmb.Items.Add(i.ToString());
            }
        }

        public void agregarUsuario()
        {
            foreach (var i in cu.consultarUsuarios())
            {
                mostrarUsuarioLV.Items.Add(i.ToString());
            }
        }

        private void UsuarioMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
