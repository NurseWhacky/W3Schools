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
                return new LoginResult
                {
                    Success = true,
                    Error = null,
                    ConnectedUser = new User
                    {
                        UserId = Convert.ToInt32(result.Rows[0]["UserId"]),
                        UserName = result.Rows[0]["UserName"].ToString(),
                        FirstName = result.Rows[0]["FirstName"].ToString(),
                        LastName = result.Rows[0]["LastName"].ToString(),
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
