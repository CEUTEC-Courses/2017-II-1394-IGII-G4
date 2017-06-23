using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.Rutas;
using TCS.MenuFlota;
using TCS.UsuariosClases;

namespace TCS
{
    public partial class Form_Principal : Form
    {
       
        public Form_Principal()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            Form_Viajes frmViajes = new Form_Viajes();
            frmViajes.ShowDialog();

        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            Form_Rutas formRutas = new Form_Rutas();
            formRutas.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form miform;
            FormsFactory formularios = new FormsFactory();
            miform = formularios.getForms("UsuarioMenu");
            miform.ShowDialog();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void btnFlota_Click(object sender, EventArgs e)
        {
            Form_MenuFlota menuFlota = new Form_MenuFlota();
            menuFlota.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Form_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
