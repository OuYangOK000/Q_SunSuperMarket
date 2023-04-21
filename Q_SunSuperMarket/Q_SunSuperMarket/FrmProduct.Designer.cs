namespace Q_SunSuperMarket
{
    partial class FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cmsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.购买ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboProType = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.CdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.cmsDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "商品类型：";
            // 
            // txtProName
            // 
            this.txtProName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProName.Location = new System.Drawing.Point(580, 41);
            this.txtProName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(178, 34);
            this.txtProName.TabIndex = 1;
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdId,
            this.CdTid,
            this.PcName,
            this.CdPrice,
            this.CdAmount,
            this.UserName});
            this.dgvProduct.ContextMenuStrip = this.cmsDGV;
            this.dgvProduct.Location = new System.Drawing.Point(2, 135);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 27;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1013, 437);
            this.dgvProduct.TabIndex = 2;
            // 
            // cmsDGV
            // 
            this.cmsDGV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.购买ToolStripMenuItem});
            this.cmsDGV.Name = "cmsDGV";
            this.cmsDGV.Size = new System.Drawing.Size(109, 52);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // 购买ToolStripMenuItem
            // 
            this.购买ToolStripMenuItem.Name = "购买ToolStripMenuItem";
            this.购买ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.购买ToolStripMenuItem.Text = "购买";
            // 
            // cboProType
            // 
            this.cboProType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProType.FormattingEnabled = true;
            this.cboProType.Location = new System.Drawing.Point(178, 44);
            this.cboProType.Name = "cboProType";
            this.cboProType.Size = new System.Drawing.Size(178, 31);
            this.cboProType.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(829, 39);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(137, 46);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // CdId
            // 
            this.CdId.DataPropertyName = "CdId";
            this.CdId.HeaderText = "编号";
            this.CdId.MinimumWidth = 6;
            this.CdId.Name = "CdId";
            this.CdId.ReadOnly = true;
            // 
            // CdTid
            // 
            this.CdTid.DataPropertyName = "CdTid";
            this.CdTid.HeaderText = "商品类型";
            this.CdTid.MinimumWidth = 6;
            this.CdTid.Name = "CdTid";
            this.CdTid.ReadOnly = true;
            // 
            // PcName
            // 
            this.PcName.DataPropertyName = "PcName";
            this.PcName.HeaderText = "商品名称";
            this.PcName.MinimumWidth = 6;
            this.PcName.Name = "PcName";
            this.PcName.ReadOnly = true;
            // 
            // CdPrice
            // 
            this.CdPrice.DataPropertyName = "CdPrice";
            this.CdPrice.HeaderText = "商品价格";
            this.CdPrice.MinimumWidth = 6;
            this.CdPrice.Name = "CdPrice";
            this.CdPrice.ReadOnly = true;
            // 
            // CdAmount
            // 
            this.CdAmount.DataPropertyName = "CdAmount";
            this.CdAmount.HeaderText = "库存";
            this.CdAmount.MinimumWidth = 6;
            this.CdAmount.Name = "CdAmount";
            this.CdAmount.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "购买人";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 572);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cboProType);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.cmsDGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cboProType;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ContextMenuStrip cmsDGV;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 购买ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}