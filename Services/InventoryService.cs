using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
        public void InsertInventory(Inventory inventory)
        {

            string query = "INSERT INTO Inventory (Serial_number, Inventory_item_name, Category, Per_price, Qty) " +
                           "VALUES (@Serial_number, @Inventory_item_name, @Category, @Per_price, @Qty)";
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                cmd.Parameters.AddWithValue("@Serial_number", inventory.Serial_number);
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
    }
}
