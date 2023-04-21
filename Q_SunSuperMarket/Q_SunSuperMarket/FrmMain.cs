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
    public partial class FrmMain : Form
    {
        public string UserId = "";
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 窗体加载事件方法
        /// <summary>
        /// 窗体加载事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            tsslUser.Text = UserId;
            tsslDate.Text = DateTime.Now.ToShortDateString();
            tsslTime.Text = DateTime.Now.ToLongTimeString();
            timMain.Enabled = true;

            FrmMain_PnlMain frm = new FrmMain_PnlMain();
            ShowMain(frm);
        } 
        #endregion

        #region 计时器事件方法
        /// <summary>
        /// 计时器事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timMain_Tick(object sender, EventArgs e)
        {
            tsslDate.Text = DateTime.Now.ToShortDateString();
            tsslTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region 关闭事件方法
        /// <summary>
        /// 关闭事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 单击查询事件方法
        /// <summary>
        /// 单击查询事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiProSel_Click(object sender, EventArgs e)
        {
            pnlProduct.Controls.Clear();
            FrmProduct frm = new FrmProduct();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlProduct.Controls.Add(frm);
            frm.Show();
        }
        #endregion

        #region 退出事件方法
        /// <summary>
        /// 退出事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 单击首页事件方法
        /// <summary>
        /// 单击首页事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbM_Click(object sender, EventArgs e)
        {
            FrmMain_PnlMain frm = new FrmMain_PnlMain();
            ShowMain(frm);
        }
        #endregion

        #region 显示事件方法
        /// <summary>
        /// 显示事件方法
        /// </summary>
        void ShowMain(Form frm)
        {
            pnlProduct.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlProduct.Controls.Add(frm);
            frm.Show();
        }
        #endregion

        #region 最新动态单击事件方法
        /// <summary>
        /// 最新动态单击事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbD_Click(object sender, EventArgs e)
        {
            Newdynamic.FrmNewdynamic frm = new Newdynamic.FrmNewdynamic();
            ShowMain(frm);
        }
        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
