using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3Schools
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            DBManager manager = new();
            bool userExists = manager.UserExists(UsernameTextbox.Text, PasswordTextbox.Text);
            if (userExists)
            {
                MessageBox.Show("Access granted", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Invalid credentials, access denied", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                ConnectButton.PerformClick();
            }
        }
    }
}
