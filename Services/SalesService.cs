using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Services
{
    public class SalesService
    {
        private readonly SqlConnection connection;
     

        public SalesService()
        {
            connection = DatabaseConnection.GetConnection();

        }

       
        public void SetSalesTarget(Decimal BudgetAmount)
        {
            string query = "INSERT INTO Sales_Budget ( Budget_amount, Department_ID) VALUES ( @BudgetAmount, 1)";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                cmd.Parameters.AddWithValue("@BudgetAmount",BudgetAmount);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void SetSalesQuotas(BudgetExpense expense)
        {
            string query = "INSERT INTO Budget_Expenses (Expense_Description, Expense_Amount, Expense_Date, Budget_ID) VALUES (@Description, @Amount, @Date, @BudgetID)";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                cmd.Parameters.AddWithValue("@Description", expense.ExpenseDescription);
                cmd.Parameters.AddWithValue("@Amount", expense.ExpenseAmount);
                cmd.Parameters.AddWithValue("@Date", expense.ExpenseDate);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public decimal GetRemainingAmount()
        {
            string query = "SELECT Sales_Budget.Year, Budget_amount - ISNULL(SUM(Expense_Amount), 0) AS RemainingAmount FROM Sales_Budget LEFT JOIN Budget_Expenses ON Sales_Budget.Year = Budget_Expenses.Budget_ID GROUP BY Sales_Budget.Year, Sales_Budget.Budget_amount";
            SqlCommand cmd = new SqlCommand(query, connection);
            decimal remainingAmount = 0;
            connection.Close();
            connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    remainingAmount = reader.GetDecimal(reader.GetOrdinal("RemainingAmount"));
                }
            }
            connection.Close();
            return remainingAmount;
        }
        public int GetCurrentYearFromSalesBudget()
        {
            string query = "SELECT Year FROM Sales_Budget WHERE Year = YEAR(GETDATE())";
            SqlCommand cmd = new SqlCommand(query, connection);
            int currentYear = 0;
            connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    currentYear = reader.GetInt32(reader.GetOrdinal("Year"));
                }
            }
            connection.Close();
            return currentYear;
        }

        public void UpdateBudgetAmount(int year, decimal BudgetAmount)
        {
            string query = "UPDATE Sales_Budget SET Budget_amount = @NewBudgetAmount WHERE Year = @Year";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NewBudgetAmount", BudgetAmount);
            cmd.Parameters.AddWithValue("@Year", year);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}

