using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPatternDemo
{
    class Program
    {
        //空对象模型-简单工厂模式
        //定义：一个空对象取代Null对象实例的检查，
        //意义：Null对象不是检查空值，而是反应一个不做任何动作的关系；
        //      Null对象在数据不可用的时候提供默认的行为；
        static void Main(string[] args)
        {
            AbstractCustomer customer1 = CustomerFactory.getCustomer("ROB");
            AbstractCustomer customer2 = CustomerFactory.getCustomer("joe");
            AbstractCustomer customer3 = CustomerFactory.getCustomer("Julie");
            AbstractCustomer customer4 = CustomerFactory.getCustomer("JOEE");

            Console.WriteLine("Customers");

            Console.WriteLine(customer1.getName());
            Console.WriteLine(customer2.getName());
            Console.WriteLine(customer3.getName());
            Console.WriteLine(customer4.getName());

            Console.Read();
        }
    }
}
