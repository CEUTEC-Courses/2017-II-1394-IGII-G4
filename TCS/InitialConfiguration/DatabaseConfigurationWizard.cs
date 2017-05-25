using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS.InitialConfiguration
{
    public partial class DatabaseConfigurationWizard : Form
    {
        public DatabaseConfigurationWizard()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
            txtDB.Text = AppConfigurationManager.Instance().Database;
            txtServer.Text = AppConfigurationManager.Instance().Host;
            txtUser.Text = AppConfigurationManager.Instance().Username;
            txtPassword.Text = AppConfigurationManager.Instance().Password;
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            AppConfigurationManager.Instance().setConfiguration(txtServer.Text, txtUser.Text, txtPassword.Text, txtDB.Text);
            if(AppConfigurationManager.Instance().checkConfiguration())
            {
                MessageBox.Show("Conexion exitosa");
                saveBtn.Enabled = true;
            }
            else
            {
                saveBtn.Enabled = false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!AppConfigurationManager.Instance().commmitConfiguration())
                MessageBox.Show("Error al guardar la configuracion");
            else
                Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
