namespace JCLib
{
    partial class SignalItem
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSignalName = new System.Windows.Forms.ComboBox();
            this.pbLineColor = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.nudLineWidth = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSignalName
            // 
            this.cbSignalName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalName.FormattingEnabled = true;
            this.cbSignalName.Location = new System.Drawing.Point(15, 15);
            this.cbSignalName.Name = "cbSignalName";
            this.cbSignalName.Size = new System.Drawing.Size(121, 23);
            this.cbSignalName.TabIndex = 0;
            // 
            // pbLineColor
            // 
            this.pbLineColor.BackColor = System.Drawing.Color.Red;
            this.pbLineColor.Location = new System.Drawing.Point(15, 53);
            this.pbLineColor.Name = "pbLineColor";
            this.pbLineColor.Size = new System.Drawing.Size(121, 16);
            this.pbLineColor.TabIndex = 1;
            this.pbLineColor.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(142, 15);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(142, 46);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(256, 46);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(25, 23);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(287, 46);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(25, 23);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // nudLineWidth
            // 
            this.nudLineWidth.Location = new System.Drawing.Point(173, 44);
            this.nudLineWidth.Name = "nudLineWidth";
            this.nudLineWidth.Size = new System.Drawing.Size(62, 25);
            this.nudLineWidth.TabIndex = 7;
            this.nudLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(287, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "×";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SignalItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nudLineWidth);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbLineColor);
            this.Controls.Add(this.cbSignalName);
            this.Name = "SignalItem";
            this.Size = new System.Drawing.Size(325, 77);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SignalItem_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbLineColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSignalName;
        private System.Windows.Forms.PictureBox pbLineColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.NumericUpDown nudLineWidth;
        private System.Windows.Forms.Button button2;
    }
}
