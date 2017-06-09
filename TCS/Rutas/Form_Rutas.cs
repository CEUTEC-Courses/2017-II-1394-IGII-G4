using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.Rutas
{
    public partial class Form_Rutas : Form
    {
        public Form_Rutas()
        {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        private void btnAgregarPuntos_Click(object sender, EventArgs e)
        {
            using (var context = new TCS_Entities())
            {
                try
                {
                    context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                    context.Database.Connection.Open();
                    var nuevoPunto = context.punto.Add(new punto { NombrePunto = txtNombrePunto.Text });
                    context.SaveChanges();
                    txtNombrePunto.Clear();
                    MessageBox.Show("Punto agregado exitosamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear punto. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBorrarPuntos_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarPuntoOrigenNuevaRuta_Click(object sender, EventArgs e)
        {
            Form_Puntos formPuntos = new Form_Puntos();
            var resultado = formPuntos.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                if(formPuntos.NombreRutaSeleccionada != null)
                    btnSeleccionarPuntoOrigenNuevaRuta.Text = formPuntos.NombreRutaSeleccionada;
            }
        }

        private void btnSeleccionarPuntoDestinoRutaNueva_Click(object sender, EventArgs e)
        {
            Form_Puntos formPuntos = new Form_Puntos();
            var resultado = formPuntos.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                if (formPuntos.NombreRutaSeleccionada != null)
                    btnSeleccionarPuntoDestinoRutaNueva.Text = formPuntos.NombreRutaSeleccionada;
            }
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarAgregarRuta_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarOrigenRuta_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarDestinoRuta_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarRuta_Click(object sender, EventArgs e)
        {

        }
    }
}
