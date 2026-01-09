using IK_Takip_Sistemi_Temiz.IK_Takip.Models;
using IK_Takip_Sistemi_Temiz.IK_Takip.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.BLL
{
    public class AuthService
    {
        AuthRepository _authRepository = new AuthRepository();
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public Employee Login(string email, string password)
        {
            return _authRepository.Login(email, password);
        }
    }
}
