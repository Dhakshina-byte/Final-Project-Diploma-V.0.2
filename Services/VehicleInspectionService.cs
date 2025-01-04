using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class VehicleInspectionService
    {
        private readonly SqlConnection conn;

        public VehicleInspectionService()
        {
            conn = DatabaseConnection.GetConnection();
        }

        public void InsertVehicleInspection(VehicleInspection inspection)
        {

            string query = "INSERT INTO Vehicle_Inspection (Vehicle_ID, Inspection_Date, Inspector_DESC, Status) " +
                         "VALUES (@Vehicle_ID, @Inspection_Date, @Inspector_DESC, @Status)";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Vehicle_ID", inspection.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Inspection_Date", inspection.Inspection_Date);
                cmd.Parameters.AddWithValue("@Inspector_DESC", inspection.Inspector_DESC);
                cmd.Parameters.AddWithValue("@Status", inspection.Status);


                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateVehicleInspection(VehicleInspection inspection)
        {

            string query = "UPDATE Vehicle_Inspection SET Vehicle_ID = @Vehicle_ID, Inspection_Date = @Inspection_Date, " +
                       "Inspector_DESC = @Inspector_DESC, Status = @Status " +
                       "WHERE Inspection_ID = @Inspection_ID";
            {
                conn.Close();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Inspection_ID", inspection.Inspection_ID);
                cmd.Parameters.AddWithValue("@Vehicle_ID", inspection.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Inspection_Date", inspection.Inspection_Date);
                cmd.Parameters.AddWithValue("@Inspector_DESC", inspection.Inspector_DESC);
                cmd.Parameters.AddWithValue("@Status", inspection.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteVehicleInspection(int inspectionId)
        {

            string query = "DELETE FROM Vehicle_Inspection WHERE Inspection_ID = @Inspection_ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Inspection_ID", inspectionId);


                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
