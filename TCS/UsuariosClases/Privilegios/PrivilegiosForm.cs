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
using TCS.UsuariosClases.Privilegios;

namespace TCS.UsuariosClases
{
    public partial class PrivilegiosForm : Form
    {
        CRUDPrivilegio cp = new CRUDPrivilegio();
        public PrivilegiosForm()
        {
            InitializeComponent();
            agregarPrivilegio();
        }

        public void agregarPrivilegio()
        {
            var Lista = cp.consultar();

            foreach (var i in Lista)
            {
                mostrarPrivilegiosLV.Items.Add(i.ToString());
            }
        }
        private void PrivilegiosForm_Load(object sender, EventArgs e)
        {

        }

        private void guardarUsuarioBtn_Click(object sender, EventArgs e)
        {
            PrivilegioModelo nuevo = new PrivilegioModelo();
            nuevo.nombrePrivilegio = privilegioTxt.Text;
            
            if (cp.privilegioExiste(privilegioTxt.Text))
            {
                MessageBox.Show("El privilegio ya existe");
            }
            else if (privilegioTxt.Text == "")
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                cp.agregarPrivilegio(nuevo);
                MessageBox.Show("Privilegio creado correctamente");
                privilegioTxt.Text = "";
               
            }
            mostrarPrivilegiosLV.Items.Clear();
            agregarPrivilegio();
        }
    }
}
