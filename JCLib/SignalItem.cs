using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;





namespace JCLib
{
    public partial class SignalItem: UserControl
    {
        public SignalItem()
        {
            InitializeComponent();
            
        }



        private ArrayList signals;
        private Signal signal;

        public ArrayList Signals
        {
            get
            {
                return signals;
            }

            set
            {
                if(value != null)
                {
                    foreach (Signal item in value)
                    {

                    }
                }

                signals = value;
            }
        }

        public Signal Signal
        {
            get
            {
                return signal;
            }

            set
            {
                signal = value;
            }
        }

        private void SignalItem_Paint(object sender, PaintEventArgs e)
        {
            //Bitmap bmp = new Bitmap(this.Width, this.Height);
            //Graphics g = Graphics.FromImage(bmp);
            //g.DrawRectangle(Pens.Black, 0, 0, this.Size.Width - 1, this.Size.Height - 1);
            //this.BackgroundImage = bmp;
            //this.Width = this.Parent.Width - 30;
        }
    }
}
