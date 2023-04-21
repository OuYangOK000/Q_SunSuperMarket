using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Q_DAL
{
    public class SqlDBHelper
    {
        static string conStr = ConfigurationManager.AppSettings["conStr"];
        static SqlConnection con = null;
        public static SqlConnection GetConnection()
        {
            if(con==null || con.ConnectionString == "")
            {
                con = new SqlConnection(conStr);
            }
            return con;
        }
        public static void conOpen()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
        }
        public static void conClose()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public static SqlDataReader ExecuteReader(string sql,CommandType type=CommandType.Text,
            params SqlParameter[] para)
        {
            SqlConnection con = GetConnection();
            conOpen();
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = type;
            com.Parameters.AddRange(para);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        public static int ExecuteNonQuery(string sql,CommandType type=CommandType.Text,
            params SqlParameter[] para)
        {
            int n = 0;
            SqlConnection con = GetConnection();
            conOpen();
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = type;
            com.Parameters.AddRange(para);
            n = com.ExecuteNonQuery();
            conClose();
            return n;
        }
    }
}
