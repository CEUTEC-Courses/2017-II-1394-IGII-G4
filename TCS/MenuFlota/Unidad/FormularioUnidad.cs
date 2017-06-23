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

namespace TCS.MenuFlota.Unidad
{
    public partial class FormularioUnidad : Form
    {
        CRUDUnidad _crudUnidad = new CRUDUnidad();
        public int _indexUnidadSeleccionada { get; set; }

        public FormularioUnidad()
        {
            InitializeComponent();
            listViewUnidades.ContextMenuStrip = contextMenuUnidad;
            _crudUnidad.MostrarListaUnidades(ref listViewUnidades);
        }

        private void ButtonMenuFlota_Click(object sender, EventArgs e)
        {
            Form_MenuFlota formularioMenuFlota = new Form_MenuFlota();
           formularioMenuFlota.Show();
            this.Hide();
        }

        private void buttonGuardarUnidad_Click(object sender, EventArgs e)
        {
            UnidadModelo unidad = new UnidadModelo();
            unidad.Placa = textBoxPlacaUnidad.Text;
            unidad.Marca = textBoxMarcaUnidad.Text;
            unidad.Modelo = textBoxModeloUnidad.Text;
            unidad.Estado = comboBoxEstadoUnidad.Text;
            unidad.Anio = new DateTime(Convert.ToInt32(añoUnidad.Value.Year),1,1);
        
           _crudUnidad.CrearUnidad(unidad);
           _crudUnidad.MostrarListaUnidades(ref listViewUnidades);
        }

        private void listViewUnidades_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _indexUnidadSeleccionada = e.ItemIndex;
        }

        private void FormularioUnidad_Load(object sender, EventArgs e)
        {

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxPlacaUnidad.Text = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[1].Text;
            textBoxMarcaUnidad.Text = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[2].Text;
            textBoxModeloUnidad.Text = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[3].Text;
            comboBoxEstadoUnidad.Text = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[4].Text;
            var año = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[5].Text;
            añoUnidad.Value = new DateTime(Convert.ToInt32(año), 1, 1);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Estas seguro de eliminar esta Unidad ?", "Eliminar Unidad ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var idUnidad = Convert.ToInt32(listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[0].Text);
                _crudUnidad.EliminarUnidad(idUnidad);
                MessageBox.Show("Unidad Eliminada");
                _crudUnidad.MostrarListaUnidades(ref listViewUnidades);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPlacaUnidad.Clear();
            textBoxMarcaUnidad.Clear();
            textBoxModeloUnidad.Clear();
            comboBoxEstadoUnidad.Text = "";
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            UnidadModelo unidad = new UnidadModelo();
            var idUnidad = Convert.ToInt32(listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[0].Text);
            unidad.UnidadID = idUnidad;
            unidad.Placa = textBoxPlacaUnidad.Text;
            unidad.Marca = textBoxMarcaUnidad.Text;
            unidad.Modelo = textBoxModeloUnidad.Text;
            unidad.Estado = comboBoxEstadoUnidad.Text;
            unidad.Anio = new DateTime(Convert.ToInt32(añoUnidad.Value.Year), 1, 1);
            _crudUnidad.ActualizarUnidad(unidad);
            _crudUnidad.MostrarListaUnidades(ref listViewUnidades);

        }

        private void listViewUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
