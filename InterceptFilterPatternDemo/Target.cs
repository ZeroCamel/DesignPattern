using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptFilterPatternDemo
{
    //创建目标处理程序
    public class Target
    {
        public void execute(string request)
        {
            Console.WriteLine("Executing request:" + request);
        }
    }
}
