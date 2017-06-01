using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JCLib
{
    [Serializable]  //可序列化的,直接保存到文件
    public class Signal
    {
        static int id;
        public string Text="Line0";             //线名
        public  int LineId=0;                    //线id号
        public Color LineColor=Color.Black;     //线色      
        public int LineWidth=1;                 //线宽
        public float LineRatio=1.0f;            //放大系数
        public bool AutoFit = true;            // 自适应


        public SignalType Type;
        public long DataLength=0;

        public double[] Buffer = null;      //信号全部保存为doube类型
        public static int Id
        {
            get
            {
                return ++id;
            }
        }

        public Signal(string Text,Color LineColor,int LineWidth,float LineRatio,bool AutoFit)
        {

            this.Text = Text;
            this.LineColor = LineColor;
            this.LineWidth = LineWidth;
            this.LineRatio = LineRatio;
            this.AutoFit = AutoFit;

            //默认设置
            this.Type = SignalType.UINT8;
        }

        public Signal()
        {
        }
        static public void SaveSignals(string path, ArrayList signals)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, signals);
            fs.Close();
        }

        static public ArrayList LoadSignals(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ArrayList signals = bf.Deserialize(fs) as ArrayList;
            fs.Close();
            return signals;
        }

    }
}
