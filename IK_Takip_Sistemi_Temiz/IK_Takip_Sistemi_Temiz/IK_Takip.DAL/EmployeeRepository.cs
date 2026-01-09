using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.DAL
{
    public class EmployeeRepository
    {
        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"SELECT 
                                    EmployeeId,
                                    FirstName,
                                    LastName,
                                    Email,
                                    Salary,
                                    DepartmentId,
                                    Role
                                 FROM Employee";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee emp = new Employee
                    {
                        EmployeeId = reader.GetInt32("EmployeeId"),
                        FirstName = reader.GetString("FirstName"),
                        LastName = reader.GetString("LastName"),
                        Email = reader["Email"]?.ToString(),
                        Salary = reader.GetDecimal("Salary"),
                        DepartmentId = reader.GetInt32("DepartmentId"),
                        Role = reader.GetString("Role")
                    };

                    employees.Add(emp);
                }
            }

            return employees;
        }
        public void Add(Employee employee)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO Employee
(FirstName, LastName, Email, Password, Salary, DepartmentId, Role)
VALUES
(@FirstName, @LastName, @Email, @Password, @Salary, @DepartmentId, @Role)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                cmd.Parameters.AddWithValue("@DepartmentId", employee.DepartmentId);
                cmd.Parameters.AddWithValue("@Role", employee.Role);
                cmd.Parameters.AddWithValue("@Password", "12345");
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int employeeId)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM Employee WHERE EmployeeId = @id", conn);

                cmd.Parameters.AddWithValue("@id", employeeId);
                cmd.ExecuteNonQuery();
            }

        }
        public void Update(
     int employeeId,
     string firstName,
     string lastName,
     string email,
     decimal salary,
     int departmentId,
     string role)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            UPDATE Employee
            SET 
                FirstName = @FirstName,
                LastName = @LastName,
                Email = @Email,
                Salary = @Salary,
                DepartmentId = @DepartmentId,
                Role = @Role
            WHERE EmployeeId = @EmployeeId
        ", conn);

                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                cmd.ExecuteNonQuery();
            }
        }
        public List<Employee> GetByDepartment(int departmentId)
        {
            List<Employee> employees = new List<Employee>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    @"SELECT 
                EmployeeId,
                FirstName,
                LastName,
                Email,
                Salary,
                DepartmentId,
                Role
              FROM Employee
              WHERE DepartmentId = @deptId", conn);

                cmd.Parameters.AddWithValue("@deptId", departmentId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            EmployeeId = reader.GetInt32("EmployeeId"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            Email = reader["Email"]?.ToString(),
                            Salary = reader.GetDecimal("Salary"),
                            DepartmentId = reader.GetInt32("DepartmentId"),
                            Role = reader.GetString("Role")
                        });
                    }
                }
            }

            return employees;
        }
        public Employee GetByUsernameAndPassword(string email , string password)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT * FROM Employee
            WHERE Username = @u AND Password = @p", conn);

                cmd.Parameters.AddWithValue("@u", email);
                cmd.Parameters.AddWithValue("@p", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Employee
                        {
                            EmployeeId = reader.GetInt32("EmployeeId"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            Role = reader.GetString("Role")
                        };
                    }
                }
            }
            return null;
        }
    }
}
