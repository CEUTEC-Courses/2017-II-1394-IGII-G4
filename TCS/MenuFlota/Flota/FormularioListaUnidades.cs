using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.MenuFlota.Unidad;

namespace TCS.MenuFlota.Flota
{
    public partial class FormularioListaUnidades : Form
    {
        private int _indexUnidadSeleccionada;
        private CRUDUnidad _crudUnidad = new CRUDUnidad();
        public  UnidadModelo unidad = new UnidadModelo();

        public FormularioListaUnidades()
        {
            InitializeComponent();
            _crudUnidad.MostrarListaUnidades(ref listViewUnidades);
        }

        private void buttonAgregarUnidad_Click(object sender, EventArgs e)
        {
           
            var idUnidad = Convert.ToInt32(listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[0].Text);
            unidad.UnidadID = idUnidad;
            unidad.Placa = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[1].Text;
            unidad.Marca = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[2].Text;
            unidad.Modelo = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[3].Text;
            unidad.Estado = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[4].Text;
            var año = listViewUnidades.Items[_indexUnidadSeleccionada].SubItems[5].Text;
            unidad.Anio  = new DateTime(Convert.ToInt32(año), 1, 1);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void listViewUnidades_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _indexUnidadSeleccionada = e.ItemIndex;
        }

        private void FormularioListaUnidades_Load(object sender, EventArgs e)
        {

        }

        //private void listViewUnidades_SelectedIndexChanged(object sender, EventArgs e)
        //{


        //}
    }
}
