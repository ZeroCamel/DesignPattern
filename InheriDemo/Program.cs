using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Display1();

            //继承无法实现逆向调用，基类无法调用子类
            //Class2 c2 = new Class2();
            //c2.Display();
            Console.Read();
        }
    }
}
