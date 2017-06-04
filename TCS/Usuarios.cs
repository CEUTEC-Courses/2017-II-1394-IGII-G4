using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.UsuariosCarpeta;

namespace TCS
{
    
    public partial class Usuarios : Form
    {
        usuarioProgram u = new usuarioProgram();
        public Usuarios()
        {
            InitializeComponent();
            agregarPrivilegio();     
        }

        private void privilegiosCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void agregarPrivilegio()
        {
            foreach (var i in u.consultarPrivilegio())
            {
                privilegiosCmb.Items.Add(i.ToString());
            }
        }
    }
}
