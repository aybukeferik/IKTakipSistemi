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
    public partial class PerformanceForm : Form
    {
        EmployeeRepository employeeRepo = new EmployeeRepository();
        int selectedPerformanceId = 0;
        PerformanceRepository repo = new PerformanceRepository();
        public PerformanceForm()
        {
            InitializeComponent();
        }

        private void lblPeriod_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void PerformanceForm_Load(object sender, EventArgs e)
        {
            cmbEmployee.DataSource = null;
            cmbEmployee.DataSource = employeeRepo.GetAll();
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeId";
            cmbEmployee.SelectedIndex = -1;
           
            cmbPeriod.Items.Clear();
            cmbPeriod.Items.Add("2025-Q1");
            cmbPeriod.Items.Add("2025-Q2");
            cmbPeriod.Items.Add("2025-Q3");
            cmbPeriod.Items.Add("2025-Q4");
            cmbPeriod.SelectedIndex = -1;

            dgvPerformance.DataSource = repo.GetAll();

        }

        private void dgvPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvPerformance.Rows[e.RowIndex];

            selectedPerformanceId = Convert.ToInt32(row.Cells["PerformanceId"].Value);

            cmbEmployee.SelectedValue =
                Convert.ToInt32(row.Cells["EmployeeId"].Value);

            cmbPeriod.Text = row.Cells["Period"].Value.ToString();
            nudScore.Value = Convert.ToDecimal(row.Cells["Score"].Value);
            txtNotes.Text = row.Cells["Notes"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployee.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen personel seçiniz");
                    return;
                }

                if (cmbPeriod.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen geçerli bir dönem seçiniz");
                    return;
                }

                int employeeId = (int)cmbEmployee.SelectedValue;
                string period = cmbPeriod.Text;
                int score = (int)nudScore.Value;
                string notes = txtNotes.Text;

                if (selectedPerformanceId == 0)
                {
                    repo.Add(employeeId, period, score, notes);
                    MessageBox.Show("Performans eklendi");
                }
                else
                {
                    repo.Update(selectedPerformanceId, employeeId, period, score, notes);
                    MessageBox.Show("Performans güncellendi");
                }

                dgvPerformance.DataSource = repo.GetAll();
                btnClear_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Kayıt sırasında hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbEmployee.SelectedIndex = -1;
            cmbPeriod.SelectedIndex = -1;
            nudScore.Value = 0;
            txtNotes.Clear();

            selectedPerformanceId = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPerformanceId == 0)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçin");
                return;
            }

            var result = MessageBox.Show(
                "Bu performans kaydı silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                repo.Delete(selectedPerformanceId);
                dgvPerformance.DataSource = repo.GetAll();
                btnClear_Click(null, null);
                MessageBox.Show("Kayıt silindi");
            }
        }
    }
}
