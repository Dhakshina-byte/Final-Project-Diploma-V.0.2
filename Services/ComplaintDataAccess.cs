using Finalproject.Models;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class ComplaintDataAccess
    {
        private readonly SqlConnection connection;

        public ComplaintDataAccess()
        {

            connection = DatabaseConnection.GetConnection();
        }

        public DataTable showcComplaints()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM CustomerComplaints";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Close();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            return dt;
        }
        public void AddComplaint(CustomerComplaint complaint)
        {

            string query = "INSERT INTO CustomerComplaints (CustomerName, ComplaintDate, ComplaintText, Status) VALUES (@CustomerName, @ComplaintDate, @ComplaintText, @Status)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Close();
               
                command.Parameters.AddWithValue("@CustomerName", complaint.CustomerName);
                command.Parameters.AddWithValue("@ComplaintDate", complaint.ComplaintDate);
                command.Parameters.AddWithValue("@ComplaintText", complaint.ComplaintText);
                command.Parameters.AddWithValue("@Status", "Pending");

                connection.Open();
                
                command.ExecuteNonQuery();
            }
        }

    }
}
