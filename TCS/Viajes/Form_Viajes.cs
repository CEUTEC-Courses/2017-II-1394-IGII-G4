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

namespace TCS
{
    public partial class Form_Viajes : Form
    {
        public Form_Viajes()
        {
            InitializeComponent();
        }

        private void Form_Viajes_Load(object sender, EventArgs e)
        {

        }

        private void CargarViajes ()
        {
            try
            {
                lbBusqueda.DataSource = null;
                lbBusqueda.Items.Clear();
                using (var context = new TCS_Entities())
                {
                    context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                    context.Database.Connection.Open();
                    lbBusqueda.DisplayMember = "No. Viaje";
                    lbBusqueda.ValueMember = "ViajeID";
                    //lbBusqueda.DataSource = context.viaje.
                    //{

                    //}
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ListarViajes()
        {
            try
            {
                using (var context = new TCS_Entities())
                {
                    context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                    context.Database.Connection.Open();
                    lbBusqueda.DisplayMember = "No.";
                    lbBusqueda.ValueMember = "ViajeID";
                    var busqueda = context.FiltroFechasViajes(dtpFiltroDel.Value, dtpFiltroAl.Value);
                    lbBusqueda.DataSource = busqueda;
                }
            }    
            catch(Exception e)
            {

            }
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFiltroDel_ValueChanged(object sender, EventArgs e)
        {
            ListarViajes();
        }

        private void dtpFiltroAl_ValueChanged(object sender, EventArgs e)
        {
            ListarViajes();
        }
    }
}
