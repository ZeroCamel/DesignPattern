using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    //创建实体服务
    public class Service1:Service
    {
        public string getName()
        {
            return "Service1";
        }

        public void execute()
        {
            Console.WriteLine("Execute Service1");
        }
    }
}