
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
    public partial class LeaveRequestForm : Form
    {
        LeaveRepository repo = new LeaveRepository();
        public LeaveRequestForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaveRequestForm_Load(object sender, EventArgs e)
        {
            dgvMyLeaves.DataSource = repo.GetByEmployee(UserSession.EmployeeId);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (dtEnd.Value < dtStart.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıçtan önce olamaz");
                return;
            }

            repo.Add(
                UserSession.EmployeeId,
                dtStart.Value,
                dtEnd.Value,
                txtReason.Text
            );

            MessageBox.Show("İzin talebi gönderildi");

            dgvMyLeaves.DataSource =
                repo.GetByEmployee(UserSession.EmployeeId);

            txtReason.Clear();
        }
    }
}
