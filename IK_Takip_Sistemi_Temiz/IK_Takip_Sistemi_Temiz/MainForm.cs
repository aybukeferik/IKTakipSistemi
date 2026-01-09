using IK_Takip_Sistemi_Temiz;
using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Hoş geldin, " + UserSession.FullName;
            btnLeaveRequest.Visible = false;
            btnLeaveApproval.Visible = false;
            btnEmployee.Visible = false;
            btnDepartment.Visible = false;
            btnReport.Visible = false;
            btnSalary.Visible = false;
            btnPerformance.Visible = false;

            if (UserSession.Role == "Kullanıcı")
            {
                btnLeaveRequest.Visible = true;
            }
            else if (UserSession.Role == "İK" || UserSession.Role == "Yönetici")
            {
                btnLeaveApproval.Visible = true;
                btnEmployee.Visible = true;
                btnDepartment.Visible = true;
                btnReport.Visible = true;
                btnSalary.Visible = true;
                btnPerformance.Visible=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmployeeForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DepartmentForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LeaveApprovalForm().ShowDialog();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            SalaryForm form = new SalaryForm();
            form.Show();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            PerformanceForm frm = new PerformanceForm();
            frm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.Show();
        }

        private void btnLeaveRequest_Click(object sender, EventArgs e)
        {
            LeaveRequestForm frm = new LeaveRequestForm();
            frm.Show();
        }
    }
}
