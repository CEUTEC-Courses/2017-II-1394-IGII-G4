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

namespace TCS.MenuFlota
{
    public partial class Form_MenuFlota : Form
    {
        public Form_MenuFlota()
        {
            InitializeComponent();
        }

        private void MenuFlota_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormularioUnidad_Click(object sender, EventArgs e)
        {
            FormularioUnidad abrirFromularioUnidad = new FormularioUnidad();
            abrirFromularioUnidad.ShowDialog();

        }

        //private void ButtonMenuPrincipal_Click(object sender, EventArgs e)
        //{
        //    Form_Principal FormularioPrincipal = new Form_Principal();
        //    FormularioPrincipal.Show();
        //    this.Close();
        //}

        }
}
