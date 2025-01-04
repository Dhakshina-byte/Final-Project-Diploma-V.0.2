﻿using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class RepairService
    {
        private readonly SqlConnection conn;

        public RepairService()
        {
            conn = DatabaseConnection.GetConnection();
        }
        public void InsertRepair(Repair repair)
        {

            string query = "INSERT INTO Repair (Vehicle_ID, Repair_Date, Repair_Description, Status) " +
                         "VALUES (@Vehicle_ID, @Repair_Date, @Repair_Description, @Status)";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Vehicle_ID", repair.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Repair_Date", repair.Repair_Date);
                cmd.Parameters.AddWithValue("@Repair_Description", repair.Repair_Description);
                cmd.Parameters.AddWithValue("@Status", repair.Status);


                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRepair(Repair repair)
        {
            string query = "UPDATE Repair SET Vehicle_ID = @Vehicle_ID, Repair_Date = @Repair_Date, " +
                      "Repair_Description = @Repair_Description, Status = @Status " +
                      "WHERE Repair_ID = @Repair_ID";

            SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Repair_ID", repair.Repair_ID);
                cmd.Parameters.AddWithValue("@Vehicle_ID", repair.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Repair_Date", repair.Repair_Date);
                cmd.Parameters.AddWithValue("@Repair_Description", repair.Repair_Description);
                cmd.Parameters.AddWithValue("@Status", repair.Status);


                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRepair(int repairId)
        {
         
                string query = "DELETE FROM Repair WHERE Repair_ID = @Repair_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Repair_ID", repairId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
