using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Schools.Model;

namespace W3Schools.Repository
{
    internal class ProductRepository
    {
        private List<Product> products;

        //public List<Product> GetAll // Alt: as a method GetAll() { return products... }
        //{
        //    get
        //    {
        //        //incapsulation?
        //        return products ?? new();
        //    }
        //}

        public List<Product> GetAll() { return products ?? new(); } 

        public void Load()
        {
            DBManager manager = new();
            string sql = "select * from products";
            DataTable dataTable = manager.GetDataTable(sql, null);
            products = []; // <==== EMPTY the list!
            foreach (DataRow row in dataTable.Rows)
            {
                // 
                Product product = new()
                {
                    ProductId = Convert.ToInt32(row["ProductId"]),
                    CategoryId = Convert.ToInt32(row["CategoryId"]),
                    SupplierId = Convert.ToInt32(row["SupplierId"]),
                    Price = Convert.ToDecimal(row["Price"]),
                    ProductName = row["ProductName"] as string ?? "",
                    Unit = row["Unit"] as string ?? ""
                };
                products.Add(product); // <== REFILL the list!
            }
        }
    }
}
