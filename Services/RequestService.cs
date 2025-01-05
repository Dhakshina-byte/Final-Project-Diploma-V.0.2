using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class RequestService
    {
        private readonly SqlConnection conn;
    
        public RequestService() 
        {
            conn = DatabaseConnection.GetConnection();

        }

        public void InsertRequest(Request request)
        {
                
                var command = new SqlCommand("INSERT INTO Request (Request_Type, Request_Qty, Request_Desc) VALUES (@RequestType, @RequestQty, @RequestDesc)", conn);
            { 
            command.Parameters.AddWithValue("@RequestType", request.Request_type);
                command.Parameters.AddWithValue("@RequestQty", request.Request_Qty);
                command.Parameters.AddWithValue("@RequestDesc", request.Request_Desc);

                command.ExecuteNonQuery();
            }
        }

        // Method to update an existing request
        public void UpdateRequest(Request request)
        {
            
                conn.Open();
                var command = new SqlCommand("UPDATE Request SET Request_Type = @RequestType, Request_Qty = @RequestQty, Request_Desc = @RequestDesc WHERE Request_ID = @RequestID", conn);
            { 
            command.Parameters.AddWithValue("@RequestID", request.Request_ID);
                command.Parameters.AddWithValue("@RequestType", request.Request_type);
                command.Parameters.AddWithValue("@RequestQty", request.Request_Qty);
                command.Parameters.AddWithValue("@RequestDesc", request.Request_Desc);

                command.ExecuteNonQuery();
            }
        }

        // Method to delete a request
        public void DeleteRequest(int requestId)
        {
            
                conn.Open();
                var command = new SqlCommand("DELETE FROM Request WHERE Request_ID = @RequestID", conn);
            { 
            command.Parameters.AddWithValue("@RequestID", requestId);

                command.ExecuteNonQuery();
            }
        }
    }
}
