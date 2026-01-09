using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.Models
{
    public class Performance
    {
        public int PerformanceId { get; set; }
        public int EmployeeId { get; set; }
        public string Period { get; set; }
        public int Score { get; set; }
        public string Notes { get; set; }
    }
}