using IK_Takip_Sistemi_Temiz.IK_Takip.DAL;
using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.DAL
{
    public class DepartmentRepository
    {
        public List<Department> GetAll()
        {
            List<Department> list = new List<Department>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT DepartmentId, DepartmentName FROM Department",
                    conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Department
                        {
                            DepartmentId = reader.GetInt32("DepartmentId"),
                            DepartmentName = reader.GetString("DepartmentName")
                        });
                    }
                }
            }

            return list;
        }

        public void Add(string departmentName)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO Department (DepartmentName) VALUES (@name)",
                    conn);
                cmd.Parameters.AddWithValue("@name", departmentName);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int departmentId)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM Department WHERE DepartmentId=@id",
                    conn);
                cmd.Parameters.AddWithValue("@id", departmentId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}