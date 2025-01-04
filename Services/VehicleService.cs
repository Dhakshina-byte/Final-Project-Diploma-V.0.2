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
    public class VehicleService
    {
        private readonly SqlConnection _connection;

        public VehicleService()
        {
            _connection = DatabaseConnection.GetConnection();
        }

        public DataTable GetVehicles()
        {
            string query = "SELECT * FROM Vehicle WHERE Status='SALE'";
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

        public DataTable autosearchvehicle(string search) 
        {
            string query = "SELECT Vehicle_ID,Number_Plate FROM Vehicle WHERE Number_Plate LIKE @Number_Plate OR Vehicle_ID LIKE @Vehicle_ID";
            SqlCommand command = new SqlCommand(query, _connection);
            {
                _connection.Close();
                _connection.Open();
                command.Parameters.AddWithValue("@Number_Plate", "%" + search + "%");
                command.Parameters.AddWithValue("@Vehicle_ID", "%" + search + "%");
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
               da.Fill(dt);
                _connection.Close();
                return dt;
            }

        }
        public void InsertVehicle(Vehicles vehicle)
        {
                string query = "INSERT INTO Vehicle (Vehicle_name, Vehicle_type, Chassis_no, Engine_no, Price, vehicle_color, vehicle_model, vehicle_image, Manufacture_date, Status, Owner_ID, Number_Plate) " +
                               "VALUES (@Vehicle_name, @Vehicle_type, @Chassis_no, @Engine_no, @Price, @vehicle_color, @vehicle_model, @vehicle_image, @Manufacture_date, @Status, @Owner_ID, @Number_Plate)";
                SqlCommand cmd = new SqlCommand(query, _connection);
            { 
                cmd.Parameters.AddWithValue("@Vehicle_name", vehicle.Vehicle_name);
                cmd.Parameters.AddWithValue("@Vehicle_type", vehicle.Vehicle_type);
                cmd.Parameters.AddWithValue("@Chassis_no", vehicle.Chassis_no);
                cmd.Parameters.AddWithValue("@Engine_no", vehicle.Engine_no);
                cmd.Parameters.AddWithValue("@Price", vehicle.Price);
                cmd.Parameters.AddWithValue("@vehicle_color", vehicle.Vehicle_color);
                cmd.Parameters.AddWithValue("@vehicle_model", vehicle.Vehicle_model);
                cmd.Parameters.AddWithValue("@vehicle_image", vehicle.Vehicle_image);
                cmd.Parameters.AddWithValue("@Manufacture_date", vehicle.Manufacture_date);
                cmd.Parameters.AddWithValue("@Status", vehicle.Status);
                cmd.Parameters.AddWithValue("@Owner_ID", vehicle.Owner_ID);
                cmd.Parameters.AddWithValue("@Number_Plate", vehicle.Number_Plate);

                _connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateVehicle(Vehicles vehicle)
        {
           
                string query = "UPDATE Vehicle SET Vehicle_name = @Vehicle_name, Vehicle_type = @Vehicle_type, Chassis_no = @Chassis_no, Engine_no = @Engine_no, " +
                               "Price = @Price, vehicle_color = @vehicle_color, vehicle_model = @vehicle_model, vehicle_image = @vehicle_image, " +
                               "Manufacture_date = @Manufacture_date, Status = @Status, Owner_ID = @Owner_ID, Number_Plate = @Number_Plate " +
                               "WHERE Vehicle_ID = @Vehicle_ID";
                SqlCommand cmd = new SqlCommand(query, _connection);
            { 
                cmd.Parameters.AddWithValue("@Vehicle_ID", vehicle.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Vehicle_name", vehicle.Vehicle_name);
                cmd.Parameters.AddWithValue("@Vehicle_type", vehicle.Vehicle_type);
                cmd.Parameters.AddWithValue("@Chassis_no", vehicle.Chassis_no);
                cmd.Parameters.AddWithValue("@Engine_no", vehicle.Engine_no);
                cmd.Parameters.AddWithValue("@Price", vehicle.Price);
                cmd.Parameters.AddWithValue("@vehicle_color", vehicle.Vehicle_color);
                cmd.Parameters.AddWithValue("@vehicle_model", vehicle.Vehicle_model);
                cmd.Parameters.AddWithValue("@vehicle_image", vehicle.Vehicle_image);
                cmd.Parameters.AddWithValue("@Manufacture_date", vehicle.Manufacture_date);
                cmd.Parameters.AddWithValue("@Status", vehicle.Status);
                cmd.Parameters.AddWithValue("@Owner_ID", vehicle.Owner_ID);
                cmd.Parameters.AddWithValue("@Number_Plate", vehicle.Number_Plate);

            _connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteVehicle(int vehicleId)
        {
           

                string query = "DELETE FROM Vehicle WHERE Vehicle_ID = @Vehicle_ID";
                SqlCommand cmd = new SqlCommand(query, _connection);
            { 
                cmd.Parameters.AddWithValue("@Vehicle_ID", vehicleId);

            _connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
