using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JCLib;
namespace JCOM
{
    public partial class Form1 : Form
    {
        ArrayList Signals;                   //所有信号
        SignalView SignalView;               //信号查看窗口   
        private int idWindowBox = 0;        //信号窗口ID分配
        public int IdWindowBox
        {
            get
            {
                idWindowBox++;
                return idWindowBox;
            }

            set
            {
                idWindowBox = value;
            }
        }
        public Form1()
        {
            InitializeComponent();

           
        }



        #region 窗口排列
        private void tsmiF_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion



        /// <summary>
        /// 显示窗口管理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiWindowSetting_Click(object sender, EventArgs e)
        {
           
            WinHelper.WindowSetting = new WindowSetting();
            WinHelper.WindowSetting.Show();
        }
   
        /// <summary>
        /// 添加窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmsiWindowXn_Click(object sender, EventArgs e)
        {
            SignalBox sb = new SignalBox();
            sb.MdiParent = this;
            sb.Text = "SignalBox" + IdWindowBox;
            sb.Show();
        }
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCloseSignalBox_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void tsmiShowSignals_Click_1(object sender, EventArgs e)
        {
            if (WinHelper.SignalView == false)
            {
                
                this.SignalView = new SignalView(Signals);
                this.SignalView.Show();
                WinHelper.SignalView = true;
            }
            else
            {
                this.SignalView.BringToFront();
            }
        }

        private void tsmiSaveSignals_Click(object sender, EventArgs e)
        {
            Signal.SaveSignals("signals.dat", Signals);
        }
        private void tsmiLoadSignals_Click(object sender, EventArgs e)
        {
            Signals = Signal.LoadSignals("signals.dat");
        }
    }
}
