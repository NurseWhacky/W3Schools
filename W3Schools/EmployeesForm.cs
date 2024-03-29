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
using W3Schools.Repository;

namespace W3Schools
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            EmployeeRepository repository = new();
            repository.Load();
            employeeBindingSource.DataSource = repository.GetAll;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee selected = employeeBindingSource.Current as Employee;
            EmployeeEditForm form = new EmployeeEditForm(selected);
            form.ShowDialog();
        }
    }
}
