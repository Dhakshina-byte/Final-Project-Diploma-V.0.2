using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class InventoryService
    {
        private readonly SqlConnection conn;

        public InventoryService()
        {
            conn = DatabaseConnection.GetConnection();
        }

        public DataTable ShowInventory()
        {
            DataTable dt = new DataTable();
            conn.Close();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Inventory WHERE Category = 'Spare Parts'", conn);
            sda.Fill(dt);
            return dt;
        }
        public DataTable showtools()
        {
            DataTable dt = new DataTable();
            conn.Close();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Inventory WHERE Category = 'Tools'", conn);
            sda.Fill(dt);
            return dt;
        }

        public void InsertInventory(Inventory inventory)
        {

            string query = "INSERT INTO Inventory ( Inventory_item_name, Category, Per_price, Qty) " +
                           "VALUES (@Inventory_item_name, @Category, @Per_price, @Qty)";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                conn.Close();
                conn.Open();
                cmd.Parameters.AddWithValue("@Inventory_item_name", inventory.Inventory_item_name);
                cmd.Parameters.AddWithValue("@Category", inventory.Category);
                cmd.Parameters.AddWithValue("@Per_price", inventory.Per_price);
                cmd.Parameters.AddWithValue("@Qty", inventory.Qty);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateInventory(Inventory inventory)
        {

            string query = "UPDATE Inventory SET Serial_number = @Serial_number, Inventory_item_name = @Inventory_item_name, Category = @Category, " +
                           "Per_price = @Per_price, Qty = @Qty WHERE Inventory_ID = @Inventory_ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@Serial_number", inventory.Serial_number);
                cmd.Parameters.AddWithValue("@Inventory_ID", inventory.Inventory_ID);
                cmd.Parameters.AddWithValue("@Inventory_item_name", inventory.Inventory_item_name);
                cmd.Parameters.AddWithValue("@Category", inventory.Category);
                cmd.Parameters.AddWithValue("@Per_price", inventory.Per_price);
                cmd.Parameters.AddWithValue("@Qty", inventory.Qty);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteInventory(int inventoryId)
        {

            string query = "DELETE FROM Inventory WHERE Inventory_ID = @Inventory_ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@Inventory_ID", inventoryId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertRequest(Request request, Tools tools)
        {
            string query = "INSERT INTO Request (Request_type, Request_Qty, Request_Desc) " +
                           "VALUES (@Request_type, @Request_Qty, @Request_Desc); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            {
                conn.Close();
                conn.Open();
                cmd1.Parameters.AddWithValue("@Request_type", request.Request_type);
                cmd1.Parameters.AddWithValue("@Request_Qty", request.Request_Qty);
                cmd1.Parameters.AddWithValue("@Request_Desc", request.Request_Desc);
                int requestId = Convert.ToInt32(cmd1.ExecuteScalar());

                string query1 = "INSERT INTO Tools (User_ID, Request_ID, Tool_name, Tool_desc, Tool_status) " +
                               "VALUES (@User_ID, @Request_ID, @Tool_name, @Tool_desc, @Tool_status)";
                SqlCommand cmd2 = new SqlCommand(query1, conn);
                {
                    cmd2.Parameters.AddWithValue("@User_ID", tools.User_ID);
                    cmd2.Parameters.AddWithValue("@Request_ID", requestId);
                    cmd2.Parameters.AddWithValue("@Tool_name", tools.Tool_name);
                    cmd2.Parameters.AddWithValue("@Tool_desc", tools.Tool_desc);
                    cmd2.Parameters.AddWithValue("@Tool_status", tools.Tool_status);
                    cmd2.ExecuteNonQuery();
                }
            }
        }
        public void showTools()
        {
            DataTable dt = new DataTable();
            conn.Close();
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tools", conn);
            sda.Fill(dt);
        }

        public void insertreqestparts(Request request, SpareParts spareParts)
        {
            string query = "INSERT INTO Request (Request_type, Request_Qty, Request_Desc) " +
                           "VALUES (@Request_type, @Request_Qty, @Request_Desc); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            {
                conn.Close();
                conn.Open();
                cmd1.Parameters.AddWithValue("@Request_type", request.Request_type);
                cmd1.Parameters.AddWithValue("@Request_Qty", request.Request_Qty);
                cmd1.Parameters.AddWithValue("@Request_Desc", request.Request_Desc);
                int requestId = Convert.ToInt32(cmd1.ExecuteScalar());

                string query1 = "INSERT INTO SpareParts (Serial_number, User_ID, Request_ID, Spare_name, Spare_desc, Spare_status) " +
                               "VALUES (@Serial_number, @User_ID, @Request_ID, @Spare_name, @Spare_desc, @Spare_status)";
                SqlCommand cmd2 = new SqlCommand(query1, conn);
                {
                    cmd2.Parameters.AddWithValue("@Serial_number", spareParts.Serial_number);
                    cmd2.Parameters.AddWithValue("@User_ID", spareParts.User_ID);
                    cmd2.Parameters.AddWithValue("@Request_ID", requestId);
                    cmd2.Parameters.AddWithValue("@Spare_name", spareParts.Spare_name);
                    cmd2.Parameters.AddWithValue("@Spare_desc", spareParts.Spare_desc);
                    cmd2.Parameters.AddWithValue("@Spare_status", spareParts.Spare_status);
                    cmd2.ExecuteNonQuery();
                }
            }
        }
    }
}
