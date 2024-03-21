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
        public MainForm()
        {
            InitializeComponent();
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var risposta = MessageBox.Show("Sei sicuro di voler uscire?", "Esci", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(risposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
