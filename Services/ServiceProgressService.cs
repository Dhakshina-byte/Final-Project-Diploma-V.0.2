using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class ServiceProgressService
    {
        private readonly SqlConnection conn;

        public ServiceProgressService()
        {
            conn = DatabaseConnection.GetConnection();
        }

        public void InsertServiceProgress(ServiceProgress progress)
        {
        
                string query = "INSERT INTO Service_Progress (Booking_ID, Progress_Date, Progress_Description) " +
                               "VALUES (@Booking_ID, @Progress_Date, @Progress_Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Booking_ID", progress.Booking_ID);
                cmd.Parameters.AddWithValue("@Progress_Date", progress.Progress_Date);
                cmd.Parameters.AddWithValue("@Progress_Description", progress.Progress_Description);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateServiceProgress(ServiceProgress progress)
        {
            
                string query = "UPDATE Service_Progress SET Booking_ID = @Booking_ID, Progress_Date = @Progress_Date, " +
                               "Progress_Description = @Progress_Description WHERE Progress_ID = @Progress_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {  conn.Close();
                cmd.Parameters.AddWithValue("@Progress_ID", progress.Progress_ID);
                cmd.Parameters.AddWithValue("@Booking_ID", progress.Booking_ID);
                cmd.Parameters.AddWithValue("@Progress_Date", progress.Progress_Date);
                cmd.Parameters.AddWithValue("@Progress_Description", progress.Progress_Description);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteServiceProgress(int progressId)
        {
           
                string query = "DELETE FROM Service_Progress WHERE Progress_ID = @Progress_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@Progress_ID", progressId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
