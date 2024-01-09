using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TH3
{
    class Modify
    {
        public Modify() { }
        SqlCommand SqlCommand;
        SqlDataReader sqlDataReader;
        public List<Taikhoan> Taikhoans(String query)
        {
            List<Taikhoan> Taikhoans = new List<Taikhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = SqlCommand.ExecuteReader();
                while(sqlDataReader.Read()) {
                    Taikhoans.Add(new Taikhoan(
                        sqlDataReader.GetString(0), 
                        sqlDataReader.GetString(1), 
                        sqlDataReader.GetString(3), 
                        sqlDataReader.GetString(2), 
                        sqlDataReader.GetString(4), 
                        sqlDataReader.GetString(5), 
                        sqlDataReader.GetInt32(6), 
                        sqlDataReader.GetInt32(7),
                        sqlDataReader.GetString(8),
                        sqlDataReader.GetString(9),
                        sqlDataReader.GetInt32(10),
                        sqlDataReader.GetString(11)
                        ));
                }
                sqlConnection.Close();
            }
            return Taikhoans;
        }
        public List<History> Historys(String query)
        {
            List<History> Historys = new List<History>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = SqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Historys.Add(new History(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetString(3)
                        ));
                }
                sqlConnection.Close();
            }
            return Historys;
        }
        public void command (string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
