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

namespace JCOM
{
    public partial class SignalSetting : Form
    {
        public Signal Signal;
        public SignalSetting(Signal signal)
        {
            InitializeComponent();

            tbText.Text = signal.Text;
            pbColor.BackColor = signal.LineColor;
            nudWidth.Value = signal.LineWidth;
            tbRatio.Text = signal.LineRatio.ToString();

            cbSignalType.SelectedIndex = (int)signal.Type;
        }

        public SignalSetting()
        {
            InitializeComponent();
            tbText.Text = "Line"+Signal.Id.ToString();
            pbColor.BackColor = Color.Red;
            nudWidth.Value = 1;
            tbRatio.Text = 1.0f.ToString();
            cbSignalType.SelectedIndex = 0;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
           
            this.Signal = new Signal(tbText.Text, pbColor.BackColor, (int)nudWidth.Value, float.Parse(tbRatio.Text),true);
            this.Signal.Type = (SignalType)cbSignalType.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SignalSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
