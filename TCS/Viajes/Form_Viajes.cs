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

        public List<int> ListarViajesPorNumero()
        {
            lvBusqueda.Items.Clear();
            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                var busqueda = (from cons in context.viaje select cons.ViajeID).ToList();
                MostrarBusquedaT(busqueda);
                return busqueda;
            }
        }

        public List<int?> ListarViajesPorFecha()
        {
            lvBusqueda.Items.Clear();
            using (var context = new TCS_Entities())
            {
                context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                context.Database.Connection.Open();
                var busqueda = context.FiltroFechasViajes(dtpFiltroDel.Value, dtpFiltroAl.Value).ToList();
                MostrarBusquedaF(busqueda);
                return busqueda;
            }
        }

        public void MostrarBusquedaF(List<int?> l)
        {
            foreach (var i in l)
            {
                lvBusqueda.Items.Add(i.ToString());
            }
        }

        public void MostrarBusquedaT(List<int> l)
        {
            foreach (var i in l)
            {
                lvBusqueda.Items.Add(i.ToString());
            }
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFiltroDel_ValueChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            ListarViajesPorFecha();
        }

        private void dtpFiltroAl_ValueChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            ListarViajesPorFecha();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ListarViajesPorNumero();
        }
    }
}
