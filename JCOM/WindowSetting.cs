using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JCLib;
using System.Collections;

namespace JCOM
{
    public partial class WindowSetting : Form
    {
        ArrayList Signals;

        public WindowSetting()
        {
            InitializeComponent();
        }
        private void WindowSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinHelper.WindowSetting = null;
  
        }

        private void tsmiAddSignalItem_Click(object sender, EventArgs e)
        {
            //Signa
          
            SignalItem si = new SignalItem();
            si.Dock = DockStyle.Top;
            plSignalItems.Controls.Add(si);    
        }

        private void flpSignalItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
