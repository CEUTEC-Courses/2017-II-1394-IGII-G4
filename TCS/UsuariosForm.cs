using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.Usuarios;

namespace TCS
{
    public partial class UsuariosForm : Form
    {
        consultarPrivilegio c = new consultarPrivilegio();
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            agregarPrivilegio();
        }

        void agregarPrivilegio()
        {
            foreach (var i in c.consulta())
            {
                privilegioUsuarioCmb.Items.Add(i.ToString());              
            }
        }
    }
}
