using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEntityPatternDemo
{
    /// <summary>
    /// 组合实体模式
    /// 用在EJB对象持久化机制中
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.setData("TEST","DATA");
            client.printData();
            client.setData("SECOND TEST","DATA1");
            client.printData();

            Console.Read();
        }
    }
}
