using Finalproject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Finalproject.Services
{

    // EmployeeService class provides methods to manage employee data
    public class EmployeeService
    {
        private readonly SqlConnection connection;

        // Constructor initializes the database connection
        public EmployeeService()
        {
            connection = DatabaseConnection.GetConnection();
        }

        // Method to get the last employee ID
        

        // Method to add a login entry for an employee
        public void AddLogine(Employee employee)
        {
            string query1 = "INSERT INTO Login (Username,Password,EID) VALUES (@Username,@Password,@EID)";
            SqlCommand cmd1 = new SqlCommand(query1, connection);
            {
                connection.Close();
                connection.Open();
                cmd1.Parameters.AddWithValue("@Username", employee.username);
                cmd1.Parameters.AddWithValue("@Password", employee.Password);

                // Get the EID from Employee table
                string getEIDQuery = "SELECT EID FROM Employee WHERE Email = @Email";
                SqlCommand getEIDCmd = new SqlCommand(getEIDQuery, connection);
                getEIDCmd.Parameters.AddWithValue("@Email", employee.Email);
                int EID = (int)getEIDCmd.ExecuteScalar();

                cmd1.Parameters.AddWithValue("@EID", EID);
                cmd1.ExecuteNonQuery();
            }
        }

        // Method to add a new employee
        public void AddEmployee(Employee employee, Role role, Department department)
        {
            string query = "INSERT INTO Employee (EName,Email, Mobile, City, Address, Role_ID,Department_ID) VALUES (@EName,@Email, @Mobile, @City, @Address, @Role_ID,@Department_ID)";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@EName", employee.Name);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
                cmd.Parameters.AddWithValue("@City", employee.City);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@Role_ID", role.Role_ID);
                cmd.Parameters.AddWithValue("@Department_ID", department.D_ID);
                cmd.ExecuteNonQuery();
            }
        }

        // Method to get all employees
        public DataTable getemployee()
        {
            string query = "SELECT E.EID,E.EName,E.Email,E.Mobile,E.City,E.Address,R.Role_Name,D.D_name AS Department_Name,D.D_location AS Department_Location FROM Employee E INNER JOIN Roles R ON E.Role_ID = R.Role_ID INNER JOIN Department D ON E.Department_ID = D.D_ID;";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        // Method to search employees by various fields
        public DataTable getEmployeeBysearch(string search)
        {
            string query = "SELECT E.EID, E.EName, E.Email, E.Mobile, E.City, E.Address, R.Role_Name, D.D_name AS Department_Name, D.D_location AS Department_Location FROM Employee E INNER JOIN Roles R ON E.Role_ID = R.Role_ID INNER JOIN Department D ON E.Department_ID = D.D_ID WHERE E.EName LIKE @search OR E.Email LIKE @search OR E.Mobile LIKE @search OR E.City LIKE @search OR E.Address LIKE @search OR R.Role_Name LIKE @search OR D.D_name LIKE @search OR D.D_location LIKE @search;";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Method to get all accountants
        public DataTable getAccountant()
        {
            string query = "SELECT E.EID,E.EName,E.Email,E.Mobile,E.City,E.Address,R.Role_Name,D.D_name AS Department_Name,D.D_location AS Department_Location FROM Employee E INNER JOIN Roles R ON E.Role_ID = R.Role_ID INNER JOIN Department D ON E.Department_ID = D.D_ID WHERE E.Role_ID=1;";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        // Method to get all sales directors
        public DataTable getSalesDirector()
        {
            string query = "SELECT E.EID,E.EName,E.Email,E.Mobile,E.City,E.Address,R.Role_Name,D.D_name AS Department_Name,D.D_location AS Department_Location FROM Employee E INNER JOIN Roles R ON E.Role_ID = R.Role_ID INNER JOIN Department D ON E.Department_ID = D.D_ID WHERE E.Role_ID=3;";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        // Method to get all inventory managers
        public DataTable getInventoryManager()
        {
            string query = "SELECT E.EID,E.EName,E.Email,E.Mobile,E.City,E.Address,R.Role_Name,D.D_name AS Department_Name,D.D_location AS Department_Location FROM Employee E INNER JOIN Roles R ON E.Role_ID = R.Role_ID INNER JOIN Department D ON E.Department_ID = D.D_ID WHERE E.Role_ID=2;";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        // Method to get all service heads
        public DataTable getServiceHead()
        {
            string query = "SELECT E.EID,E.EName,E.Email,E.Mobile,E.City,E.Address,R.Role_Name,D.D_name AS Department_Name,D.D_location AS Department_Location FROM Employee E INNER JOIN Roles R ON E.Role_ID = R.Role_ID INNER JOIN Department D ON E.Department_ID = D.D_ID WHERE E.Role_ID=4;";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        // Method to delete an employee by ID
        public void DeleteEmployee(int EID)
        {
            string query = "DELETE FROM Employee WHERE EID=@EID";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@EID", EID);
                cmd.ExecuteNonQuery();
            }
            string query1 = "DELETE FROM Login WHERE EID=@EID";
            SqlCommand cmd1 = new SqlCommand(query1, connection);
            {
                connection.Close();
                connection.Open();
                cmd1.Parameters.AddWithValue("@EID", EID);
                cmd1.ExecuteNonQuery();
            }
        }

        // Method to update an employee's details
        public void UpdateEmployee(Employee employee, int EID)
        {
            string query = "UPDATE Employee SET EName=@EName,Email=@Email,Mobile=@Mobile,City=@City,Address=@Address WHERE EID=@EID";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                cmd.Parameters.AddWithValue("@EName", employee.Name);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
                cmd.Parameters.AddWithValue("@City", employee.City);
                cmd.Parameters.AddWithValue("@Address", employee.Address);
                cmd.Parameters.AddWithValue("@EID", EID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
