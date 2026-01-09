using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.DAL
{
    public class SalaryRepository
    {
        public void Add(
       int employeeId,
       decimal baseSalary,
       decimal bonus,
       decimal deduction,
       decimal netSalary)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    @"INSERT INTO Salaries
                  (EmployeeId, BaseSalary, Bonus, Deduction, NetSalary)
                  VALUES (@eid, @base, @bonus, @ded, @net)", conn);

                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@base", baseSalary);
                cmd.Parameters.AddWithValue("@bonus", bonus);
                cmd.Parameters.AddWithValue("@ded", deduction);
                cmd.Parameters.AddWithValue("@net", netSalary);

                cmd.ExecuteNonQuery();
            }
        }
        public Salary GetLastByEmployee(int employeeId)
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT BaseSalary, Bonus, Deduction
            FROM Salaries
            WHERE EmployeeId = @eid
            ORDER BY SalaryId DESC
            LIMIT 1
        ", conn);

                cmd.Parameters.AddWithValue("@eid", employeeId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Salary
                        {
                            BaseSalary = reader.GetDecimal("BaseSalary"),
                            Bonus = reader.GetDecimal("Bonus"),
                            Deduction = reader.GetDecimal("Deduction")
                        };
                    }
                }
            }

            return null;
        }

    }
}
