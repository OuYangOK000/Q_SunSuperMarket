using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q_Models;
using Q_BLL;

namespace Q_SunSuperMarket
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            Type(this, 25, 0.1);
        }
        private void Type(Control sender, int p_1, double p_2)
        {
            GraphicsPath oPath = new GraphicsPath();
            oPath.AddClosedCurve(new Point[] {
            new Point(0, sender.Height / p_1),
            new Point(sender.Width / p_1, 0),
            new Point(sender.Width - sender.Width / p_1, 0),
            new Point(sender.Width, sender.Height / p_1),
            new Point(sender.Width, sender.Height - sender.Height / p_1),
            new Point(sender.Width - sender.Width / p_1, sender.Height),
            new Point(sender.Width / p_1, sender.Height),
            new Point(0, sender.Height - sender.Height / p_1) }, (float)p_2);
            sender.Region = new Region(oPath);
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            Type(this, 25, 0.1);
        }

        #region 登录事件方法
        /// <summary>
        /// 登录事件方法 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Users user = UserBLL.GetUserByUserName(txtLoginId.Text);
                if (user == null)
                {
                    MessageBox.Show("您输入的用户名不存在，请重新输入！", "登录提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLoginId.Focus();//聚焦
                    return;
                }
                else
                {
                    if (user.UserPwd != txtPwd.Text)
                    {
                        MessageBox.Show("您输入的密码错误，请重新输入！", "登录提示",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPwd.Focus();//聚焦
                        return;
                    }
                    else
                    {
                        this.Hide();
                        FrmMain frm = new FrmMain();
                        frm.UserId = txtLoginId.Text;
                        frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误："+ex.Message);
            }
        }
        #endregion

        #region 窗体加载事件方法
        /// <summary>
        /// 窗体加载事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        } 
        #endregion
    }
}
