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

        int clicks = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            clicks++;
            ClickMe.Text = $"# of clicks: {clicks}";
            
        }
    }
}
