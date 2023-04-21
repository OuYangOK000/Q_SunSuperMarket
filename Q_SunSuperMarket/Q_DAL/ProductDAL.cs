using Q_Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_DAL
{
    public class ProductDAL
    {

        #region 查询所有商品信息
        /// <summary>
        /// 查询所有商品信息
        /// </summary>
        /// <returns></returns>
        public static List<Product> GetProductsAll()
        {
            List<Product> products = new List<Product>();
            string sql = "select * from Product";
            SqlDataReader dr = SqlDBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Product p = new Product();
                p.CdId = dr["CdId"].ToString();
                p.CdTid = dr["CdTid"].ToString();
                p.PcName = dr["PcName"].ToString();
                p.CdPrice = Convert.ToDouble(dr["CdPrice"]);
                p.CdAmount = Convert.ToInt32(dr["CdAmount"]);
                p.UserName = dr["UserName"].ToString();
                p.Img = dr["Img"].ToString();
                products.Add(p);
            }
            dr.Close();
            SqlDBHelper.conClose();
            return products;
        } 
        #endregion
    }
}
