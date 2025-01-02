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

        public void checkyear()
        {
            string query = "SELECT Year  FROM Sales_Budget";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Open();
        }
        public void SetSalesTarget(SalesBudget budget)
        {
            string query = "INSERT INTO Sales_Budget (Year, Budget_amount, Department_ID) VALUES (@Year, @BudgetAmount, 1)";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                cmd.Parameters.AddWithValue("@Year", budget.Year);
                cmd.Parameters.AddWithValue("@BudgetAmount", budget.BudgetAmount);
                //cmd.Parameters.AddWithValue("@DepartmentID", budget.DepartmentID);
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
                cmd.Parameters.AddWithValue("@BudgetID", expense.BudgetID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public decimal GetRemainingAmount()
        {
            string query = "SELECT Sales_Budget.Budget_ID, Budget_amount - ISNULL(SUM(Expense_Amount), 0) AS RemainingAmount FROM Sales_Budget LEFT JOIN Budget_Expenses ON Sales_Budget.Budget_ID = Budget_Expenses.Budget_ID GROUP BY Sales_Budget.Budget_ID, Sales_Budget.Budget_amount";
            SqlCommand cmd = new SqlCommand(query, connection);
            decimal remainingAmount = 0;
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
    }
}

