using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class SetupService
    {
        private readonly SqlConnection conn;
        
        public SetupService() 

        {
            conn = DatabaseConnection.GetConnection();
        }
        public void InsertSetup(Setup setup)
        {
          
                string query = "INSERT INTO Setup (Vehicle_ID, Setup_Date, Setup_Details) " +
                               "VALUES (@Vehicle_ID, @Setup_Date, @Setup_Details)";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Vehicle_ID", setup.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Setup_Date", setup.Setup_Date);
                cmd.Parameters.AddWithValue("@Setup_Details", setup.Setup_Details);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSetup(Setup setup)
        {
           
                string query = "UPDATE Setup SET Vehicle_ID = @Vehicle_ID, Setup_Date = @Setup_Date, " +
                               "Setup_Details = @Setup_Details WHERE Setup_ID = @Setup_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Setup_ID", setup.Setup_ID);
                cmd.Parameters.AddWithValue("@Vehicle_ID", setup.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Setup_Date", setup.Setup_Date);
                cmd.Parameters.AddWithValue("@Setup_Details", setup.Setup_Details);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSetup(int setupId)
        {
            
                string query = "DELETE FROM Setup WHERE Setup_ID = @Setup_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Setup_ID", setupId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
