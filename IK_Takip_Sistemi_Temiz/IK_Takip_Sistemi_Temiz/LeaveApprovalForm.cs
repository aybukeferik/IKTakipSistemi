using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
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
    public partial class LeaveApprovalForm : Form
    {
        LeaveRepository repo = new LeaveRepository();
        public LeaveApprovalForm()
        {
            InitializeComponent();
        }

        private void LeaveApprovalForm_Load(object sender, EventArgs e)
        {
            if (UserSession.Role == "Kullanici")
            {
                MessageBox.Show("Yetkiniz yok");
                Close();
                return;
            }

            dgvLeaves.DataSource = repo.GetAll();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvLeaves.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir izin seçin");
                return;
            }

            string status =
                dgvLeaves.CurrentRow.Cells["Status"].Value.ToString();

            if (status != "Pending")
            {
                MessageBox.Show("Bu izin zaten sonuçlandırılmış");
                return;
            }

            int leaveId = Convert.ToInt32(
                dgvLeaves.CurrentRow.Cells["LeaveId"].Value);

            repo.UpdateStatus(leaveId, "Approved");
            dgvLeaves.DataSource = repo.GetAll();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvLeaves.CurrentRow == null)
            {
                MessageBox.Show("Lütfen bir izin seçin");
                return;
            }

            string status =
                dgvLeaves.CurrentRow.Cells["Status"].Value.ToString();

            if (status != "Pending")
            {
                MessageBox.Show("Bu izin zaten sonuçlandırılmış");
                return;
            }

            int leaveId = Convert.ToInt32(
                dgvLeaves.CurrentRow.Cells["LeaveId"].Value);

            repo.UpdateStatus(leaveId, "Rejected");
            dgvLeaves.DataSource = repo.GetAll();
        }
    }
}
