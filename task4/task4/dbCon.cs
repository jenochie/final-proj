using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace task4
{
    internal class dbCon
    {
        private MySqlConnection con = new MySqlConnection("server = localhost; database = log_db; uid = root; pwd = root;");

        public MySqlConnection getCon()
        {
            return con;
        }
        public void openCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
