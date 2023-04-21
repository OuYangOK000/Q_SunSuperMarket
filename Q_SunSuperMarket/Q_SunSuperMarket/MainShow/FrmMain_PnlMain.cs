using Q_BLL;
using Q_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_SunSuperMarket
{
    public partial class FrmMain_PnlMain : Form
    {
        public FrmMain_PnlMain()
        {
            InitializeComponent();
        }

        #region 窗体加载事件方法
        /// <summary>
        /// 窗体加载事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_PnlMain_Load(object sender, EventArgs e)
        {
            List<Product> products = ProductBLL.GetProductsAll();

            int f = 0, b = 0;
            string imge = "";
            PictureBox pic = null;
            for (int i = 0; i < products.Count(); i++)
            {
                imge = products[i].PcName + ".jpg";
                pic = new PictureBox();
                try
                {
                    pic.Image = Image.FromFile(@"D:\编程\阳光超市管理系统\image\\商品图片\" + imge);
                }
                catch (Exception ee)
                {

                }
                pic.Size = new Size(140, 190);
                pic.Location = new Point((b * 180) + 20, (f * 240) + 20);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                //pic.ImageLocation = @"D:\编程\阳光超市管理系统\image\商品图片\" + imge+".jpg";

                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Size = new Size(40, 140);
                lbl.Text = products[i].PcName;
                lbl.Location = new Point((b * 180) + 65, (f * 240) + 225);

                b++;

                if (5 == b)
                {
                    b = 0;
                    f++;
                }
                pnl.Controls.AddRange(new Control[] { pic, lbl });

            }
        } 
        #endregion

    }
}
