#define DEBUG

using System;
using System.Collections.Generic;

using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    //特性：运行时传递程序中各种元素（类、方法、结构、枚举、组件等）行为信息的声明标签
    //分类：预定义特性和自定义特性
    class Program
    {
        static void Function1()
        {
            MyClass.Message("In Funtion1");
            Function2();
        }
        static void Function2()
        {
            MyClass.Message("In Function2");
        }
        static void Main(string[] args)
        {
            //MyClass.Message("In Function");
            //Function1();
            //Console.ReadKey();

            //获取元素特性 
            System.Reflection.MemberInfo info = typeof(Person);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                HelpAttribute attr = (HelpAttribute)attributes[i];
                Console.WriteLine("{0} {1}", attr.message, attr);
            }
            Console.WriteLine("------------------");
            System.Reflection.MemberInfo info1 = typeof(PersonA);
            object[] attributes1 = info1.GetCustomAttributes(true);
            for (int i = 0; i < attributes1.Length; i++)
            {
                HelpAttribute attr1 = (HelpAttribute)attributes1[i];
                Console.WriteLine("{0} {1}", attr1.message, attr1);
            }
            //AllowMultiple =false,Inherited =false/true ; Result=base-subclass
            //AllowMultiple =true,Inherited =true ; Reulst=base baseclass - subclass base baseclass
            //AllowMultiple =true,Inherited =false ; Result=base baseclass = subclass
            Console.Read();
        }
    }
    public class MyClass
    {
        [Conditional("DEBUG")] 
        //条件编译
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
