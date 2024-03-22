using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Schools.Model;

namespace W3Schools
{
    /*
     * * gallery of windows forms: 
     * DPI mode (window containing other windows)
     * ShowDialog (windows w/ forced focus)
     */
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {

            Security security = new Security();
            LoginResult result = security.DoLogin(UsernameTextbox.Text, PasswordTextbox.Text);
            if (result.Success)
            {
                MessageBox.Show($"Access granted,\nwelcome back {result.ConnectedUser.FirstName}!");
                Session.GetInstance().Create(result.ConnectedUser);
                DialogResult = DialogResult.OK;
                
            }


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult =  DialogResult.Cancel;
        }

        private void PasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConnectButton.PerformClick();
            }
        }
    }
}
