//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using Finalproject.Models;

//namespace Finalproject.Services
//{
//    public class EmployeeService
//    {
//        public bool RegisterEmployee(Employee employee)
//        {
//            try
//            {
//                var conn = DatabaseConnection.Instance.Connection;
//                string query = @"INSERT INTO Employee (Email, Mobile, City, Address, Role_ID, Department_ID) 
//                                 VALUES (@Email, @Mobile, @City, @Address, @Role_ID, @Department_ID)";

//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.AddWithValue("@Email", employee.Email);
//                    cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
//                    cmd.Parameters.AddWithValue("@City", employee.City ?? (object)DBNull.Value);
//                    cmd.Parameters.AddWithValue("@Address", employee.Address ?? (object)DBNull.Value);
//                    cmd.Parameters.AddWithValue("@Role_ID", employee.Role_ID);
//                    cmd.Parameters.AddWithValue("@Department_ID", employee.Department_ID);

//                    cmd.ExecuteNonQuery();
//                }
//                return true;
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e);
//                return false;
//            }
//        }

//        public Employee LoginEmployee(string email)
//        {
//            try
//            {
//                var conn = DatabaseConnection.Instance.Connection;
//                string query = "SELECT * FROM Employee WHERE Email = @Email";

//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.AddWithValue("@Email", email);

//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        if (reader.Read())
//                        {
//                            return new Employee
//                            {
//                                EID = Convert.ToInt32(reader["EID"]),
//                                Email = reader["Email"].ToString(),
//                                Mobile = reader["Mobile"].ToString(),
//                                City = reader["City"].ToString(),
//                                Address = reader["Address"].ToString(),
//                                Role_ID = Convert.ToInt32(reader["Role_ID"]),
//                                Department_ID = Convert.ToInt32(reader["Department_ID"])
//                            };
//                        }
//                    }
//                }
//            }
//            catch (Exception)
//            {
//                // Log the exception
//            }
//            return null;
//        }

//        public bool UpdateEmployee(Employee employee)
//        {
//            try
//            {
//                var conn = DatabaseConnection.Instance.Connection;
//                string query = @"UPDATE Employee SET 
//                         Email = @Email, Mobile = @Mobile, City = @City, 
//                         Address = @Address, Role_ID = @Role_ID, Department_ID = @Department_ID
//                         WHERE EID = @EID";

//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.AddWithValue("@EID", employee.EID);
//                    cmd.Parameters.AddWithValue("@Email", employee.Email);
//                    cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);
//                    cmd.Parameters.AddWithValue("@City", employee.City ?? (object)DBNull.Value);
//                    cmd.Parameters.AddWithValue("@Address", employee.Address ?? (object)DBNull.Value);
//                    cmd.Parameters.AddWithValue("@Role_ID", employee.Role_ID);
//                    cmd.Parameters.AddWithValue("@Department_ID", employee.Department_ID);

//                    cmd.ExecuteNonQuery();
//                }
//                return true;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error in UpdateEmployee: {ex.Message}");
//                return false;
//            }
//        }

//        public List<Employee> GetAllEmployees()
//        {
//            List<Employee> employees = new List<Employee>();
//            try
//            {
//                var conn = DatabaseConnection.Instance.Connection;
//                string query = "SELECT * FROM Employee";

//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                using (SqlDataReader reader = cmd.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        employees.Add(new Employee
//                        {
//                            EID = Convert.ToInt32(reader["EID"]),
//                            Email = reader["Email"].ToString(),
//                            Mobile = reader["Mobile"].ToString(),
//                            City = reader["City"].ToString(),
//                            Address = reader["Address"].ToString(),
//                            Role_ID = Convert.ToInt32(reader["Role_ID"]),
//                            Department_ID = Convert.ToInt32(reader["Department_ID"])
//                        });
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Error in GetAllEmployees: {ex.Message}");
//            }
//            return employees;
//        }

//    }
//}
