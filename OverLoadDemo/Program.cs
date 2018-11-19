using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadDemo
{
    class Program
    {
        //编译器的多态-早期绑定和方法重载
        static void Main(string[] args)
        {
            OverLoad overload = new OverLoad();
            overload.DisplayOverLoad(100);
            overload.DisplayOverLoad("Method Loading");
            overload.DisplayOverLoad("Method Loading", 100);

            OverLoad1 o1 = new OverLoad1();
            o1.Display();

            //非常巧妙的进行非params函数的精确匹配优先
            OverLoad3 o3 = new OverLoad3();
            o3.Display();

            Console.Read();
        }
    }
}
