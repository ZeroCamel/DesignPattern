using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using AccessModifiersLibrary;

namespace InternalAccessDemo
{
    //internal 将访问级别限制在同一命名空间下 即同一程序集下
    class Program
    {
        static void Main(string[] args)
        {
            Modifiers.BBB();
            //AAA 受访问级别限制 不可访问
            //Modifiers.AAA();

            //protected 只能是同类和子类可以访问，外部无法访问
            //Modifiers.CCC();

            //Class1 class1;

            //            public
            //同一程序集中的任何其他代码或引用该程序集的其他程序集都可以访问该类型或成员。

            //private

            //只有同一类或结构中的代码可以访问该类型或成员。

            //protected

            //只有同一类或结构或者此类的派生类中的代码才可以访问的类型或成员。

            //internal

            //同一程序集中的任何代码都可以访问该类型或成员，但其他程序集中的代码不可以。

            //protected internal

            //由其声明的程序集或另一个程序集派生的类中任何代码都可访问的类型或成员。 从另一个程序集进行访问必须在类声明中发生，该类声明派生自其中声明受保护的内部元素的类，并且必须通过派生的类类型的实例发生。
        }
    }
}
