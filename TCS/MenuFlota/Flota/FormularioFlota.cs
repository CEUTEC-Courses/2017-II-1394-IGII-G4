using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS.MenuFlota.Flota
{
    public partial class FormularioFlota : Form
    {
        public CRUDFlota _crudFlota = new CRUDFlota();
        public int _indexFlotaSeleccionada { get; set; }
        public FormularioFlota()
        {
            InitializeComponent();
            _crudFlota.MostrarListaFlota(ref listViewFlotas);
            listViewFlotas.ContextMenuStrip = contextMenuFlota;
            // listViewUnidades.ContextMenuStrip = contextMenuUnidad;
        }

        private void ButtonAgregarUnidadEnFlota_Click(object sender, EventArgs e)
        {
            FormularioListaUnidades formListaUnidades = new FormularioListaUnidades();
            var resultadoDialog = formListaUnidades.ShowDialog();
            bool existeID=false;

            if (resultadoDialog == DialogResult.OK)
            {
                if (formListaUnidades.unidad != null)
                {
                    foreach (DataGridViewRow item in dataGridViewUnidades.Rows)
                    {
                        existeID=item.Cells["ID"].Value.ToString() == formListaUnidades.unidad.UnidadID.ToString() ? true : false;     
                    }

                    if (existeID)
                    {
                        MessageBox.Show("Ya se agrego esta unidad, eliga otra");
                    }
                    else
                    {
                        dataGridViewUnidades.Rows.Add(formListaUnidades.unidad.UnidadID, formListaUnidades.unidad.Placa, formListaUnidades.unidad.Marca, formListaUnidades.unidad.Modelo);

                    }
                }
            }
        }

        private void buttonGuardarFlota_Click(object sender, EventArgs e)
        {
            FlotaModelo flota = new FlotaModelo();
            flota.Empresa = textBoxEmpresa.Text;
            flota.Dueno = textBoxDueño.Text;
            flota.Codigo = textBoxCodigo.Text;

            FlotaSimpleBuilder flotaBuilder = new FlotaSimpleBuilder();
            if (flotaBuilder.CrearFlota(flota))
            {
                var idFlota = flotaBuilder.obtenerIDFlota();
                MessageBox.Show(idFlota.ToString());

                FlotaUnidadModelo flotaUnidad = new FlotaUnidadModelo();
                FlotaUnidadSimpleBuilder crearFlotaUnidad = new FlotaUnidadSimpleBuilder();

                foreach (DataGridViewRow item in dataGridViewUnidades.Rows)
                {
                    int idUnidad = Convert.ToInt32(item.Cells["ID"].Value);
                    flotaUnidad.FlotaID = idFlota;
                    flotaUnidad.UnidadID = idUnidad;
                    crearFlotaUnidad.CrearFlotaUnidad(flotaUnidad);
                }
                _crudFlota.MostrarListaFlota(ref listViewFlotas);
            }     
        }

        private void listViewFlotas_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _indexFlotaSeleccionada = e.ItemIndex;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar esta Flota ?", "Eliminar Flota ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var idFlota = Convert.ToInt32(listViewFlotas.Items[_indexFlotaSeleccionada].SubItems[0].Text);
                _crudFlota.EliminarFlota(idFlota);
                MessageBox.Show("Flota Eliminada");
                _crudFlota.MostrarListaFlota(ref listViewFlotas);
            }

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxEmpresa.Text = listViewFlotas.Items[_indexFlotaSeleccionada].SubItems[1].Text;
            textBoxDueño.Text = listViewFlotas.Items[_indexFlotaSeleccionada].SubItems[2].Text;
            textBoxCodigo.Text = listViewFlotas.Items[_indexFlotaSeleccionada].SubItems[3].Text;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxEmpresa.Text = string.Empty;
            textBoxDueño.Text = string.Empty;
            textBoxCodigo.Text=string.Empty;
            dataGridViewUnidades.Rows.Clear();
        }
    }
}
