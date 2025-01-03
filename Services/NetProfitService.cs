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
    public class NetProfitService
    {

        private readonly SqlConnection connection;

        public NetProfitService()
        {
            connection = DatabaseConnection.GetConnection();
        }

        public void AddNetProfit(NetProfitModel netProfit)
        {
            string query = "INSERT INTO NetProfit (Revenue, Expenses, NetProfit) VALUES (@Revenue, @Expenses, @NetProfit)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Revenue", netProfit.Revenue);
            command.Parameters.AddWithValue("@Expenses", netProfit.Expenses);
            command.Parameters.AddWithValue("@NetProfit", netProfit.NetProfit);
            command.ExecuteNonQuery();
        }
        public void NetprofitChart(Action<NetProfitModel> addDataPoint)
        {
            string query = "SELECT CreatedAt, NetProfit FROM NetProfit";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Close();
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NetProfitModel model = new NetProfitModel
                        {
                            CreatedAt = reader.GetDateTime(0),
                            NetProfit = reader.GetDecimal(1)
                        };
                        addDataPoint(model);
                    }
                }
            }
        }
        public DataTable GetNetProfit()
        {

            string query = "SELECT * FROM NetProfit";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Close();
                connection.Open();
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
