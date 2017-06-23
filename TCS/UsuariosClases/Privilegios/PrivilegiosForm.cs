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
        CRUDPrivilegio crud_privilegios = new CRUDPrivilegio();
        ValidacionesPrivilegios validaciones = new ValidacionesPrivilegios();
       
        public PrivilegiosForm()
        {
            InitializeComponent();
            agregarPrivilegio();
        }

        public void agregarPrivilegio()
        {
            var Lista = crud_privilegios.consultarPrivilegios();

            foreach (var i in Lista)
            {
                mostrarPrivilegiosLV.Items.Add(i.ToString());
            }
        }
    
        private void guardarUsuarioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(validaciones.validacionesPr(privilegioTxt));
            UsuarioMenu um = new UsuarioMenu();
            privilegioTxt.Text = "";
            um.agregarPrivilegioComboBox();
            mostrarPrivilegiosLV.Items.Clear();
            agregarPrivilegio();       
        }

        private void borrarPrivilegiosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listItem = mostrarPrivilegiosLV.SelectedItems[0];
                string privilegioAEliminar = listItem.Text;
                crud_privilegios.eliminarPrivilegio(crud_privilegios.devolverIdPrivilegio(privilegioAEliminar));
                MessageBox.Show("Privilegio Eliminado");
                mostrarPrivilegiosLV.Items.Clear();
                agregarPrivilegio();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Seleccione un privilegio");
            }
            
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
