namespace JCOM
{
    partial class SignalSetting
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRatio = new System.Windows.Forms.TextBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.pbColor = new AForge.Controls.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSignalType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSignalDevice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(15, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRatio);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Controls.Add(this.pbColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 161);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本属性";
            // 
            // tbRatio
            // 
            this.tbRatio.Location = new System.Drawing.Point(57, 126);
            this.tbRatio.Name = "tbRatio";
            this.tbRatio.Size = new System.Drawing.Size(111, 25);
            this.tbRatio.TabIndex = 15;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(57, 91);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(111, 25);
            this.nudWidth.TabIndex = 14;
            // 
            // pbColor
            // 
            this.pbColor.Image = null;
            this.pbColor.Location = new System.Drawing.Point(57, 57);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(110, 23);
            this.pbColor.TabIndex = 13;
            this.pbColor.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "比例:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "线宽:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "颜色:";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(58, 18);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(110, 25);
            this.tbText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "名称:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSignalType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbSignalDevice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 175);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据设置";
            // 
            // cbSignalType
            // 
            this.cbSignalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalType.FormattingEnabled = true;
            this.cbSignalType.Items.AddRange(new object[] {
            "UINT8",
            "INT8",
            "UINT16",
            "INT16",
            "UINT32",
            "INT32",
            "UINT64",
            "INT64",
            "F32"});
            this.cbSignalType.Location = new System.Drawing.Point(58, 53);
            this.cbSignalType.Name = "cbSignalType";
            this.cbSignalType.Size = new System.Drawing.Size(111, 23);
            this.cbSignalType.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "类型:";
            // 
            // cbSignalDevice
            // 
            this.cbSignalDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSignalDevice.FormattingEnabled = true;
            this.cbSignalDevice.Items.AddRange(new object[] {
            "串口",
            "TCP",
            "UDP",
            "USB",
            "软件",
            "模拟"});
            this.cbSignalDevice.Location = new System.Drawing.Point(58, 24);
            this.cbSignalDevice.Name = "cbSignalDevice";
            this.cbSignalDevice.Size = new System.Drawing.Size(111, 23);
            this.cbSignalDevice.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "设备:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(175, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SignalSetting
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(281, 451);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignalSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignalSetting";
            this.Load += new System.EventHandler(this.SignalSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRatio;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private AForge.Controls.PictureBox pbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbSignalType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSignalDevice;
        private System.Windows.Forms.Label label6;
    }
}