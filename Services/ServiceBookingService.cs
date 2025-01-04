using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class ServiceBookingService
    {
        private readonly SqlConnection connection;

        public ServiceBookingService()
        {
            connection = DatabaseConnection.GetConnection();
        }
        public DataTable GetServiceBooking()
        {
            string query = "SELECT * FROM Service_Booking";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        public void InsertServiceBooking(ServiceBooking booking)
        {


           string query = "INSERT INTO Service_Booking (Vehicle_ID, Booking_Date, Inspection, Maintain, Setup, Repair,wash, Status) " +
                        "VALUES (@Vehicle_ID, @Booking_Date, @Inspection, @Maintain, @Setup, @Repair,@wash ,@Status)";
            SqlCommand cmd = new SqlCommand(query, connection);
            { 
                connection.Close();
                cmd.Parameters.AddWithValue("@Vehicle_ID", booking.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Booking_Date", booking.Booking_Date);
                cmd.Parameters.AddWithValue("@Inspection", booking.Inspection);
                cmd.Parameters.AddWithValue("@Maintain", booking.Maintain);
                cmd.Parameters.AddWithValue("@Setup", booking.Setup);
                cmd.Parameters.AddWithValue("@Repair", booking.Repair);
                cmd.Parameters.AddWithValue("@wash", booking.wash);
                cmd.Parameters.AddWithValue("@Status", booking.Status);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateServiceBooking(ServiceBooking booking)
        {

            string query = "UPDATE Service_Booking SET  Booking_Date = @Booking_Date, Setup = @Setup" +
                       "WHERE Booking_ID = @Booking_ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                cmd.Parameters.AddWithValue("@Booking_ID", booking.Booking_ID);
                cmd.Parameters.AddWithValue("@Booking_Date", booking.Booking_Date);
                cmd.Parameters.AddWithValue("@Status", booking.Status); ;

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteServiceBooking(int bookingId)
        {
            string query = "DELETE FROM Service_Booking WHERE Booking_ID = @Booking_ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                cmd.Parameters.AddWithValue("@Booking_ID", bookingId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
