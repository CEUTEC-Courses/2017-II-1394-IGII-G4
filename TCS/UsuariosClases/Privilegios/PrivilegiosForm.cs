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
        UsuarioMenu usuarioMenuForm = new UsuarioMenu();
        ValidacionesPrivilegios validaciones = new ValidacionesPrivilegios();
       
        public PrivilegiosForm()
        {
            InitializeComponent();
            agregarPrivilegio();
        }

        public void agregarPrivilegio()
        {
            var Lista = crud_privilegios.consultar();

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
            MessageBox.Show(validaciones.validacionesPr(privilegioTxt));

            privilegioTxt.Text = "";
            usuarioMenuForm.agregarPrivilegioComboBox();
            mostrarPrivilegiosLV.Items.Clear();
            agregarPrivilegio();       
        }

        private void borrarPrivilegiosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listItem = mostrarPrivilegiosLV.SelectedItems[0];
                string privilegioAEliminar = listItem.Text;
                crud_privilegios.eliminar(crud_privilegios.devolverIdPrivilegio(privilegioAEliminar));
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
