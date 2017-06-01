namespace JCOM
{
    partial class WindowSetting
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAddSignalItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plSignalItems = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddSignalItem,
            this.删除ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAddSignalItem
            // 
            this.tsmiAddSignalItem.Name = "tsmiAddSignalItem";
            this.tsmiAddSignalItem.Size = new System.Drawing.Size(51, 24);
            this.tsmiAddSignalItem.Text = "添加";
            this.tsmiAddSignalItem.Click += new System.EventHandler(this.tsmiAddSignalItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // plSignalItems
            // 
            this.plSignalItems.AutoScroll = true;
            this.plSignalItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plSignalItems.Location = new System.Drawing.Point(0, 28);
            this.plSignalItems.Name = "plSignalItems";
            this.plSignalItems.Size = new System.Drawing.Size(458, 442);
            this.plSignalItems.TabIndex = 1;
            // 
            // WindowSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(458, 470);
            this.Controls.Add(this.plSignalItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 2000);
            this.Name = "WindowSetting";
            this.Text = "WindowSetting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WindowSetting_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSignalItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private JCLib.SignalItem signalItem1;
        private System.Windows.Forms.Panel plSignalItems;
    }
}