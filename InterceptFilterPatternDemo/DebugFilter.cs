using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptFilterPatternDemo
{
    //创建实体过滤器
    public class DebugFilter : Filter
    {
        public void execute(string request)
        {
            Console.WriteLine("Request Log:" + request);
        }
    }
}
