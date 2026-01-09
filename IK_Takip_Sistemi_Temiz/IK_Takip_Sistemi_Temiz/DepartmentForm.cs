using IK_Takip_Sistemi_Temiz.IK_Takip.DAL;
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
    public partial class DepartmentForm : Form
    {
        EmployeeRepository employeeRepo = new EmployeeRepository();
        EmployeeRepository empRepo = new EmployeeRepository();
        DepartmentRepository deptRepo = new DepartmentRepository();
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            dgvDepartments.DataSource = deptRepo.GetAll();
        }

        private void dgvDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartments.CurrentRow == null)
                return;

            int departmentId = Convert.ToInt32(
                dgvDepartments.CurrentRow.Cells["DepartmentId"].Value);

            dgvEmployeesByDepartment.DataSource =
                employeeRepo.GetByDepartment(departmentId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show("Departman adı boş olamaz");
                return;
            }

            deptRepo.Add(txtDepartmentName.Text);
            dgvDepartments.DataSource = deptRepo.GetAll();
            txtDepartmentName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepartments.CurrentRow == null)
            {
                MessageBox.Show("Departman seçin");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bu departmanı silmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No) return;

            int id = Convert.ToInt32(
                dgvDepartments.CurrentRow.Cells["DepartmentId"].Value);

            deptRepo.Delete(id);
            dgvDepartments.DataSource = deptRepo.GetAll();
            dgvEmployeesByDepartment.DataSource = null;
        }
    }
}
