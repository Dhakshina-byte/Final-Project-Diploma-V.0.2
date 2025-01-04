using Bunifu.UI.WinForms;
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Finalproject.Views
{
    public partial class CEO : MaterialForm
    {
        // Controllers for handling various operations
        private readonly EmployeeController employeeController;
        private readonly VehicleController vehicleController;
        private readonly SalesController salesController;
        private NetProfitController controller;

        // Models for different entities
        private Vehicles vehicles;
        private Employee employee;
        private Department department;
        private Role role;
        private Login login;
        private SalesBudget salesBudget;

        public CEO()
        {
            InitializeComponent();
            // Initialize controllers
            employeeController = new EmployeeController();
            salesController = new SalesController();
            vehicleController = new VehicleController();

            // Initialize models
            employee = new Employee();
            department = new Department();
            vehicles = new Vehicles();
            role = new Role();
            login = new Login();
            salesBudget = new SalesBudget();

            // Initialize NetProfitController
            controller = new NetProfitController(this);

            // Initialize chart and material skin
            NetprofitChart();
            InitializeMaterialSkin();
        }

        // Method to initialize MaterialSkin
        private void InitializeMaterialSkin()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        // Method to initialize Net Profit chart
        private void NetprofitChart()
        {
            netprofitchart.Series.Clear();
            Series series = new Series("Net Profit")
            {
                ChartType = SeriesChartType.Line
            };
            netprofitchart.Series.Add(series);
            netprofitchart.ChartAreas.Add(new ChartArea("MainArea"));
        }

        // Method to update the chart with new data
        public void UpdateChart(NetProfitModel model)
        {
            netprofitchart.Series["Net Profit"].Points.AddXY(DateTime.Now.ToString("g"), model.NetProfit);
        }

        // Method to add a data point to the chart
        public void AddDataPointToChart(NetProfitModel model)
        {
            netprofitchart.Series["Net Profit"].Points.AddXY(model.CreatedAt.ToString("g"), model.NetProfit);
        }

        // Method to show profit data in a table
        public void ShowProfit()
        {
            DataTable dt = controller.Getprofit();
            NetProfittable.DataSource = dt;
        }

        // Event handler for form load
        private void CEO_Load(object sender, EventArgs e)
        {
            showAllEmployees();
            MonitorSalesBudget();
            cheakyear();
            ShowProfit();
            GenrateDyanmicVehicleDisplay();
            controller.LoadHistoricalData();
        }

        // Method to show all employees in a data grid
        private void showAllEmployees()
        {
            DataTable dt = employeeController.getEmployee();
            EmployeeDataGridView.DataSource = dt;
            Datagridsetup();
        }

        // Method to setup the data grid
        private void Datagridsetup()
        {
            EmployeeDataGridView.AllowUserToAddRows = false;
            Addbuttons();
        }

        // Method to add buttons to the data grid
        private void Addbuttons()
        {
            var deleteButton = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Width = 100,
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };

            EmployeeDataGridView.Columns.Insert(9, deleteButton);

            var editButton = new DataGridViewButtonColumn
            {
                Name = "EditButton",
                HeaderText = "Edit",
                Width = 100,
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };

            EmployeeDataGridView.Columns.Insert(10, editButton);
        }

        // Method to monitor sales budget and update the chart
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

        // Method to check the year and update button visibility
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

        // Event handler for Employees button click
        private void Employees_Click(object sender, EventArgs e)
        {

        }

        // Event handler for SET button click
        private void SETbtn_Click(object sender, EventArgs e)
        {
            Decimal BudgetAmount = Convert.ToDecimal(BudgetAssigntxtbox.Text);
            salesController.AddSalesTarget(BudgetAmount);
            cheakyear();
        }

        // Event handler for Extend button click
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

        // Event handler for role combobox selection change
        private void EmpRoleCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(EmpRoleCombobox.SelectedItem.ToString());
            if (EmpRoleCombobox.SelectedItem.ToString() == "Accountant")
            {
                DataTable dt = employeeController.getaccountant();
                EmployeeDataGridView.DataSource = dt;

                if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
                   EmployeeDataGridView.Columns["EditButton"] == null)
                {
                    Datagridsetup();
                }
            }
            else if (EmpRoleCombobox.SelectedItem.ToString() == "Sales Director")
            {
                DataTable dt = employeeController.getSalesDirector();
                EmployeeDataGridView.DataSource = dt;

                if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
                   EmployeeDataGridView.Columns["EditButton"] == null)
                {
                    Datagridsetup();
                }
            }
            else if (EmpRoleCombobox.SelectedItem.ToString() == "Inventory Manager")
            {
                DataTable dt = employeeController.getInventoryManager();
                EmployeeDataGridView.DataSource = dt;
                if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
                   EmployeeDataGridView.Columns["EditButton"] == null)
                {
                    Datagridsetup();
                }
            }
            else if (EmpRoleCombobox.SelectedItem.ToString() == "Service Head")
            {
                DataTable dt = employeeController.getServiceHead();
                EmployeeDataGridView.DataSource = dt;

                if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
                   EmployeeDataGridView.Columns["EditButton"] == null)
                {
                    Datagridsetup();
                }
            }
            else if (EmpRolebox.SelectedItem.ToString() == "All")
            {
                DataTable dt = employeeController.getEmployee();
                EmployeeDataGridView.DataSource = dt;

                if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
                   EmployeeDataGridView.Columns["EditButton"] == null)
                {
                    Datagridsetup();
                }
            }
        }

        // Event handler for save button click
        private void Empsavebtn_Click(object sender, EventArgs e)
        {
            employee.Name = EmpNametxtbox.Text;
            employee.Email = EmpEmailtxtbox.Text;
            employee.DOB = EmpDOBtxtbox.Text;
            employee.Mobile = EmpMobiletxtbox.Text;
            employee.City = EmpCitytxtbox.Text;
            employee.Address = EmpAddresstxtbox.Text;
            employee.username = EmpNametxtbox.Text;
            employee.Password = "root";
            int lastnum = employeeController.getthelastemp();
            lastnum++;
            login.EID = lastnum;
            Console.WriteLine(login.EID);

            if (EmpRolebox.SelectedItem.ToString() == "Accountant")
            {
                role.Role_ID = 1;
                department.D_ID = 3;
            }
            else if (EmpRolebox.SelectedItem.ToString() == "Sales Director")
            {
                role.Role_ID = 3;
                department.D_ID = 1;
            }
            else if (EmpRolebox.SelectedItem.ToString() == "Inventory Manager")
            {
                role.Role_ID = 2;
                department.D_ID = 3;
            }
            else if (EmpRolebox.SelectedItem.ToString() == "Service Head")
            {
                role.Role_ID = 4;
                department.D_ID = 2;
            }
            employeeController.AddLogine(employee, login);
            employeeController.AddEmployee(employee, role, department);
            Console.WriteLine(role.Role_ID);
            EmpNametxtbox.Text = "";
            EmpEmailtxtbox.Text = "";
            EmpDOBtxtbox.Text = "";
            EmpMobiletxtbox.Text = "";
            EmpCitytxtbox.Text = "";
            EmpAddresstxtbox.Text = "";
            DataTable dt = employeeController.getEmployee();
            EmployeeDataGridView.DataSource = dt;

            if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
               EmployeeDataGridView.Columns["EditButton"] == null)
            {
                Datagridsetup();
            }
        }

        // Event handler for data grid cell content click
        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EmployeeDataGridView.Columns["DeleteButton"].Index)
            {
                int EID = Convert.ToInt32(EmployeeDataGridView.Rows[e.RowIndex].Cells["EID"].Value);
                employeeController.DeleteEmployee(EID);

                DataTable dt = employeeController.getEmployee();
                EmployeeDataGridView.DataSource = dt;

                if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
                   EmployeeDataGridView.Columns["EditButton"] == null)
                {
                    Datagridsetup();
                }
            }
            else if (e.ColumnIndex == EmployeeDataGridView.Columns["EditButton"].Index)
            {
                DataGridViewRow rows1 = EmployeeDataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Are you sure you want to Edit this row?", rows1.Cells["EID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int EID = Convert.ToInt32(EmployeeDataGridView.Rows[e.RowIndex].Cells["EID"].Value);
                    employee.Name = rows1.Cells["EName"].Value.ToString();
                    employee.Email = rows1.Cells["Email"].Value.ToString();
                    employee.Mobile = rows1.Cells["Mobile"].Value.ToString();
                    employee.City = rows1.Cells["City"].Value.ToString();
                    employee.Address = rows1.Cells["Address"].Value.ToString();
                    employeeController.UpdateEmployee(employee, EID);
                }
                DataTable dt = employeeController.getEmployee();
                EmployeeDataGridView.DataSource = dt;

                if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
                   EmployeeDataGridView.Columns["EditButton"] == null)
                {
                    Datagridsetup();
                }
            }
        }

        // Event handler for search text box text change
        private void EmpSearchtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        // Event handler for search button click
        private void EmpSearchbtn_Click(object sender, EventArgs e)
        {
            EmpSearchtxtbox.Text = EmpSearchtxtbox.Text;
            var dt = employeeController.searchEmployee(EmpSearchtxtbox.Text);
            EmployeeDataGridView.DataSource = dt;
            if (EmployeeDataGridView.Columns["DeleteButton"] == null ||
               EmployeeDataGridView.Columns["EditButton"] == null)
            {
                Datagridsetup();
            }
        }

        // Event handler for chart click
        private void chart2_Click(object sender, EventArgs e)
        {

        }

        // Method to generate dynamic vehicle display
        private void GenrateDyanmicVehicleDisplay()
        {
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = vehicleController.GetVehicles();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    VehicleDisplay[] vehicleDisplay = new VehicleDisplay[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            DataRow[] rows = dt.Select();
                            vehicleDisplay[i] = new VehicleDisplay();
                            vehicleDisplay[i].VehicleName = row["Vehicle_name"].ToString();
                            vehicleDisplay[i].VehicleType = row["vehicle_model"].ToString();
                            MemoryStream ms = new MemoryStream((byte[])row["vehicle_image"]);
                            vehicleDisplay[i].Chassis_no = row["Chassis_no"].ToString();
                            vehicleDisplay[i].Icon = new Bitmap(ms);
                            flowLayoutPanel1.Controls.Add(vehicleDisplay[i]);
                        }
                    }
                }
            }
        }

        // Event handler for update price button click
        private void Updatepribtn_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(pricetxtbox.Text);
            string chassis_no = chassistxtbox.Text;
            vehicleController.UpdatePrice(price, chassis_no);
        }
    }
}
