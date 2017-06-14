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
    public partial class Form_Puntos : Form
    {

        public String NombreRutaSeleccionada;
        public Form_Puntos()
        {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;

            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                listaPuntos.DisplayMember = "NombrePunto";
                listaPuntos.ValueMember = "NombrePunto";
                listaPuntos.DataSource = context.punto.ToList();             
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                NombreRutaSeleccionada = ((punto)this.listaPuntos.SelectedItem).NombrePunto;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }
    }
}
