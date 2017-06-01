using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCOM
{
    public enum SignalDevice
    {
        UART = 0,   //串口
        TCP,        //TCP
        UDP,        //UDP
        USB,
        SOFTWARE,   //软件转换
        MONITOR,    //模拟器
    }
}
