namespace JCOM
{
    partial class SignalView
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
            this.lvSignalList = new System.Windows.Forms.ListView();
            this.cmsOperateSignal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOperateSignal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSignalList
            // 
            this.lvSignalList.ContextMenuStrip = this.cmsOperateSignal;
            this.lvSignalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSignalList.GridLines = true;
            this.lvSignalList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSignalList.Location = new System.Drawing.Point(0, 0);
            this.lvSignalList.MultiSelect = false;
            this.lvSignalList.Name = "lvSignalList";
            this.lvSignalList.Size = new System.Drawing.Size(340, 510);
            this.lvSignalList.TabIndex = 0;
            this.lvSignalList.UseCompatibleStateImageBehavior = false;
            this.lvSignalList.View = System.Windows.Forms.View.Details;
            this.lvSignalList.DoubleClick += new System.EventHandler(this.lvSignalList_DoubleClick);
            // 
            // cmsOperateSignal
            // 
            this.cmsOperateSignal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOperateSignal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiDelete,
            this.tsmiSetting,
            this.tsmiSave});
            this.cmsOperateSignal.Name = "cmsOperateSignal";
            this.cmsOperateSignal.Size = new System.Drawing.Size(115, 108);
            this.cmsOperateSignal.Opening += new System.ComponentModel.CancelEventHandler(this.cmsOperateSignal_Opening);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(114, 26);
            this.tsmiAdd.Text = "添加";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(114, 26);
            this.tsmiDelete.Text = "删除";
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(114, 26);
            this.tsmiSetting.Text = "设置";
            this.tsmiSetting.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(114, 26);
            this.tsmiSave.Text = "保存";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // SignalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 510);
            this.Controls.Add(this.lvSignalList);
            this.Name = "SignalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignalView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignalView_FormClosed);
            this.cmsOperateSignal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSignalList;
        private System.Windows.Forms.ContextMenuStrip cmsOperateSignal;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
    }
}