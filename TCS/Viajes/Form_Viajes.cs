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
using TCS.Viajes;

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

        CRUD_Viaje cViaje = new CRUD_Viaje();

        

        

        public string ObtenerDato(string tabla, string campo, string parametro)
        {
            string dato = "";

            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();


                return dato;
            }
        }

        public void MostrarBusquedaF(List<int?> l)
        {
            l = cViaje.ListarViajesPorFecha(dtpFechaPartida.Value, dtpFechaRegreso.Value);

            foreach (var i in l)
            {
                lvBusqueda.Items.Add(i.ToString());
            }
        }

        public void MostrarBusquedaT(List<int> l)
        {
            l = cViaje.ListarViajesPorNumero(txtBusqueda.Text);

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
            cViaje.ListarViajesPorFecha(dtpFechaPartida.Value, dtpFechaRegreso.Value);
        }

        private void dtpFiltroAl_ValueChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            cViaje.ListarViajesPorFecha(dtpFechaPartida.Value, dtpFechaRegreso.Value);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Length > 0)
            {
                cViaje.ListarViajesPorNumero(txtBusqueda.Text);
            }
            else
            {
                lvBusqueda.Items.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cViaje.CrearViaje(cmbUnidad.Text, dtpFechaPartida.Value, dtpFechaRegreso.Value, rtxtDescripcion.Text);
        }
    }
}