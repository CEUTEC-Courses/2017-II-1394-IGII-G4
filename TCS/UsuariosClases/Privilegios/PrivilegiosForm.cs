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
    }
}
