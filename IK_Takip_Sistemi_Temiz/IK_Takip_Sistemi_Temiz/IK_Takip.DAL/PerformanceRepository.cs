using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.DAL
{
    public class PerformanceRepository
    {
        public List<Performance> GetAll()
        {
            List<Performance> list = new List<Performance>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    @"SELECT PerformanceId, EmployeeId, Period, Score, Notes 
              FROM Performance", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Performance
                        {
                            PerformanceId = reader.GetInt32("PerformanceId"),
                            EmployeeId = reader.GetInt32("EmployeeId"),
                            Period = reader.GetString("Period"),
                            Score = reader.GetInt32("Score"),
                            Notes = reader.GetString("Notes")
                        });
                    }
                }
            }

            return list;
        }
        public void Add(int employeeId, string period, int score, string notes)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    @"INSERT INTO Performance (EmployeeId, Period, Score, Notes)
              VALUES (@eid, @p, @s, @n)", conn);

                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@p", period);
                cmd.Parameters.AddWithValue("@s", score);
                cmd.Parameters.AddWithValue("@n", notes);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int performanceId, int employeeId, string period, int score, string notes)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    @"UPDATE Performance
              SET EmployeeId=@eid, Period=@p, Score=@s, Notes=@n
              WHERE PerformanceId=@id", conn);

                cmd.Parameters.AddWithValue("@id", performanceId);
                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@p", period);
                cmd.Parameters.AddWithValue("@s", score);
                cmd.Parameters.AddWithValue("@n", notes);

                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int performanceId)
        {
            using (var conn = DbConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(
                    "DELETE FROM Performance WHERE PerformanceId=@id", conn);

                cmd.Parameters.AddWithValue("@id", performanceId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
