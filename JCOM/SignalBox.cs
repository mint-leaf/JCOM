using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JCLib;

namespace JCOM
{


    /// <summary>
    /// 用于显示信号图像
    /// </summary>
    public partial class SignalBox : Form    {

        WindowSetting WindowSetting;
        ArrayList Signals = null;
        long PointNumber = 1000;        //显示1000个点
        public SignalBox()
        {
            InitializeComponent();
            //  pbSignal.BackColor = Color.FromArgb(255, 0x1e, 0x1e, 0x1e);
            pbSignal.BackColor = Color.White;
        }


        /// <summary>
        /// 激活时更新窗口控制器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignalBox_Activated(object sender, EventArgs e)
        {
    
                if (WinHelper.WindowSetting != null)
                {
                    
                }
        }

        private void pbSignal_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.DrawLine(Pens.White, 0, 0, 500, 500);
            if (Signals == null) return;

            foreach (Signal item in Signals)        //绘制所有曲线
            {
                double[] buffer;
                if(item.Buffer.Length < 1000)
                {
                    buffer = item.Buffer;
                }
                else
                {
                    buffer = new double[1000];
                    Array.Copy(item.Buffer,item.Buffer.Length - PointNumber, buffer, 0, PointNumber);
                }
            }
        }
    }
}
