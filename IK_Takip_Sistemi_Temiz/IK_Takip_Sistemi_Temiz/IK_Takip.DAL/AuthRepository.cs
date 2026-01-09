using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.DAL
{
    public class AuthRepository
    {
        public Employee Login(string email, string password)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT EmployeeId, FirstName, LastName, Role
            FROM Employee
            WHERE Email=@email AND Password=@password
            ", conn);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Employee
                        {
                            EmployeeId = reader.GetInt32("EmployeeId"),
                            Role = reader.GetString("Role"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                        };
                    }
                }
            }
            return null;
        }
        public int GetEmployeeIdByEmail(string email)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT EmployeeId FROM employee WHERE Email=@email",
                    conn);

                cmd.Parameters.AddWithValue("@email", email);

                object result = cmd.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }      
    }
}