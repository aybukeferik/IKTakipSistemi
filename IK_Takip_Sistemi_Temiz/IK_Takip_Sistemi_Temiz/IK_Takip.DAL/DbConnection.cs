using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK_Takip_Sistemi_Temiz.IK_Takip.DAL
{
    public class DbConnection
    {
        private static string _connectionString =
"Server=172.21.54.253;Database=26_132430081;User ID= 26_132430081; Password=İnif123.;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
