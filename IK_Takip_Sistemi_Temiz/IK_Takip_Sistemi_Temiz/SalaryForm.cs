using IK_Takip_Sistemi_Temiz.IK_Takip.DAL;
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
    public partial class SalaryForm : Form
    {

        SalaryRepository salaryRepo = new SalaryRepository();
        EmployeeRepository empRepo = new EmployeeRepository();
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            var employees = empRepo.GetAll();

            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeId";
            cmbEmployee.DataSource = employees;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal net =
        nudBaseSalary.Value +
        nudBonus.Value -
        nudDeduction.Value;

            lblNetSalary.Text = $"Net Maaş: {net:N2} ₺";

            salaryRepo.Add(
                Convert.ToInt32(cmbEmployee.SelectedValue),
                nudBaseSalary.Value,
                nudBonus.Value,
                nudDeduction.Value,
                net
            );

            MessageBox.Show("Maaş hesaplandı ve kaydedildi");
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedValue == null)
                return;

            int employeeId;
            if (!int.TryParse(cmbEmployee.SelectedValue.ToString(), out employeeId))
                return;

            ClearFields();
            
            var salary = salaryRepo.GetLastByEmployee(employeeId);

            if (salary != null)
            {
                nudBaseSalary.Value = salary.BaseSalary;
                nudBonus.Value = salary.Bonus;
                nudDeduction.Value = salary.Deduction;
            }
        }
        private void ClearFields()
        {
            nudBaseSalary.Value = 0;
            nudBonus.Value = 0;
            nudDeduction.Value = 0;
            lblNetSalary.Text = "Net Maaş: 0 ₺";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
