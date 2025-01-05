using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class RequestStatusService
    {
        private readonly SqlConnection conn;

        public RequestStatusService()
        {
            conn = DatabaseConnection.GetConnection();
        }
        public void InsertRequestStatus(RequesStatus requestStatus)
        {
            
                var command = new SqlCommand("INSERT INTO RequestStatus (Request_ID, Request_Type, Request_Qty, Request_Desc, Request_Status, Request_Comments) VALUES (@RequestID, @RequestType, @RequestQty, @RequestDesc, @RequestStatus, @RequestComments)", conn);
            { 
                conn.Close();
                conn.Open();
                command.Parameters.AddWithValue("@RequestID", requestStatus.Request_ID);
                command.Parameters.AddWithValue("@RequestType", requestStatus.Request_type);
                command.Parameters.AddWithValue("@RequestQty", requestStatus.Request_Qty);
                command.Parameters.AddWithValue("@RequestDesc", requestStatus.Request_Desc);
                command.Parameters.AddWithValue("@RequestStatus", requestStatus.Request_Status);
                command.Parameters.AddWithValue("@RequestComments", requestStatus.Request_Comments);

                command.ExecuteNonQuery();
            }
        }

        // Method to update an existing request status
        public void UpdateRequestStatus(RequesStatus requestStatus)
        {
            
               
                var command = new SqlCommand("UPDATE RequestStatus SET Request_Type = @RequestType, Request_Qty = @RequestQty, Request_Desc = @RequestDesc, Request_Status = @RequestStatus, Request_Comments = @RequestComments WHERE Request_ID = @RequestID", conn);

            {
                conn.Close();
                conn.Open();
                command.Parameters.AddWithValue("@RequestID", requestStatus.Request_ID);
                command.Parameters.AddWithValue("@RequestType", requestStatus.Request_type);
                command.Parameters.AddWithValue("@RequestQty", requestStatus.Request_Qty);
                command.Parameters.AddWithValue("@RequestDesc", requestStatus.Request_Desc);
                command.Parameters.AddWithValue("@RequestStatus", requestStatus.Request_Status);
                command.Parameters.AddWithValue("@RequestComments", requestStatus.Request_Comments);

                command.ExecuteNonQuery();
            }
        }

        // Method to delete a request status
        public void DeleteRequestStatus(int requestId)
        {
           
             
                var command = new SqlCommand("DELETE FROM RequestStatus WHERE Request_ID = @RequestID", conn);
            { 
                conn.Close();
                conn.Open();
                command.Parameters.AddWithValue("@RequestID", requestId);

                command.ExecuteNonQuery();
            }
        }
    }
}
