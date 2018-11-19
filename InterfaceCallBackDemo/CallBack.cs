using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCallBackDemo
{
    class CallBack:IBack
    {
        public void Run()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
