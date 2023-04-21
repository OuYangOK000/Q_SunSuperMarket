using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_Models
{
    public class Product
    {
        public string CdId { get; set; }        //编号
        public string CdTid { get; set; }  //商品类型
        public string PcName { get; set; }      //商品名称
        public double CdPrice { get; set; }     //价格
        public int CdAmount { get; set; }       //数量
        public string UserName { get; set; }    //购买人
        public string Img { get; set; }         //图片
    }
}
