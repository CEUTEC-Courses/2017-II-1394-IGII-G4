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
            LlenarCmbFlota();
            LlenarCmbRutas();
        }

        CRUD_Viaje cViaje = new CRUD_Viaje();

        public void MostrarBusquedaFecha(List<int> l)
        {
            l = cViaje.ListarViajesPorFecha(dtpFechaPartida.Value, dtpFechaRegreso.Value);

            foreach (var i in l)
            {
                lvBusqueda.Items.Add(i.ToString());
            }
        }

        public void MostrarBusquedaID(List<int> l)
        {
            try
            {
                int b = Convert.ToInt32(txtBusqueda.Text);

                l = cViaje.ListarViajesPorNumero(b);

                foreach (var i in l)
                {
                    lvBusqueda.Items.Add(i.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        //prueba

        private void LlenarCmbFlota()
        {
            cmbFlota.Items.Clear();
            for (int i = 0; i < cViaje.ListarFlota().Count; i++)
            {
                cmbFlota.Items.Add(cViaje.ListarFlota()[i].Empresa);
            }
        }

        private void LlenarCmbUnidades(string empresaflota)
        {
            cmbUnidad.Items.Clear();
            cmbUnidad.Text = "";

            for (int i = 0; i < cViaje.ListarUnidadesPorFlota(empresaflota).Count; i++)
            {
                cmbUnidad.Items.Add(cViaje.ListarUnidadesPorFlota(empresaflota)[i].Placa);
            }
        }

        private void LlenarCmbRutas()
        {
            cmbRuta.Items.Clear();
            for (int i = 0; i < cViaje.ListarRutas().Count; i++)
            {
                cmbRuta.Items.Add(cViaje.ListarRutas()[i].NombreRuta);
            }
        }

        public void Limpiar()
        {
            txtNumero.Text = "";
            cmbRuta.Text =
            cmbUnidad.Text = "";
            dtpFechaPartida.Value = DateTime.Now;
            dtpFechaRegreso.Value = DateTime.Now;
            rtxtDescripcion.Text = "";
        }

        public void LlenarCampos(int indice)
        {
            Limpiar();
            viaje v = cViaje.ListarViajesGeneral(indice);
            txtNumero.Text = v.ViajeID.ToString();
            cmbUnidad.Text = cViaje.ListarUnidadPorID(Convert.ToInt32(v.UnidadID)).Placa;
            cmbRuta.Text = cViaje.RetornarRuta(Convert.ToInt32(v.RutaID)).NombreRuta;
            dtpFechaPartida.Value = v.FechaPartida.Value;
            dtpFechaRegreso.Value = v.FechaRegreso.Value;
            rtxtDescripcion.Text = v.Descripcion;
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFiltroDel_ValueChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            MostrarBusquedaFecha(cViaje.ListarViajesPorFecha(dtpFechaPartida.Value, dtpFechaRegreso.Value));
        }

        private void dtpFiltroAl_ValueChanged(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            MostrarBusquedaFecha(cViaje.ListarViajesPorFecha(dtpFechaPartida.Value, dtpFechaRegreso.Value));
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Length > 0)
            {
                int b = Convert.ToInt32(txtBusqueda.Text);

                MostrarBusquedaID(cViaje.ListarViajesPorNumero(b));

            }
            else
            {
                lvBusqueda.Items.Clear();
            }
        }

        private void CrearViaje()
        {
            if (cmbUnidad.Text.Length > 0 || cmbRuta.Text.Length > 0)
            {
                cViaje.CrearViaje(cmbUnidad.Text, cmbRuta.Text, dtpFechaPartida.Value,
                                                    dtpFechaRegreso.Value, rtxtDescripcion.Text);
                MessageBox.Show("Viaje creado con éxito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar, revisar campos requeridos");
            }
            
        }

        private void ModificarViaje()
        {
            if (cmbUnidad.Text.Length > 0 || cmbRuta.Text.Length > 0)
            {
                cViaje.ModificarViaje(Convert.ToInt32(txtBusqueda.Text), cmbUnidad.Text, cmbRuta.Text,
                                        dtpFechaPartida.Value, dtpFechaRegreso.Value, rtxtDescripcion.Text);
                MessageBox.Show("Viaje modificado con éxito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al guardar, revisar campos requeridos");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text.Length > 0)
            {
                ModificarViaje();
            }
            else
            {
                CrearViaje();
            }
        }

        private void lvBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lvBusqueda_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                int indice = 0;
                indice = Convert.ToInt32(lvBusqueda.Items[e.ItemIndex].Text);
                LlenarCampos(indice);
            }
            catch
            {

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmbFlota_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarCmbUnidades(cmbFlota.SelectedItem.ToString());
            }
            catch
            {

            }
        }
    }
}