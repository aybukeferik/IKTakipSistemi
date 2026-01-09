using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
using IK_Takip_Sistemi_Temiz.IK_Takip.BLL;
using IK_Takip_Sistemi_Temiz.IK_Takip.DAL;

using MySqlX.XDevAPI;
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
    public partial class LoginForm : Form
    {
        AuthService authService = new AuthService();
        AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        _authService = new AuthService();
    }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            var employee = authService.Login(txtEmail.Text, txtPassword.Text);

            if (employee != null)
            {
                UserSession.EmployeeId = employee.EmployeeId;
                UserSession.Role = employee.Role;
                UserSession.FullName = employee.FirstName + " " + employee.LastName;

                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }

    }
}

