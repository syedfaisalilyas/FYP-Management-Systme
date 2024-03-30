using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MidProjectUI
{
    class Configuration
    {
        String ConnectionStr = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
        SqlConnection con1;
        SqlConnection con2;
        private static Configuration _instance;
        public static Configuration getInstance()
        {
            if (_instance == null)
                _instance = new Configuration();
            return _instance;
        }
        private Configuration()
        {
            con1 = new SqlConnection(ConnectionStr);
            con1.Open();
            con2 = new SqlConnection(ConnectionStr);
            con2.Open();
        }
        public static Configuration getInstance1()
        {
            return _instance;
        }
        static Configuration()
        {
            _instance = new Configuration();
        }

        public SqlConnection getConnection1()
        {
            SqlConnection con = new SqlConnection(ConnectionStr);
            con.Open();
            return con;
        }
        public SqlConnection getConnection()
        {
            return con1;
            return con2;
        }
    }
}






