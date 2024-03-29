using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Schools.Model;

namespace W3Schools.Repository
{
    internal class EmployeeRepository
    {
        private List<Employee> employees = [];

        public List<Employee> GetAll
        {
            get
            {
                return employees ?? new();
            }
        }
        
        public Employee GetById(int id)
        {
            //var queryResult = from e in employees 
            //                  where e.EmployeeId == id
            //                  select e;
            //return employees.FirstOrDefault(queryResult)
            //return employees.FirstOrDefault(em => em.EmployeeId == id);
            return employees.SingleOrDefault(em => em.EmployeeId == id);
        }

        public void Load()
        {
            DBManager manager = new();
            string query = "select * from employees";
            DataTable table = manager.GetDataTable(query, null);

            foreach(DataRow row in table.Rows)
            {
                Employee em = new()
                {
                    EmployeeId = Convert.ToInt32(row["EmployeeId"]),
                    FirstName = row["FirstName"] as string ?? "",
                    LastName = row["LastName"] as string ?? "",
                    BirthDate = Convert.ToDateTime(row["BirthDate"]),
                    Photo = row["Photo"] as string ?? "No photo",
                    Notes = row["Notes"] as string ?? "Nothing to say about this motherfucker"
                };
                employees.Add(em);
            }
        }

    }
}
