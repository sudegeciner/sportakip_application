using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportakip_application
{
    public class DbConnection
    {
        private string connStr =
           "server=gateway01.eu-central-1.prod.aws.tidbcloud.com;" +
           "port=4000;" +
           "user=2cX2FJsjpRzShSZ.root;" +
           "password=PvoI9zd5WpUYvRCD ;" +
           "database=sys;" +
           "SslMode=Required;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        public bool TestConnection()
        {
            try
            {
                var conn = GetConnection();
                conn.Open();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetData(string query)
        {
            var conn = GetConnection();
            conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();
            return dt;
        }
    }
}
