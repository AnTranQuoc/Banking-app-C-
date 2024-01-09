using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH3
{
    class Connection
    {
        private static string Stringconnection = @"Data Source=LAPTOP-VP8DQL7N\QMS;Initial Catalog=Taikhoan;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(Stringconnection);
        }
    }
}
