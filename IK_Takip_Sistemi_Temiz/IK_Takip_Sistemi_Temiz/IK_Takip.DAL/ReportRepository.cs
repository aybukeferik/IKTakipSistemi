using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.DAL
{
    public class ReportRepository
    {
        public List<DepartmentEmployeeReport> GetEmployeeCountByDepartment()
        {
            List<DepartmentEmployeeReport> list = new List<DepartmentEmployeeReport>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
                SELECT 
                    d.DepartmentName,
                    COUNT(e.EmployeeId) AS EmployeeCount
                FROM Department d
                LEFT JOIN Employee e ON e.DepartmentId = d.DepartmentId
                GROUP BY d.DepartmentName", conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new DepartmentEmployeeReport
                    {
                        DepartmentName = reader.GetString("DepartmentName"),
                        EmployeeCount = reader.GetInt32("EmployeeCount")
                    });
                }
            }
            return list;
        }
        public List<LeaveReport> GetLeaveReport()
        {
            List<LeaveReport> list = new List<LeaveReport>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT 
                e.FirstName,
                e.LastName,
                l.StartDate,
                l.EndDate,
                l.Status
           FROM `Leave` l
           JOIN Employee e ON l.EmployeeId = e.EmployeeId", conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new LeaveReport
                    {
                        FullName = reader.GetString("FirstName") + " " + reader.GetString("LastName"),
                        StartDate = reader.GetDateTime("StartDate"),
                        EndDate = reader.GetDateTime("EndDate"),
                        Status = reader.GetString("Status")
                    });
                }
            }
            return list;
        }
        public List<LeaveReport> GetLeaveReport(DateTime startDate, DateTime endDate)
        {
            List<LeaveReport> list = new List<LeaveReport>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
        SELECT 
            e.FirstName,
            e.LastName,
            l.StartDate,
            l.EndDate,
            l.Status
        FROM `Leave` l
        JOIN Employee e ON l.EmployeeId = e.EmployeeId
        WHERE l.StartDate >= @startDate
          AND l.EndDate <= @endDate", conn);

                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new LeaveReport
                    {
                        FullName = reader.GetString("FirstName") + " " + reader.GetString("LastName"),
                        StartDate = reader.GetDateTime("StartDate"),
                        EndDate = reader.GetDateTime("EndDate"),
                        Status = reader.GetString("Status")
                    });
                }
            }
            return list;
        }
        public List<SalaryReport> GetSalaryReport()
        {
            List<SalaryReport> list = new List<SalaryReport>();

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT 
                SUM(NetSalary) AS TotalSalary,
                AVG(NetSalary) AS AverageSalary
            FROM Salaries", conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    list.Add(new SalaryReport
                    {
                        TotalSalary = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0),
                        AverageSalary = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1)
                    });
                }
            }

            return list;
        }
    }
}
