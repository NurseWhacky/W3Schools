using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Schools.Model;

namespace W3Schools.Repository
{
    internal class CustomerRepository
    {
        private List<Customer> customers;

        public List<Customer> GetAll
        {
            get
            {
                return customers ?? new();
            }
        }

        public void Load()
        {
            // step 1: instantiate manager
            DBManager manager = new();
            // step 2: sqlString
            string query = "select * from customers";
            // step 3: instatiate datatable
            DataTable table = manager.GetDataTable(query, null);
            // step 3.5: empty the (already empty) customerlist
            customers = [];
            foreach (DataRow row in table.Rows)
            {
                Customer customer = new()
                {
                    CustomerId = Convert.ToInt32(row["CustomerId"]),
                    CustomerName = row["CustomerName"] as string ?? "",
                    ContactName = row["ContactName"] as string ?? "",
                    Address = row["Address"] as string ?? "",
                    City = row["City"] as string ?? "",
                    Country = row["Country"] as string ?? "",
                    PostalCode = row["PostalCode"] as string ?? "",
                };
                customers.Add(customer);
            }
        }
    }
}
