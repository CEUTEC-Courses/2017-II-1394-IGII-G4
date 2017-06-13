﻿using System;
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
            comboFiltro.SelectedIndex = 0;
            RefreshRutas();
        }

        private void RefreshRutas()
        {
            try
            {
                listaRutasDisponibles.DataSource = null;
                listaRutasDisponibles.Items.Clear();
                using (var context = new TCS_Entities())
                {
                    context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                    context.Database.Connection.Open();
                    listaRutasDisponibles.DisplayMember = "NombreRuta";
                    listaRutasDisponibles.ValueMember = "NombreRuta";
                    if (txtBusqueda.TextLength > 0)
                    {
                        switch (comboFiltro.SelectedIndex)
                        {
                            case 0:
                                listaRutasDisponibles.DataSource = context.ruta.Where(r => r.NombreRuta.Contains(txtBusqueda.Text)).ToList();
                                break;
                            case 1:
                                var puntoOrigen = context.punto.Where(p => p.NombrePunto.Contains(txtBusqueda.Text)).FirstOrDefault();
                                if(puntoOrigen != null)
                                    listaRutasDisponibles.DataSource = context.ruta.Where(r => r.IDPuntoOrigen == puntoOrigen.PuntoID).ToList();
                                break;
                            case 2:
                                var puntoDestino = context.punto.Where(p => p.NombrePunto.Contains(txtBusqueda.Text)).FirstOrDefault();
                                if(puntoDestino != null)
                                    listaRutasDisponibles.DataSource = context.ruta.Where(r => r.IDPuntoDestino == puntoDestino.PuntoID).ToList();
                                break;
                            default:
                                listaRutasDisponibles.DataSource = context.ruta.Where(r => r.NombreRuta.Contains(txtBusqueda.Text)).ToList();
                                break;
                        }
                    }
                    else
                    {
                        listaRutasDisponibles.DataSource = context.ruta.ToList();
                    }
                }

                RefreshPuntosRuta();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al actualizar lista de rutas. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshPuntosRuta()
        {
            if (listaRutasDisponibles.Items.Count > 0 && listaRutasDisponibles.SelectedItem != null)
            {
                listaPuntosRuta.DataSource = null;
                listaPuntosRuta.Items.Clear();
                using (var context = new TCS_Entities())
                {
                    context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                    context.Database.Connection.Open();
                    listaPuntosRuta.DisplayMember = "NombrePunto";
                    listaPuntosRuta.ValueMember = "NombrePunto";
                    listaPuntosRuta.DataSource = context.punto.Join(context.rutapunto, p => p.PuntoID, rp => rp.PuntoID, (p, rp) => new { NombrePunto = p.NombrePunto, RutaID = rp.RutaID }).Where(rp => rp.RutaID == ((ruta)listaRutasDisponibles.SelectedItem).RutaID).ToList();
                }
            }
            else
            {
                listaPuntosRuta.DataSource = null;
                listaPuntosRuta.Items.Clear();
            }
        }

        private void btnAgregarPuntos_Click(object sender, EventArgs e)
        {
            if (txtNombrePunto.Text.Length > 0)
            {
                try
                {
                    PuntoSimpleBuilder puntoBuilder = new PuntoSimpleBuilder();
                    if (puntoBuilder.crearPunto(txtNombrePunto.Text))
                    {
                        txtNombrePunto.Clear();
                        MessageBox.Show("Punto agregado exitosamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombrePunto.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear punto. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre al punto a crear.");
            }
        }

        private void btnBorrarPuntos_Click(object sender, EventArgs e)
        {
            Form_Puntos formPuntos = new Form_Puntos();
            formPuntos.Text = "Seleccionar Punto a Borrar";
            var resultado = formPuntos.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                if (formPuntos.NombreRutaSeleccionada != null)
                {
                    String puntoABorrar = formPuntos.NombreRutaSeleccionada;
                    using (var context = new TCS_Entities())
                    {
                        try
                        {
                            context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                            context.Database.Connection.Open();
                            var punto = context.punto.Where(p => p.NombrePunto == puntoABorrar).FirstOrDefault<punto>();
                            context.punto.Remove(punto);
                            context.SaveChanges();
                            MessageBox.Show("Punto borrado exitosamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al borrar punto. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
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
            if (txtNombreRutaNueva.Text.Length > 0)
            {
                try
                {
                    RutaSimpleBuilder rutaBuilder = new RutaSimpleBuilder();
                    if (rutaBuilder.crearRuta(txtNombreRutaNueva.Text, btnSeleccionarPuntoOrigenNuevaRuta.Text, btnSeleccionarPuntoDestinoRutaNueva.Text)) ;
                    {
                        txtNombreRutaNueva.Clear();
                        RefreshRutas();
                        MessageBox.Show("Ruta agregada exitosamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear ruta. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre a la ruta nueva.");
            }
        }
        
        private void limpiarInfoRuta()
        {
            btnSeleccionarPuntoDestinoRutaNueva.Text = "Seleccionar Punto";
            btnSeleccionarPuntoOrigenNuevaRuta.Text = "Seleccionar Punto";
            txtNombreRutaNueva.Clear();
            listaRutasDisponibles.SelectedIndex = -1;
            listaPuntosRuta.DataSource = null;
            listaPuntosRuta.Items.Clear();
            btnModificarRuta.Enabled = false;
            btnAgregarRuta.Enabled = true;
        }

        private void btnLimpiarAgregarRuta_Click(object sender, EventArgs e)
        {
            limpiarInfoRuta();
        }

        private void btnModificarRuta_Click(object sender, EventArgs e)
        {
            using (var context = new TCS_Entities())
            {
                try
                {
                    context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                    context.Database.Connection.Open();
                    var ruta = context.ruta.Where(r => r.RutaID == ((ruta)listaRutasDisponibles.SelectedItem).RutaID).FirstOrDefault();
                    ruta.NombreRuta = txtNombreRutaNueva.Text;
                    ruta.IDPuntoDestino = context.punto.Where(p => p.NombrePunto == btnSeleccionarPuntoDestinoRutaNueva.Text).FirstOrDefault().PuntoID;
                    ruta.IDPuntoOrigen = context.punto.Where(p => p.NombrePunto == btnSeleccionarPuntoOrigenNuevaRuta.Text).FirstOrDefault().PuntoID;
                    context.SaveChanges();
                    RefreshRutas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar informacion de ruta. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listaRutasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaRutasDisponibles.Items.Count > 0 && listaRutasDisponibles.SelectedItem != null)
            {
                txtNombreRutaNueva.Text = ((ruta)listaRutasDisponibles.SelectedItem).NombreRuta;
                using (var context = new TCS_Entities())
                {
                    try
                    {
                        context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                        context.Database.Connection.Open();
                        btnSeleccionarPuntoOrigenNuevaRuta.Text = context.punto.Where(p => p.PuntoID == ((ruta)listaRutasDisponibles.SelectedItem).IDPuntoOrigen).FirstOrDefault().NombrePunto;
                        btnSeleccionarPuntoDestinoRutaNueva.Text = context.punto.Where(p => p.PuntoID == ((ruta)listaRutasDisponibles.SelectedItem).IDPuntoDestino).FirstOrDefault().NombrePunto;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener informacion de ruta. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                RefreshPuntosRuta();
                btnModificarRuta.Enabled = true;
                btnAgregarRuta.Enabled = false;
            }
        }

        private void listaPuntosRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaPuntosRuta.Items.Count > 0 && listaPuntosRuta.SelectedItem != null)
            {
                dynamic punto = listaPuntosRuta.SelectedItem;
                txtNombrePunto.Text = punto.NombrePunto;
                btnAgregarPuntos.Enabled = false;
                btnModificarPunto.Enabled = true;
            }
        }

        private void btnModificarPunto_Click(object sender, EventArgs e)
        {
            using (var context = new TCS_Entities())
            {
                try
                {
                    context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                    context.Database.Connection.Open();
                    dynamic puntoSeleccionado = listaPuntosRuta.SelectedItem;
                    String nombrePunto = puntoSeleccionado.NombrePunto;
                    var punto = context.punto.Where(p => p.NombrePunto == nombrePunto).FirstOrDefault();
                    punto.NombrePunto = txtNombrePunto.Text;
                    context.SaveChanges();
                    RefreshPuntosRuta();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar informacion de punto. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limpiarInfoPunto()
        {
            txtNombrePunto.Clear();
            btnModificarPunto.Enabled = false;
            btnAgregarPuntos.Enabled = true;
            listaPuntosRuta.SelectedIndex = -1;
        }

        private void btnLimpiarPunto_Click(object sender, EventArgs e)
        {
            limpiarInfoPunto();
        }

        private void btnAgregarPuntoARuta_Click(object sender, EventArgs e)
        {
            Form_Puntos formPuntos = new Form_Puntos();
            var resultado = formPuntos.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                if (formPuntos.NombreRutaSeleccionada != null)
                {
                    RutaPuntoSimpleBuilder rutaPuntoBuilder = new RutaPuntoSimpleBuilder();
                    
                    using (var context = new TCS_Entities())
                    {
                        try
                        {
                            context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                            context.Database.Connection.Open();
                            if (rutaPuntoBuilder.crearRutaPunto(((ruta)listaRutasDisponibles.SelectedItem), context.punto.Where(p => p.NombrePunto == formPuntos.NombreRutaSeleccionada).FirstOrDefault()));
                                RefreshPuntosRuta();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al agregar punto a ruta. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnBorrarPuntoDeRuta_Click(object sender, EventArgs e)
        {
            if (listaPuntosRuta.SelectedItem != null)
            {
                using (var context = new TCS_Entities())
                {
                    try
                    {
                        context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                        context.Database.Connection.Open();
                        dynamic puntoEnLista = listaPuntosRuta.SelectedItem;
                        String nombrePunto = puntoEnLista.NombrePunto;
                        var punto = context.punto.Where(p => p.NombrePunto == nombrePunto).FirstOrDefault();
                        //Chequear si punto no es Origen o Destino
                        if(punto.PuntoID != ((ruta)listaRutasDisponibles.SelectedItem).IDPuntoOrigen && punto.PuntoID != ((ruta)listaRutasDisponibles.SelectedItem).IDPuntoDestino)
                        {
                            var rutapunto = context.rutapunto.Where(rp => rp.PuntoID == punto.PuntoID).Where(rp => rp.RutaID == ((ruta)listaRutasDisponibles.SelectedItem).RutaID).First();
                            context.rutapunto.Remove(rutapunto);
                            context.SaveChanges();
                            RefreshPuntosRuta();
                        }
                        else
                        {
                            MessageBox.Show("No se puede borrar un punto que es origen o destino de la ruta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al borrar punto de ruta. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBorrarRuta_Click(object sender, EventArgs e)
        {
            if (listaRutasDisponibles.SelectedItem != null && listaRutasDisponibles.Items.Count > 0)
            {
                using (var context = new TCS_Entities())
                {
                    try
                    {
                        context.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                        context.Database.Connection.Open();
                        var ruta = context.ruta.Where(r => r.RutaID == ((ruta)listaRutasDisponibles.SelectedItem).RutaID).First();
                        context.ruta.Remove(ruta);
                        context.SaveChanges();
                        limpiarInfoRuta();
                        limpiarInfoPunto();
                        RefreshRutas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al borrar ruta. Mensaje : " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            RefreshRutas();
        }
    }
}
