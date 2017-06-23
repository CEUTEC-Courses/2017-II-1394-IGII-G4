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
using TCS.UsuariosClases;

namespace TCS.Login
{
    public partial class LoginForm : Form
    {
        CRUDPrivilegio crud_privilegio = new CRUDPrivilegio();

        public LoginForm()
        {
            InitializeComponent();
            formatoContrasena();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public void formatoContrasena()
        {
           
            // Set the maximum length of text in the control to eight.
            contraseñaLogin.MaxLength = 8;
            // Assign the asterisk to be the password character.
            contraseñaLogin.PasswordChar = '*';
            // Change all text entered to be lowercase.
            contraseñaLogin.CharacterCasing = CharacterCasing.Lower;
            // Align the text in the center of the TextBox control.
            contraseñaLogin.TextAlign = HorizontalAlignment.Center;
        }

        private void EntrarLoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(usuariosLoginTxt.Text==""||contraseñaLogin.Text=="")
                {
                    MessageBox.Show("Llene todos los campos");
                }
                else
                {
                    if (validarUsuario(usuariosLoginTxt.Text))
                    {
                     if(validarContraseña(usuariosLoginTxt.Text, contraseñaLogin.Text))
                        {
                            Form_Principal abrirFormularioPrincipal = new Form_Principal();
                            this.Hide();
                            abrirFormularioPrincipal.Show();
                        }
                     else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario Incorrecto");
                    }
                }    
            }
            catch
            {
                
            }
        }

        public bool validarContraseña(string usuarioNombre, string contraseña)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var queryConsultarContraseña = (from consultarUsuario in conexion.usuario where consultarUsuario.Usuario1 == usuarioNombre select consultarUsuario.Contrasena);

                foreach (var i in queryConsultarContraseña)
                {
                    if (i != contraseña)
                    {
                        contraseñaLogin.Text = "";
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool validarUsuario(string usuario)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var queryConsultarUsuario = (from consultarUsuario in conexion.usuario where consultarUsuario.Usuario1 == usuario select consultarUsuario.Usuario1);

                foreach (var i in queryConsultarUsuario)
                {
                    if (i != usuario)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        }
      }