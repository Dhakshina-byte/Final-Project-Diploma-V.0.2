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

    public class EmployeeService
    {
        private readonly SqlConnection connection;

        public EmployeeService()
        {
            connection = DatabaseConnection.GetConnection();
        }

        public int getthelastemp()
        {
            string query = "SELECT MAX(EID) FROM Employee";
            SqlCommand cmd = new SqlCommand(query, connection);
            {
                connection.Close();
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                int lastEmpId = Convert.ToInt32(dt.Rows[0][0]);


                return lastEmpId;
            }
        }
        public void AddLogine(Employee employee,Login login)
        {
            string query1 = "INSERT INTO Login (Username,Password,EID) VALUES (@Username,@Password,@EID)";
            SqlCommand cmd1 = new SqlCommand(query1, connection);
            {
                connection.Close();
                connection.Open();
                cmd1.Parameters.AddWithValue("@Username", employee.username);
                cmd1.Parameters.AddWithValue("@Password", employee.Password);
                cmd1.Parameters.AddWithValue("@EID", login.EID);
                cmd1.ExecuteNonQuery();
            }
        }

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
        public void UpdateEmployee(Employee employee,int EID)
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
