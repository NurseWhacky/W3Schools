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
    public partial class EmployeeEditForm : Form
    {
        private Employee currentEmployee { get; set; }
        public EmployeeEditForm(Employee currentEmployee)
        {
            InitializeComponent();
            this.currentEmployee = currentEmployee;
        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
