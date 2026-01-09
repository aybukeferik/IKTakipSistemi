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
    public partial class EmployeeForm : Form
    {
        DepartmentRepository deptRepo;
        EmployeeRepository repo = new EmployeeRepository();
        public EmployeeForm()
        {
            InitializeComponent();
            deptRepo = new DepartmentRepository();
            repo = new EmployeeRepository();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = repo.GetAll();
            cmbDepartment.DataSource = deptRepo.GetAll();
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";

            dgvEmployees.DataSource = repo.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            repo.Add(new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Salary = decimal.Parse(nudSalary.Text),
                DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue),
                Role = cmbRole.Text
            });

            dgvEmployees.DataSource = repo.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek personeli seçin");
                return;
            }

            int id = Convert.ToInt32(
                dgvEmployees.CurrentRow.Cells["EmployeeId"].Value);

            repo.Update(
                id,
                txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                nudSalary.Value,
                Convert.ToInt32(cmbDepartment.SelectedValue),
                cmbRole.Text
            );

            MessageBox.Show("Personel güncellendi ✅");

            dgvEmployees.DataSource = repo.GetAll();
        }
           

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek personeli seçin");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bu personeli silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            int id = Convert.ToInt32(
                dgvEmployees.CurrentRow.Cells["EmployeeId"].Value);

            repo.Delete(id);
            dgvEmployees.DataSource = repo.GetAll();
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            nudSalary.Value = Convert.ToDecimal(row.Cells["Salary"].Value);

            cmbDepartment.SelectedValue =
                Convert.ToInt32(row.Cells["DepartmentId"].Value);

            cmbRole.Text = row.Cells["Role"].Value?.ToString();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            nudSalary.Value = Convert.ToDecimal(row.Cells["Salary"].Value);

            cmbDepartment.SelectedValue =
                Convert.ToInt32(row.Cells["DepartmentId"].Value);

            cmbRole.Text = row.Cells["Role"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();

            nudSalary.Value = nudSalary.Minimum;

            cmbDepartment.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;

            dgvEmployees.ClearSelection();
        }
    }
}
