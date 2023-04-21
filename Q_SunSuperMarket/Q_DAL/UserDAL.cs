using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Q_Models;

namespace Q_DAL
{
    public class UserDAL
    {
        #region 查询所有用户信息
        /// <summary>
        /// 查询所有用户信息
        /// </summary>
        /// <returns></returns>
        public static List<Users> UsersAll()
        {
            List<Users> us = new List<Users>();
            string sql = "select * from Users";
            SqlDataReader dr = SqlDBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Users u = new Users();
                u.UserId = dr["UserId"].ToString();
                u.UserName = dr["UserName"].ToString();
                u.UserPwd = dr["UserPwd"].ToString();
                us.Add(u);
            }
            dr.Close();
            SqlDBHelper.conClose();
            return us;
        }
        #endregion

        #region 根据用户名查询用户信息
        /// <summary>
        /// 根据用户名查询用户信息
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static Users GetUserByUserName(string Name)
        {
            Users u = null;
            string sql = "Select * from Users where UserName='" + Name + "'";
            SqlDataReader dr = SqlDBHelper.ExecuteReader(sql);
            if (dr.Read())
            {
                u = new Users();
                u.UserId = dr["UserId"].ToString();
                u.UserName = dr["UserName"].ToString();
                u.UserPwd = dr["UserPwd"].ToString();
            }
            dr.Close();
            SqlDBHelper.conClose();
            return u;
        } 
        #endregion

    }
}
