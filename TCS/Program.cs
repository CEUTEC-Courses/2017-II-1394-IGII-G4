using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.InitialConfiguration;

namespace TCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Antes de poder correr la aplicacion debemos tener una conexion establecida a la base de datos
            if(AppConfigurationManager.Instance().checkDatabaseParameters())
                Application.Run(new Form_Principal());
            else
            {
                MessageBox.Show("Debe configurar primero los parametros de conexion");
                Application.Run(new DatabaseConfigurationWizard());

                if(AppConfigurationManager.Instance().checkDatabaseParameters())
                {
                    Application.Run(new Form_Principal());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
