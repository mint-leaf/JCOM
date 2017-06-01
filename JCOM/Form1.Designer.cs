namespace JCOM
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSignals = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowSignals = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveSignals = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadSignals = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAddWindowXn = new System.Windows.Forms.ToolStripMenuItem();
            this.二维图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三维图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseSignalBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindowSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.排列ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiH = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiV = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.协议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSignals,
            this.窗口ToolStripMenuItem,
            this.设备ToolStripMenuItem,
            this.协议ToolStripMenuItem,
            this.记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSignals
            // 
            this.tsmiSignals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowSignals,
            this.tsmiSaveSignals,
            this.tsmiLoadSignals});
            this.tsmiSignals.Name = "tsmiSignals";
            this.tsmiSignals.Size = new System.Drawing.Size(51, 24);
            this.tsmiSignals.Text = "信号";
            // 
            // tsmiShowSignals
            // 
            this.tsmiShowSignals.Name = "tsmiShowSignals";
            this.tsmiShowSignals.Size = new System.Drawing.Size(114, 26);
            this.tsmiShowSignals.Text = "查看";
            this.tsmiShowSignals.Click += new System.EventHandler(this.tsmiShowSignals_Click_1);
            // 
            // tsmiSaveSignals
            // 
            this.tsmiSaveSignals.Name = "tsmiSaveSignals";
            this.tsmiSaveSignals.Size = new System.Drawing.Size(114, 26);
            this.tsmiSaveSignals.Text = "导出";
            this.tsmiSaveSignals.Click += new System.EventHandler(this.tsmiSaveSignals_Click);
            // 
            // tsmiLoadSignals
            // 
            this.tsmiLoadSignals.Name = "tsmiLoadSignals";
            this.tsmiLoadSignals.Size = new System.Drawing.Size(114, 26);
            this.tsmiLoadSignals.Text = "导入";
            this.tsmiLoadSignals.Click += new System.EventHandler(this.tsmiLoadSignals_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddBox,
            this.tsmiCloseSignalBox,
            this.tsmiWindowSetting,
            this.排列ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.导入ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // tsmiAddBox
            // 
            this.tsmiAddBox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiAddWindowXn,
            this.二维图ToolStripMenuItem,
            this.三维图ToolStripMenuItem});
            this.tsmiAddBox.Name = "tsmiAddBox";
            this.tsmiAddBox.Size = new System.Drawing.Size(129, 26);
            this.tsmiAddBox.Text = "添加";
            // 
            // tmsiAddWindowXn
            // 
            this.tmsiAddWindowXn.Name = "tmsiAddWindowXn";
            this.tmsiAddWindowXn.Size = new System.Drawing.Size(129, 26);
            this.tmsiAddWindowXn.Text = "序列图";
            this.tmsiAddWindowXn.Click += new System.EventHandler(this.tmsiWindowXn_Click);
            // 
            // 二维图ToolStripMenuItem
            // 
            this.二维图ToolStripMenuItem.Name = "二维图ToolStripMenuItem";
            this.二维图ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.二维图ToolStripMenuItem.Text = "二维图";
            // 
            // 三维图ToolStripMenuItem
            // 
            this.三维图ToolStripMenuItem.Name = "三维图ToolStripMenuItem";
            this.三维图ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.三维图ToolStripMenuItem.Text = "三维图";
            // 
            // tsmiCloseSignalBox
            // 
            this.tsmiCloseSignalBox.Name = "tsmiCloseSignalBox";
            this.tsmiCloseSignalBox.Size = new System.Drawing.Size(129, 26);
            this.tsmiCloseSignalBox.Text = "关闭";
            this.tsmiCloseSignalBox.Click += new System.EventHandler(this.tsmiCloseSignalBox_Click);
            // 
            // tsmiWindowSetting
            // 
            this.tsmiWindowSetting.Name = "tsmiWindowSetting";
            this.tsmiWindowSetting.Size = new System.Drawing.Size(129, 26);
            this.tsmiWindowSetting.Text = "控制器";
            this.tsmiWindowSetting.Click += new System.EventHandler(this.tsmiWindowSetting_Click);
            // 
            // 排列ToolStripMenuItem
            // 
            this.排列ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiF,
            this.tsmiH,
            this.tsmiV});
            this.排列ToolStripMenuItem.Name = "排列ToolStripMenuItem";
            this.排列ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.排列ToolStripMenuItem.Text = "排列";
            // 
            // tsmiF
            // 
            this.tsmiF.Name = "tsmiF";
            this.tsmiF.Size = new System.Drawing.Size(114, 26);
            this.tsmiF.Text = "层叠";
            this.tsmiF.Click += new System.EventHandler(this.tsmiF_Click);
            // 
            // tsmiH
            // 
            this.tsmiH.Name = "tsmiH";
            this.tsmiH.Size = new System.Drawing.Size(114, 26);
            this.tsmiH.Text = "水平";
            this.tsmiH.Click += new System.EventHandler(this.tsmiH_Click);
            // 
            // tsmiV
            // 
            this.tsmiV.Name = "tsmiV";
            this.tsmiV.Size = new System.Drawing.Size(114, 26);
            this.tsmiV.Text = "垂直";
            this.tsmiV.Click += new System.EventHandler(this.tsmiV_Click);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // 导入ToolStripMenuItem
            // 
            this.导入ToolStripMenuItem.Name = "导入ToolStripMenuItem";
            this.导入ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.导入ToolStripMenuItem.Text = "导入";
            // 
            // 设备ToolStripMenuItem
            // 
            this.设备ToolStripMenuItem.Name = "设备ToolStripMenuItem";
            this.设备ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.设备ToolStripMenuItem.Text = "设备";
            // 
            // 协议ToolStripMenuItem
            // 
            this.协议ToolStripMenuItem.Name = "协议ToolStripMenuItem";
            this.协议ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.协议ToolStripMenuItem.Text = "协议";
            // 
            // 记录ToolStripMenuItem
            // 
            this.记录ToolStripMenuItem.Name = "记录ToolStripMenuItem";
            this.记录ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.记录ToolStripMenuItem.Text = "记录";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 589);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignals;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddBox;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseSignalBox;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindowSetting;
        private System.Windows.Forms.ToolStripMenuItem 排列ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiF;
        private System.Windows.Forms.ToolStripMenuItem tsmiH;
        private System.Windows.Forms.ToolStripMenuItem tsmiV;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiAddWindowXn;
        private System.Windows.Forms.ToolStripMenuItem 二维图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三维图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 协议ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowSignals;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveSignals;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadSignals;
    }
}

