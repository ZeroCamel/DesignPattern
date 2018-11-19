using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCallBackDemo
{
    public class Controller
    {
        //接口注入 引用回调函数
        public IBack CallBackObj = null;
        public Controller(IBack obj)
        {
            this.CallBackObj = obj;
        }
        public void Star()
        {
            Console.WriteLine("敲任意键盘键显示当前时间，直接按ESC推出");
            while (Console.ReadKey(true).Key!=ConsoleKey.Escape)
            {
                CallBackObj.Run();
            }
        }
    }
}
