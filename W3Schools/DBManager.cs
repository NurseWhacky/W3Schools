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
        public bool Connect()
        {
            string ConnectionString = @"Data Source=ABAS110\KOS; Integrated Security=True;Initial Catalog=w3schools;";
            using (SqlConnection connection = new(ConnectionString))
            {
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
}
