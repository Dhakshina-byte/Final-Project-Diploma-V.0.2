﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class WashService
    {
        private readonly SqlConnection conn;
        public WashService()
        {
            conn = DatabaseConnection.GetConnection();
        }

        public DataTable showWash()
        {
            string query = "SELECT Wash.Wash_ID, Wash.Vehicle_ID, Wash.Repair_Date, Wash.Status, Vehicle.Number_Plate FROM Wash INNER JOIN Vehicle ON Wash.Vehicle_ID = Vehicle.Vehicle_ID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void InsertWash(Wash wash)
        {
            
                string query = "INSERT INTO Wash (Vehicle_ID, Repair_Date, Status) " +
                               "VALUES (@Vehicle_ID, @Repair_Date, @Status)";
                SqlCommand cmd = new SqlCommand(query, conn);
            { 
                conn.Close();
                cmd.Parameters.AddWithValue("@Vehicle_ID", wash.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Repair_Date", wash.Repair_Date);
                cmd.Parameters.AddWithValue("@Status", wash.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateWash(Wash wash)
        {
            
                string query = "UPDATE Wash SET Vehicle_ID = @Vehicle_ID, " +
                               "Status = @Status " +
                               "WHERE Wash_ID = @Wash_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Wash_ID", wash.Wash_ID);
                cmd.Parameters.AddWithValue("@Vehicle_ID", wash.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Status", wash.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteWash(int washId)
        {
           
                string query = "DELETE FROM Wash WHERE Wash_ID = @Wash_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Wash_ID", washId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
