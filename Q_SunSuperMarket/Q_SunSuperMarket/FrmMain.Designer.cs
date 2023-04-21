namespace Q_SunSuperMarket
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timMain = new System.Windows.Forms.Timer(this.components);
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbM = new System.Windows.Forms.ToolStripButton();
            this.tsbD = new System.Windows.Forms.ToolStripButton();
            this.tsbC = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiProSel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbUser = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiUserA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserAddPro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRe = new System.Windows.Forms.ToolStripButton();
            this.tsbL = new System.Windows.Forms.ToolStripButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.gbTreeView = new System.Windows.Forms.GroupBox();
            this.tvPro = new System.Windows.Forms.TreeView();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.ilProduct = new System.Windows.Forms.ImageList(this.components);
            this.ssMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.gbTreeView.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslUser,
            this.toolStripStatusLabel2,
            this.tsslDate,
            this.toolStripStatusLabel3,
            this.tsslTime,
            this.toolStripStatusLabel4});
            this.ssMain.Location = new System.Drawing.Point(0, 619);
            this.ssMain.Name = "ssMain";
            this.ssMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssMain.Size = new System.Drawing.Size(1183, 26);
            this.ssMain.TabIndex = 0;
            this.ssMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "欢迎您";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(236, 20);
            this.tsslUser.Spring = true;
            this.tsslUser.Text = " ";
            this.tsslUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel2.Text = "当前日期：";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslDate
            // 
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(236, 20);
            this.tsslDate.Spring = true;
            this.tsslDate.Text = " ";
            this.tsslDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel3.Text = "当前时间：";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(236, 20);
            this.tsslTime.Spring = true;
            this.tsslTime.Text = " ";
            this.tsslTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(236, 20);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.Text = " ";
            // 
            // timMain
            // 
            this.timMain.Interval = 1000;
            this.timMain.Tick += new System.EventHandler(this.timMain_Tick);
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMain.BackgroundImage")));
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbM,
            this.tsbD,
            this.tsbC,
            this.toolStripButton2,
            this.tsbUser,
            this.tsbRe,
            this.tsbL,
            this.tsbHelp,
            this.tsbExit});
            this.tsMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMain.Size = new System.Drawing.Size(1183, 41);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "tsMain";
            // 
            // tsbM
            // 
            this.tsbM.Image = ((System.Drawing.Image)(resources.GetObject("tsbM.Image")));
            this.tsbM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbM.Name = "tsbM";
            this.tsbM.Size = new System.Drawing.Size(63, 38);
            this.tsbM.Text = "首页";
            this.tsbM.Click += new System.EventHandler(this.tsbM_Click);
            // 
            // tsbD
            // 
            this.tsbD.Image = ((System.Drawing.Image)(resources.GetObject("tsbD.Image")));
            this.tsbD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbD.Name = "tsbD";
            this.tsbD.Size = new System.Drawing.Size(93, 38);
            this.tsbD.Text = "最新动态";
            this.tsbD.Click += new System.EventHandler(this.tsbD_Click);
            // 
            // tsbC
            // 
            this.tsbC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWeek,
            this.tsmiMonth});
            this.tsbC.Image = ((System.Drawing.Image)(resources.GetObject("tsbC.Image")));
            this.tsbC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbC.Name = "tsbC";
            this.tsbC.Size = new System.Drawing.Size(103, 38);
            this.tsbC.Text = "促销活动";
            // 
            // tsmiWeek
            // 
            this.tsmiWeek.Image = ((System.Drawing.Image)(resources.GetObject("tsmiWeek.Image")));
            this.tsmiWeek.Name = "tsmiWeek";
            this.tsmiWeek.Size = new System.Drawing.Size(152, 26);
            this.tsmiWeek.Text = "本周活动";
            // 
            // tsmiMonth
            // 
            this.tsmiMonth.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMonth.Image")));
            this.tsmiMonth.Name = "tsmiMonth";
            this.tsmiMonth.Size = new System.Drawing.Size(152, 26);
            this.tsmiMonth.Text = "本月活动";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProSel,
            this.tsmiProAdd});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(103, 38);
            this.toolStripButton2.Text = "商品操作";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsmiProSel
            // 
            this.tsmiProSel.Image = ((System.Drawing.Image)(resources.GetObject("tsmiProSel.Image")));
            this.tsmiProSel.Name = "tsmiProSel";
            this.tsmiProSel.Size = new System.Drawing.Size(152, 26);
            this.tsmiProSel.Text = "商品查询";
            this.tsmiProSel.Click += new System.EventHandler(this.tsmiProSel_Click);
            // 
            // tsmiProAdd
            // 
            this.tsmiProAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiProAdd.Image")));
            this.tsmiProAdd.Name = "tsmiProAdd";
            this.tsmiProAdd.Size = new System.Drawing.Size(152, 26);
            this.tsmiProAdd.Text = "付款界面";
            // 
            // tsbUser
            // 
            this.tsbUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserA,
            this.tsmiUserAddPro});
            this.tsbUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbUser.Image")));
            this.tsbUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUser.Name = "tsbUser";
            this.tsbUser.Size = new System.Drawing.Size(103, 38);
            this.tsbUser.Text = "个人中心";
            // 
            // tsmiUserA
            // 
            this.tsmiUserA.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUserA.Image")));
            this.tsmiUserA.Name = "tsmiUserA";
            this.tsmiUserA.Size = new System.Drawing.Size(152, 26);
            this.tsmiUserA.Text = "用户资料";
            // 
            // tsmiUserAddPro
            // 
            this.tsmiUserAddPro.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUserAddPro.Image")));
            this.tsmiUserAddPro.Name = "tsmiUserAddPro";
            this.tsmiUserAddPro.Size = new System.Drawing.Size(152, 26);
            this.tsmiUserAddPro.Text = "购买记录";
            // 
            // tsbRe
            // 
            this.tsbRe.Image = ((System.Drawing.Image)(resources.GetObject("tsbRe.Image")));
            this.tsbRe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRe.Name = "tsbRe";
            this.tsbRe.Size = new System.Drawing.Size(93, 38);
            this.tsbRe.Text = "留言反馈";
            // 
            // tsbL
            // 
            this.tsbL.Image = ((System.Drawing.Image)(resources.GetObject("tsbL.Image")));
            this.tsbL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbL.Name = "tsbL";
            this.tsbL.Size = new System.Drawing.Size(93, 38);
            this.tsbL.Text = "联系我们";
            // 
            // tsbHelp
            // 
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(63, 38);
            this.tsbHelp.Text = "帮助";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(93, 38);
            this.tsbExit.Text = "退出系统";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // gbTreeView
            // 
            this.gbTreeView.Controls.Add(this.tvPro);
            this.gbTreeView.Font = new System.Drawing.Font("宋体", 14F);
            this.gbTreeView.Location = new System.Drawing.Point(12, 44);
            this.gbTreeView.Name = "gbTreeView";
            this.gbTreeView.Size = new System.Drawing.Size(234, 572);
            this.gbTreeView.TabIndex = 0;
            this.gbTreeView.TabStop = false;
            this.gbTreeView.Text = "商品信息";
            // 
            // tvPro
            // 
            this.tvPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvPro.Location = new System.Drawing.Point(3, 30);
            this.tvPro.Name = "tvPro";
            this.tvPro.Size = new System.Drawing.Size(228, 539);
            this.tvPro.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.pnlProduct);
            this.gbMain.Font = new System.Drawing.Font("宋体", 14F);
            this.gbMain.Location = new System.Drawing.Point(252, 44);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(925, 569);
            this.gbMain.TabIndex = 2;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "主界面";
            // 
            // pnlProduct
            // 
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProduct.Location = new System.Drawing.Point(3, 30);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(919, 536);
            this.pnlProduct.TabIndex = 0;
            // 
            // ilProduct
            // 
            this.ilProduct.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilProduct.ImageSize = new System.Drawing.Size(16, 16);
            this.ilProduct.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 645);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbTreeView);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.ssMain);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阳光超市";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.gbTreeView.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.Timer timMain;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripButton tsbM;
        private System.Windows.Forms.ToolStripButton tsbD;
        private System.Windows.Forms.ToolStripButton tsbRe;
        private System.Windows.Forms.ToolStripButton tsbL;
        private System.Windows.Forms.ToolStripDropDownButton tsbUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserA;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserAddPro;
        private System.Windows.Forms.ToolStripDropDownButton tsbC;
        private System.Windows.Forms.ToolStripMenuItem tsmiWeek;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonth;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem tsmiProSel;
        private System.Windows.Forms.GroupBox gbTreeView;
        private System.Windows.Forms.TreeView tvPro;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ImageList ilProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiProAdd;
    }
}

