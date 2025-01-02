using Finalproject.Controllers;
using Finalproject.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Finalproject.Views
{
    public partial class CEO : MaterialForm
    {
        private readonly SalesController salesController;
        private SalesBudget salesBudget;
        public CEO()
        {
            InitializeComponent();
            salesController = new SalesController();
            salesBudget = new SalesBudget();
            InitializeMaterialSkin();
        }
        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void CEO_Load(object sender, EventArgs e)
        {
            MonitorSalesBudget();
            cheakyear();
        }
        private void MonitorSalesBudget()
        {
            string connectionString = "Data Source=OM3GA;Initial Catalog=AutomobileSalesServiceDB;Integrated Security=True";
            string query = "SELECT Expense_Description, Expense_Amount FROM Budget_Expenses";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                chart1.Series.Clear();
                Series series = new Series("Budget");
                series.ChartType = SeriesChartType.Doughnut;
                chart1.Series.Add(series);

                double totalAmount = 0;
                Dictionary<string, double> expenses = new Dictionary<string, double>();

                while (reader.Read())
                {
                    string description = reader["Expense_Description"].ToString();
                    double amount = Convert.ToDouble(reader["Expense_Amount"]);
                    expenses[description] = amount;
                    totalAmount += amount;
                }

                foreach (var expense in expenses)
                {
                    double percentage = (expense.Value / totalAmount) * 100;
                    series.Points.AddXY($"{expense.Key} ({percentage:F2}%)", expense.Value);
                }

                reader.Close();
            }
            salesBudget.reminder = salesController.ReminderMethod();
            remindertxtbox.Text = salesBudget.reminder.ToString("C", new System.Globalization.CultureInfo("en-LK"));
        }
        private void cheakyear()
        {
            salesBudget.Year = salesController.Getyear();
            if (salesBudget.Year != DateTime.Now.Year)
            {
                SETbtn.Visible = true;
                Extendbtn.Visible = false;
            }
            else
            {
                SETbtn.Visible = false;
                Extendbtn.Visible = true;
            }
        }
        
        private void Employees_Click(object sender, EventArgs e)
        {

        }
        private void SETbtn_Click(object sender, EventArgs e)
        {
           Decimal BudgetAmount = Convert.ToDecimal(BudgetAssigntxtbox.Text);
            salesController.AddSalesTarget(BudgetAmount);
            cheakyear();
        }

        private void Extendbtn_Click(object sender, EventArgs e)
        {
            if (BudgetAssigntxtbox.Text != "")
            {

                Decimal BudgetAmount = Convert.ToDecimal(BudgetAssigntxtbox.Text);
                int year = DateTime.Now.Year;
                salesController.UpdateBudgetAmount(year, BudgetAmount);
                MonitorSalesBudget();
            }
        }
    }
}
