using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class MaintainService
    {
        private readonly SqlConnection conn;
        public MaintainService() 
        {
            conn = DatabaseConnection.GetConnection();
        }

        public void InsertMaintain(Maintain maintain)
        {
         
                string query = "INSERT INTO Maintain (Vehicle_ID, Maintain_Date, Description) " +
                               "VALUES (@Vehicle_ID, @Maintain_Date, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Vehicle_ID", maintain.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Maintain_Date", maintain.Maintain_Date);
                cmd.Parameters.AddWithValue("@Description", maintain.Description);

                conn.Open();
                conn.Close();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMaintain(Maintain maintain)
        {
            
                string query = "UPDATE Maintain SET Vehicle_ID = @Vehicle_ID, Maintain_Date = @Maintain_Date, " +
                               "Description = @Description WHERE Maintain_ID = @Maintain_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Maintain_ID", maintain.Maintain_ID);
                cmd.Parameters.AddWithValue("@Vehicle_ID", maintain.Vehicle_ID);
                cmd.Parameters.AddWithValue("@Maintain_Date", maintain.Maintain_Date);
                cmd.Parameters.AddWithValue("@Description", maintain.Description);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMaintain(int maintainId)
        {
           
                string query = "DELETE FROM Maintain WHERE Maintain_ID = @Maintain_ID";
                SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                cmd.Parameters.AddWithValue("@Maintain_ID", maintainId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
