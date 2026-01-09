using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using IK_Takip_Sistemi_Temiz.IK_Takip.Models;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.DAL
{
    public class LeaveRepository
    {
        public void Add(int employeeId, DateTime start, DateTime end, string reason)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                int totalDays = (end - start).Days + 1;
                MySqlCommand cmd = new MySqlCommand(
                    @"INSERT INTO `Leave`
                      (EmployeeId, StartDate, EndDate, Reason, Status,TotalDays)
                      VALUES (@empId, @start, @end, @reason, 'Pending',@days)",
                    conn);

                cmd.Parameters.AddWithValue("@empId", employeeId);
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.Parameters.AddWithValue("@days", totalDays);

                cmd.ExecuteNonQuery();
            }
        }

        public List<LeaveModel> GetAll()
        {
            List<LeaveModel> list = new List<LeaveModel>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM `Leave`",
                    conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LeaveModel
                        {
                            LeaveId = reader.GetInt32("LeaveId"),
                            EmployeeId = reader.GetInt32("EmployeeId"),
                            StartDate = reader.GetDateTime("StartDate"),
                            EndDate = reader.GetDateTime("EndDate"),
                            Reason = reader.GetString("Reason"),
                            Status = reader.GetString("Status")
                        });
                    }
                }
            }

            return list;
        }

       
        public void UpdateStatus(int leaveId, string status)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE `Leave` SET Status=@status WHERE LeaveId=@id",
                    conn);

                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", leaveId);

                cmd.ExecuteNonQuery();
            }
        }
        public List<LeaveModel> GetByEmployee(int employeeId)
        {
            List<LeaveModel> list = new List<LeaveModel>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT LeaveId, StartDate, EndDate, Reason, Status
            FROM `Leave`
            WHERE EmployeeId = @EmployeeId
        ", conn);

                cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LeaveModel
                        {
                            LeaveId = reader.GetInt32("LeaveId"),
                            StartDate = reader.GetDateTime("StartDate"),
                            EndDate = reader.GetDateTime("EndDate"),
                            Reason = reader.GetString("Reason"),
                            Status = reader.GetString("Status")
                        });
                    }
                }
            }

            return list;
        }

    }
}


