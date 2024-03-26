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
    public partial class MainForm : Form
    {
        Session session = Session.GetInstance();
        public MainForm()
        {
            InitializeComponent();
            session.OnCreated += Session_OnCreated;
            session.OnInvalidated += Session_OnInvalidated;
        }

        private void Session_OnInvalidated(object? sender, EventArgs e)
        {
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
        }


        private void Session_OnCreated(object? sender, EventArgs e)
        {
            loginToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = true;
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var risposta = MessageBox.Show("Sei sicuro di voler uscire?", "Esci", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (risposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!session.IsValid)
            {
                LoginForm loginForm = new();
                loginForm.ShowDialog();
            }
        }

        private void LoadProducts()
        {
            ProductsForm productsForm = new();
            productsForm.MdiParent = this;
            productsForm.Show();
        }

        private void LoadCustomers()
        {
            CustomersForm customersForm = new();
            customersForm.MdiParent = this;
            customersForm.Show();
            customersForm.WindowState = FormWindowState.Maximized;
        }


        private void LoadEmployees() { MessageBox.Show("Placeholder per tab Impiegati"); }


        private void showProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // todo (A CASA)
            ExecuteInSession(LoadProducts);

        }



        private void showEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteInSession(LoadEmployees);
        }
        void ExecuteInSession(Action action)
        {
            if (!session.IsValid)
            {
                LoginForm loginForm = new();
                if (loginForm.ShowDialog() == DialogResult.Yes)
                {
                    action();
                }
            }
            else
            {
                action();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new();
            loginForm.ShowDialog();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to log out?", caption: "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                session.Invalidate();
            }
        }

        private void showCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteInSession(LoadCustomers);
        }

    }

}
