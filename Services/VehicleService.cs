using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class VehicleService
    {
        private readonly SqlConnection _connection;

        public VehicleService()
        {
            _connection = DatabaseConnection.GetConnection();
        }

        public DataTable GetVehicles()
        {
            string query = "SELECT * FROM Vehicle";
            SqlCommand command = new SqlCommand(query, _connection);
            {
                _connection.Close();
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                _connection.Close();
                return dt;
            }
        }

      public void UpdatePrice(string chassisNo, decimal price)
        {
            _connection.Close();
            _connection.Open();
            string query = "UPDATE Vehicle SET Price = @Price WHERE Chassis_no = @Chassis_no";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@Chassis_no", chassisNo);
           
            int result = command.ExecuteNonQuery();
          
            
        }
    }
}
