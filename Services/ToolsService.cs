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
    public class ToolsService
    {
        private readonly SqlConnection conn;

        public ToolsService()
        {
            conn = DatabaseConnection.GetConnection();
        }
        public DataTable ShowTools()
        {
            DataTable dt = new DataTable();
            conn.Close();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tools", conn);
            sda.Fill(dt);
            return dt;
        }
        public void InsertTool(Tools tool)
        {


            var command = new SqlCommand("INSERT INTO Tools (User_ID, Request_ID, Tool_name, Tool_desc, Tool_status) VALUES (@UserID, @RequestID, @ToolName, @ToolDesc, @ToolStatus)", conn);
            {
                conn.Close();
                conn.Open();
                command.Parameters.AddWithValue("@UserID", tool.User_ID);
                command.Parameters.AddWithValue("@RequestID", tool.Request_ID);
                command.Parameters.AddWithValue("@ToolName", tool.Tool_name);
                command.Parameters.AddWithValue("@ToolDesc", tool.Tool_desc);
                command.Parameters.AddWithValue("@ToolStatus", tool.Tool_status);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateTool(Tools tool)
        {

            var command = new SqlCommand("UPDATE Tools SET User_ID = @UserID, Request_ID = @RequestID, Tool_name = @ToolName, Tool_desc = @ToolDesc, Tool_status = @ToolStatus WHERE Tool_ID = @ToolID", conn);
            {
                conn.Close();
                conn.Open();
                command.Parameters.AddWithValue("@ToolID", tool.Tool_ID);
                command.Parameters.AddWithValue("@UserID", tool.User_ID);
                command.Parameters.AddWithValue("@RequestID", tool.Request_ID);
                command.Parameters.AddWithValue("@ToolName", tool.Tool_name);
                command.Parameters.AddWithValue("@ToolDesc", tool.Tool_desc);
                command.Parameters.AddWithValue("@ToolStatus", tool.Tool_status);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteTool(int toolId)
        {

            var command = new SqlCommand("DELETE FROM Tools WHERE Tool_ID = @ToolID", conn);
            {
                conn.Close();
                conn.Open();
                command.Parameters.AddWithValue("@ToolID", toolId);

                command.ExecuteNonQuery();
            }
        }

        public void InsertSparePart(SpareParts sparePart)
        {

            var command = new SqlCommand("INSERT INTO SpareParts (User_ID, Request_ID, Spare_name, Spare_desc, Spare_status) VALUES (@UserID, @RequestID, @SpareName, @SpareDesc, @SpareStatus)", conn);
            {
                conn.Close();
                conn.Open();
                command.Parameters.AddWithValue("@UserID", sparePart.User_ID);
                command.Parameters.AddWithValue("@RequestID", sparePart.Request_ID);
                command.Parameters.AddWithValue("@SpareName", sparePart.Spare_name);
                command.Parameters.AddWithValue("@SpareDesc", sparePart.Spare_desc);
                command.Parameters.AddWithValue("@SpareStatus", sparePart.Spare_status);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateSparePart(SpareParts sparePart)
        {
            
            var command = new SqlCommand("UPDATE SpareParts SET User_ID = @UserID, Request_ID = @RequestID, Spare_name = @SpareName, Spare_desc = @SpareDesc, Spare_status = @SpareStatus WHERE Spare_ID = @SpareID", conn);
            {
                conn.Close();
                conn.Open();
                command.Parameters.AddWithValue("@SpareID", sparePart.Spare_ID);
                command.Parameters.AddWithValue("@UserID", sparePart.User_ID);
                command.Parameters.AddWithValue("@RequestID", sparePart.Request_ID);
                command.Parameters.AddWithValue("@SpareName", sparePart.Spare_name);
                command.Parameters.AddWithValue("@SpareDesc", sparePart.Spare_desc);
                command.Parameters.AddWithValue("@SpareStatus", sparePart.Spare_status);

                command.ExecuteNonQuery();
            }
        }
    }
}
