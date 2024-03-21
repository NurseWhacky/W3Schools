using System.Data;
using System.Data.SqlClient;

namespace W3Schools
{
    public class DBManager
    {
        /* steps to connect to server:
         * - Server Address (Name / IP)\
         * - Instance                   |>>> ConnectionString
         * - Authentication            /
         */

        //private string ConnectionString = @"Data Source=ABAS110\KOS; Integrated Security=True;Initial Catalog=w3schools;"; // class scope (private)
        private string ConnectionString = @"data source=ABAS110\KOS;user id=sa;password=12345;initial catalog=w3schools;";

        //SqlDataReader reader = new();
        //SqlDataAdapter adapter;
        public bool Connect()
        {
            //string ConnectionString = @"Data Source=ABAS110\KOS; Integrated Security=True;Initial Catalog=w3schools;";
            using (SqlConnection connection = new(ConnectionString))
            {
                try
                {
                    connection.Open(); // implements IDisposable
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool UserExists(string username, string password)
        {
            //string sqlQuery = $"select username from users where username='{username}' and password='{password}'"; // Vulnerable to SQL Injections!
            string sqlQuery = "select username from users where username=@username and password=@password";
            using SqlConnection connection = new(ConnectionString);

            try
            {
                connection.Open();
                SqlCommand command = new(sqlQuery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = command.ExecuteReader();
                return reader.HasRows;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetDataTable(string query, Dictionary<string, object> parameters)
        {
            //create connection obj
            using SqlConnection connection = new(ConnectionString);
            connection.Open(); // attempt to establish connection
            SqlCommand command = new(query, connection); // sqlcommand object creation
            foreach (var param in parameters)
            {
                command.Parameters.AddWithValue(param.Key, param.Value);
            }
            // Adapter creation
            // sends sql command to DB server AND adapts data
            SqlDataAdapter dataAdapter = new(command);
            // instantiation of datatable
            DataTable result = new();
            // populate datatable w/ computed results 
            dataAdapter.Fill(result);
            return result; // ==> DataTable
        }

        public bool AlternativeConnect() // different using
        {
            using SqlConnection connection = new(ConnectionString);

            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
