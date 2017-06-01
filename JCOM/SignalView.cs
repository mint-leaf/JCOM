using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JCLib;
namespace JCOM
{
    public partial class SignalView : Form
    {
        public ArrayList Signals = new ArrayList(20);

        public SignalView(ArrayList Signals)
        {
            InitializeComponent();
            lvSignalList.BeginUpdate();
            lvSignalList.Columns.Add("名称", 80, HorizontalAlignment.Left);
            lvSignalList.Columns.Add("颜色", 50, HorizontalAlignment.Left);
            lvSignalList.Columns.Add("宽度", 50, HorizontalAlignment.Left);
            lvSignalList.Columns.Add("比例", 50, HorizontalAlignment.Left);

            if (Signals != null)
            {
                this.Signals = Signals;
                //显示所有信号基本属性
                foreach (Signal item in this.Signals)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.UseItemStyleForSubItems = false;
                    lvi.Text = item.Text;   //线名
                                            //颜色
                    ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.BackColor = item.LineColor;
                    lvi.SubItems.Add(lvsi);

                    lvi.SubItems.Add(item.LineWidth.ToString());//线宽
                    lvi.SubItems.Add(item.LineRatio.ToString());//放大系数
                    lvi.Tag = item;
                    lvSignalList.Items.Add(lvi);
                }
            }
           
            lvSignalList.EndUpdate();
           
        }
        //设置信号项显示
        private void SettingSignalItemView(ListViewItem lvi)
        {
            Signal item = (Signal)lvi.Tag;

            lvSignalList.BeginUpdate();
            lvi.SubItems.Clear();
               
            lvi.Text = item.Text;   //线名            
            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
            lvsi.BackColor = item.LineColor;
            lvi.SubItems.Add(lvsi);//颜色

            lvi.SubItems.Add(item.LineWidth.ToString());//线宽
            lvi.SubItems.Add(item.LineRatio.ToString());//放大系数
            lvSignalList.EndUpdate();
        }

        //添加信号
        private void AddSignal()
        {        
            SignalSetting ss = new SignalSetting();
            if(DialogResult.OK == ss.ShowDialog())
            {
                Signal item = ss.Signal;
                ListViewItem lvi = new ListViewItem();
                lvi.UseItemStyleForSubItems = false;
                lvi.Text = item.Text;   //线名                                        
                ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                lvsi.BackColor = item.LineColor;
                lvi.SubItems.Add(lvsi);//颜色

                lvi.SubItems.Add(item.LineWidth.ToString());//线宽
                lvi.SubItems.Add(item.LineRatio.ToString());//放大系数
                lvi.Tag = item;
                lvSignalList.Items.Add(lvi);
                this.Signals.Add(item);
            }
           
        }

        //信号设置
        private void SettingSignal()
        {      
            SignalSetting ss = new SignalSetting((Signal)lvSignalList.SelectedItems[0].Tag);
            if (DialogResult.OK == ss.ShowDialog())
            {
                Signal item = ss.Signal;
                Signals[lvSignalList.SelectedItems[0].Index] = item;
                lvSignalList.SelectedItems[0].Tag = item;                 
                SettingSignalItemView(lvSignalList.SelectedItems[0]);

            }
        }


        //双击设置信号
        private void lvSignalList_DoubleClick(object sender, EventArgs e)
        {
            SettingSignal();
        }
        //设置信号
        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingSignal();
        }

        //子菜单显示
        private void cmsOperateSignal_Opening(object sender, CancelEventArgs e)
        {
            if (lvSignalList.SelectedItems.Count == 0)
            {
                tsmiSetting.Enabled = false;
                tsmiDelete.Enabled = false;
            }
            else
            {
                tsmiSetting.Enabled = true;
                tsmiDelete.Enabled = true;

            }
        }
        //添加信号
        private void tsmiAdd_Click(object sender, EventArgs e)
        {
           AddSignal();
        }


 
        //保存设置
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            Signal.SaveSignals("signals.dat",Signals);
        }


        //关闭窗口，清除打开标记
        private void SignalView_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinHelper.SignalView = false;
        }
    }
}
 