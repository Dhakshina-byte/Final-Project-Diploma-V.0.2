using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public void InsertServiceBooking(ServiceBooking booking)
        {
            
            
                string query = "INSERT INTO Service_Booking (Vehicle_ID, Booking_Date, Service_Type, Status) " +
                               "VALUES (@Vehicle_ID, @Booking_Date, @Service_Type, @Status)";
                SqlCommand cmd = new SqlCommand(query, connection);
            { 
                connection.Close();
                cmd.Parameters.AddWithValue("@Vehicle_ID", booking.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Booking_Date", booking.Booking_Date);
                cmd.Parameters.AddWithValue("@Service_Type", booking.Service_Type);
                cmd.Parameters.AddWithValue("@Status", booking.Status);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateServiceBooking(ServiceBooking booking)
        {
            
                string query = "UPDATE Service_Booking SET Vehicle_ID = @Vehicle_ID, Booking_Date = @Booking_Date, " +
                               "Service_Type = @Service_Type, Status = @Status WHERE Booking_ID = @Booking_ID";
                SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                cmd.Parameters.AddWithValue("@Booking_ID", booking.Booking_ID);
                cmd.Parameters.AddWithValue("@Vehicle_ID", booking.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Booking_Date", booking.Booking_Date);
                cmd.Parameters.AddWithValue("@Service_Type", booking.Service_Type);
                cmd.Parameters.AddWithValue("@Status", booking.Status);

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
