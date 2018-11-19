using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunPolyDemo
{
    //运行时多态 方法重写 迟绑定
    class Program
    {
        static void Main(string[] args)
        {
            //ClassB y = new ClassB();
            //ClassA x = new ClassA();
            //ClassB z = new ClassA();

            //y.AAA(); y.BBB(); y.CCC();
            //x.AAA(); x.BBB(); x.CCC();
            //z.AAA(); z.BBB(); z.CCC();

            //虚方法检索顺序 从根到当前再到
            Person a = new Person();
            a.Eat();

            Student s = new Student();
            s.Eat();

            Console.ReadKey();
        }
    }
}
