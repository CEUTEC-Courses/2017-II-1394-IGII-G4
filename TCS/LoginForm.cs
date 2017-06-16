using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCS.Login
{
    public partial class LoginForm : Form
    {
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
            contraLogin.MaxLength = 8;
            // Assign the asterisk to be the password character.
            contraLogin.PasswordChar = '*';
            // Change all text entered to be lowercase.
            contraLogin.CharacterCasing = CharacterCasing.Lower;
            // Align the text in the center of the TextBox control.
            contraLogin.TextAlign = HorizontalAlignment.Center;
        }

    }
}
