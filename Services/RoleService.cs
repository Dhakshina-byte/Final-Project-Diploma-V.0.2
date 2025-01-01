using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Finalproject.Models;


namespace Finalproject.Services
{
    public class RoleService
    {
        public List<Role> GetAllRoles()
        {
            List<Role> roles = new List<Role>();
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                string query = "SELECT * FROM Roles";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        roles.Add(new Role
                        {
                            Role_ID = Convert.ToInt32(reader["Role_ID"]),
                            Role_Name = reader["Role_Name"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllRoles: {ex.Message}");
            }
            return roles;
        }

        public bool AddRole(string roleName)
        {
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                string query = "INSERT INTO Roles (Role_Name) VALUES (@RoleName)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleName", roleName);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddRole: {ex.Message}");
                return false;
            }
        }

        public bool DeleteRole(int roleId)
        {
            try
            {
                var conn = DatabaseConnection.Instance.Connection;
                string query = "DELETE FROM Roles WHERE Role_ID = @RoleId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleId", roleId);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteRole: {ex.Message}");
                return false;
            }
        }
    }
}
