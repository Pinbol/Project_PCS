using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    static class koneksi
    {
        static MySqlConnection conn = new MySqlConnection();
        static string dbname = "db_projek_pcs";
        static string server = "localhost";
        static string usernmae = "root";
        static string password = "";

       
        public static void openConn()
        {
            if (conn.State == ConnectionState.Open) conn.Close();

            conn.ConnectionString = string.Format("server={0};user id={1};password={2};database={3}", server, usernmae, password, dbname);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }

        }

        public static MySqlConnection getConn()
        {
            return conn;
        }

        public static void closeConn()
        {
            conn.Close();
        }
    }
}
