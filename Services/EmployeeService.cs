using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Finalproject.Models;

namespace Finalproject.Services
{
    public class EmployeeService
    {
        public bool RegisterEmployee(Employee employee)
        {
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                string query = @"INSERT INTO Employee (Email, Mobile, City, Address, Role_ID, Department_ID) 
                                 VALUES (@Email, @Mobile, @City, @Address, @Role_ID, @Department_ID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
                    cmd.Parameters.AddWithValue("@City", employee.City ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", employee.Address ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Role_ID", employee.Role_ID);
                    cmd.Parameters.AddWithValue("@Department_ID", employee.Department_ID);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public Employee LoginEmployee(string email)
        {
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                string query = "SELECT * FROM Employee WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Employee
                            {
                                EID = Convert.ToInt32(reader["EID"]),
                                Email = reader["Email"].ToString(),
                                Mobile = reader["Mobile"].ToString(),
                                City = reader["City"].ToString(),
                                Address = reader["Address"].ToString(),
                                Role_ID = Convert.ToInt32(reader["Role_ID"]),
                                Department_ID = Convert.ToInt32(reader["Department_ID"])
                            };
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Log the exception
            }
            return null;
        }
    }
}
