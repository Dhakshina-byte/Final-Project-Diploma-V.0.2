using System;
using System.Data.SqlClient;

namespace Finalproject.Services
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection _instance = null;
        private static readonly object _lock = new object();
        private SqlConnection _connection;

        private DatabaseConnection()
        {
            // Rconnection string for @dhashina database
            //string connectionString = "Data Source=OM3GA;Initial Catalog=AutomobileSalesServiceDB;Integrated Security=True";

            //connection string for @dmkwelivitage database
            string connectionString = "Server=localhost;Database=AutomobileSalesServiceDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true";
            _connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                    return _instance;
                }
            }
        }

        public SqlConnection Connection
        {
            get
            {
                if (_connection.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}