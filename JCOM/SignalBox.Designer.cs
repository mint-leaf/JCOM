namespace JCOM
{
    partial class SignalBox
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
            this.pbSignal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSignal
            // 
            this.pbSignal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSignal.Location = new System.Drawing.Point(0, 0);
            this.pbSignal.Name = "pbSignal";
            this.pbSignal.Size = new System.Drawing.Size(639, 591);
            this.pbSignal.TabIndex = 0;
            this.pbSignal.TabStop = false;
            this.pbSignal.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSignal_Paint);
            // 
            // SignalBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 591);
            this.Controls.Add(this.pbSignal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SignalBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SignalBox";
            this.Activated += new System.EventHandler(this.SignalBox_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pbSignal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSignal;
    }
}