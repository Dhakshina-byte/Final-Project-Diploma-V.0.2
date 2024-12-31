using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Finalproject.Models;
using Finalproject.Utils;

namespace Finalproject.Services
{
    public class DepartmentService
    {
        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                string query = "SELECT * FROM Department";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        departments.Add(new Department
                        {
                            D_ID = Convert.ToInt32(reader["D_ID"]),
                            D_name = reader["D_name"].ToString(),
                            D_location = reader["D_location"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllDepartments: {ex.Message}");
            }
            return departments;
        }

        public bool AddDepartment(string name, string location)
        {
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                string query = "INSERT INTO Department (D_name, D_location) VALUES (@Name, @Location)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Location", location ?? (object)DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddDepartment: {ex.Message}");
                return false;
            }
        }

        public bool DeleteDepartment(int departmentId)
        {
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                string query = "DELETE FROM Department WHERE D_ID = @DepartmentId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteDepartment: {ex.Message}");
                return false;
            }
        }
    }
}
