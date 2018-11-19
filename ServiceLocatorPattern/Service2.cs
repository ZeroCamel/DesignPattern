using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    //创建实体服务
    public class Service2:Service
    {
        public string getName()
        {
            return "Service2";
        }

        public void execute()
        {
            Console.WriteLine("Execute Service2");
        }
    }
}
