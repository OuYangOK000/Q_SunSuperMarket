using Q_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_SunSuperMarket
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        #region 查询单击事件方法
        /// <summary>
        /// 查询单击事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtProName.Text == "")
            {
                MessageBox.Show("请输入商品名称!","查询提示",MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
        }
        #endregion


        private void FrmProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.AutoGenerateColumns = false;//禁止自增列
            dgvProduct.DataSource = ProductBLL.GetProductsAll();
        }
    }
}
