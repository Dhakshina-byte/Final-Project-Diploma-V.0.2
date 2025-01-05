using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable SearchServiceProgress(int id)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Service_Progress WHERE Vehicle_ID = @Vehicle_ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@Vehicle_ID", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;
        }

        public DataTable GetAllServiceProgress()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Service_Progress";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;
        }

        public void InsertServiceProgress(ServiceProgress progress)
        {

            string query = "INSERT INTO Service_Progress (Vehicle_ID, Booking_Date, Inspection, Maintain, Setup, Repair, wash, Status) " +
                       "VALUES (@Vehicle_ID, @Booking_Date, @Inspection, @Maintain, @Setup, @Repair, @wash, @Status)";

            SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Vehicle_ID", progress.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Booking_Date", progress.Booking_Date);
                cmd.Parameters.AddWithValue("@Inspection", progress.Inspection);
                cmd.Parameters.AddWithValue("@Maintain", progress.Maintain);
                cmd.Parameters.AddWithValue("@Setup", progress.Setup);
                cmd.Parameters.AddWithValue("@Repair", progress.Repair);
                cmd.Parameters.AddWithValue("@wash", progress.Wash);
                cmd.Parameters.AddWithValue("@Status", progress.Status);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateServiceProgress(ServiceProgress progress)
        {
            string query = "UPDATE Service_Progress SET Vehicle_ID = @Vehicle_ID, " +
                           "Status = @Status " +
                           "WHERE Progress_ID = @Progress_ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            {  conn.Close();
                cmd.Parameters.AddWithValue("@Progress_ID", progress.Progress_ID);
                cmd.Parameters.AddWithValue("@Vehicle_ID", progress.Vehicle_ID);
       
                cmd.Parameters.AddWithValue("@Status", progress.Status);

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
