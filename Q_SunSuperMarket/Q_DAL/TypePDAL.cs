using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q_Models;

namespace Q_DAL
{
    public  class TypePDAL
    {

        #region 查询所有商品类型
        /// <summary>
        /// 查询所有商品类型
        /// </summary>
        /// <returns></returns>
        public static List<TypeP> GetTypePsAll()
        {
            List<TypeP> typeps = new List<TypeP>();
            string sql = "select * from TypeP";
            SqlDataReader dr = SqlDBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                TypeP p = new TypeP();
                p.CdTid = dr["CdTid"].ToString();
                p.CdTypeName = dr["CdTypeName"].ToString();
                typeps.Add(p);
            }
            dr.Close();
            SqlDBHelper.conClose();
            return typeps;
        } 
        #endregion


    }
}
