using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Schools.Model;

namespace W3Schools
{
    internal class Security
    {
        public LoginResult DoLogin(string username, string password)
        {
            string query = "select UserId, UserName, FirstName, LastName, Email from Users where username = @username and password = @password";

            Dictionary<string, object> parameters = new();
            parameters.Add("@username", username);
            parameters.Add("@password", password);

            DBManager manager = new DBManager();
            DataTable result = manager.GetDataTable(query, parameters);

            if(result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                return new LoginResult
                {
                    Success = true,
                    Error = "",
                    ConnectedUser = new User
                    {
                        UserId = Convert.ToInt32(row["UserId"]),
                        //UserName = row["UserName"].ToString(),
                        UserName = row["UserName"] as string ?? "",
                        FirstName = row["FirstName"] as string ?? "",
                        LastName = row["LastName"] as string ?? "",
                    }
                };
                

            }
            else
            {
                return new LoginResult
                {
                    Success = false,
                    Error = "Error",
                    ConnectedUser = null,

                };
                
            }
        }
    }
}
