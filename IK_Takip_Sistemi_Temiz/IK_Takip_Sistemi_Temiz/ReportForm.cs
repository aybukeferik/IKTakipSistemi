using IK_Takip_Sistemi_Temiz.IK_Takip.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Takip_Sistemi_Temiz
{
    public partial class ReportForm : Form
    {
        ReportRepository reportRepo = new ReportRepository();
        ReportRepository repo = new ReportRepository();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadEmployees();

            dtStart.Value = DateTime.Today.AddMonths(-1);
            dtEnd.Value = DateTime.Today;
            dgvReport.DataSource = reportRepo.GetEmployeeCountByDepartment();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex == 0)
                dgvReport.DataSource = reportRepo.GetEmployeeCountByDepartment();

            else if (cmbReportType.SelectedIndex == 1)
                dgvReport.DataSource = reportRepo.GetLeaveReport();

            else if (cmbReportType.SelectedIndex == 2)
                dgvReport.DataSource = reportRepo.GetSalaryReport();

            dgvReport.AutoGenerateColumns = true;
            dgvReport.Columns.Cast<DataGridViewColumn>()
                .ToList()
                .ForEach(c => c.HeaderText = GetTurkishHeader(c.Name));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            cmbReportType.SelectedIndex = -1;
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void LoadDepartments()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT DepartmentId, DepartmentName FROM Department", conn);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentId";
                cmbDepartment.DataSource = dt;
            }
        }
        private void LoadEmployees()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(@"
            SELECT 
                EmployeeId,
                CONCAT(FirstName, ' ', LastName) AS FullName
            FROM Employee", conn);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbEmployee.DisplayMember = "FullName";
                cmbEmployee.ValueMember = "EmployeeId";
                cmbEmployee.DataSource = dt;
            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string GetTurkishHeader(string columnName)
        {
            switch (columnName)
            {
                case "DepartmentName": return "Departman";
                case "EmployeeCount": return "Personel Sayısı";

                case "FullName": return "Personel";
                case "StartDate": return "Başlangıç Tarihi";
                case "EndDate": return "Bitiş Tarihi";
                case "Status": return "Durum";

                case "TotalSalary": return "Toplam Maaş Yükü";
                case "AverageSalary": return "Ortalama Maaş";

                default: return columnName;
            }
        }
    }
}
