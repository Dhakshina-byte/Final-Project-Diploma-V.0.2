using Finalproject.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Finalproject.Services
{
    public class VehicleOwnerService
    {
        private readonly SqlConnection connection;

        // Constructor initializes the database connection
        public VehicleOwnerService()
        {
            connection = DatabaseConnection.GetConnection();
        }

        // Method to add a new vehicle owner
        public void AddVehicleOwner(VehicleOwner owner)
        {
            string query = "INSERT INTO VehicleOwner (Owner_Name, Owner_Mobile, Owner_Email, License_plate, PurchaseDate, TotalPrice) " +
                           "VALUES (@Owner_Name, @Owner_Mobile, @Owner_Email, @License_plate, @PurchaseDate, @TotalPrice)";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@Owner_Name", owner.Owner_Name);
                cmd.Parameters.AddWithValue("@Owner_Mobile", owner.Owner_Mobile);
                cmd.Parameters.AddWithValue("@Owner_Email", owner.Owner_Email);
                cmd.Parameters.AddWithValue("@License_plate", owner.License_plate);
                cmd.Parameters.AddWithValue("@PurchaseDate", owner.PurchaseDate);
                cmd.Parameters.AddWithValue("@TotalPrice", owner.TotalPrice);
                cmd.ExecuteNonQuery();
            }
        }

        // Method to get all vehicle owners
        public DataTable GetAllVehicleOwners()
        {
            string query = "SELECT * FROM VehicleOwner";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        // Method to get a vehicle owner by ID
        public DataTable GetVehicleOwnerById(int id)
        {
            string query = "SELECT * FROM VehicleOwner WHERE Owner_ID = @Owner_ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@Owner_ID", id);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        // Method to update vehicle owner details
        public void UpdateVehicleOwner(VehicleOwner owner)
        {
            string query = "UPDATE VehicleOwner SET Owner_Name = @Owner_Name, Owner_Mobile = @Owner_Mobile, Owner_Email = @Owner_Email, " +
                           "License_plate = @License_plate, PurchaseDate = @PurchaseDate, TotalPrice = @TotalPrice WHERE Owner_ID = @Owner_ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@Owner_Name", owner.Owner_Name);
                cmd.Parameters.AddWithValue("@Owner_Mobile", owner.Owner_Mobile);
                cmd.Parameters.AddWithValue("@Owner_Email", owner.Owner_Email);
                cmd.Parameters.AddWithValue("@License_plate", owner.License_plate);
                cmd.Parameters.AddWithValue("@PurchaseDate", owner.PurchaseDate);
                cmd.Parameters.AddWithValue("@TotalPrice", owner.TotalPrice);
                cmd.Parameters.AddWithValue("@Owner_ID", owner.Owner_ID);
                cmd.ExecuteNonQuery();
            }
        }

        // Method to delete a vehicle owner by ID
        public void DeleteVehicleOwner(int id)
        {
            string query = "DELETE FROM VehicleOwner WHERE Owner_ID = @Owner_ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@Owner_ID", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Method to search vehicle owners by name, mobile, or email
        public DataTable SearchVehicleOwners(string search)
        {
            string query = "SELECT * FROM VehicleOwner WHERE Owner_Name LIKE @search OR Owner_Mobile LIKE @search OR Owner_Email LIKE @search";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
