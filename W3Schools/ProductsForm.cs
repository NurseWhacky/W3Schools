using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Schools.Repository;

namespace W3Schools
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            ProductRepository repository = new();

            repository.Load();
            productBindingSource2.DataSource = repository.GetAll();
        }
    }
}
