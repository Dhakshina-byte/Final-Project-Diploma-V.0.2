using System;
using System.Data.SqlClient;

namespace Finalproject.Services
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = "Data Source=OM3GA;Initial Catalog=AutomobileSalesServiceDB;Integrated Security=True";
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            return connection;
        }
    }
}