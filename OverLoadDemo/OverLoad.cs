using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadDemo
{
    class OverLoad
    {
        public void DisplayOverLoad(int a)
        {
            Console.WriteLine("DisplayOverLoad:" + a);
        }
        public void DisplayOverLoad(string a)
        {
            Console.WriteLine("DisplayOverLoad:" + a);
        }
        public void DisplayOverLoad(string a, int b)
        {
            Console.WriteLine("DisplayOverLoad:" + a + b);
        }

        //返回值不作为多态函数签名
        //public void DisplayOverLoad() { }
        //public int DisplayOverLoad() { return 0; }

        //static的可见修饰符不作为重载签名
        //static void DisplayOverload(int a) { }
        //public void DisplayOverload(int a) { }
        //public void DisplayOverload(string a) { }

        //ref out 传递参数修饰符也不能作为重载签名
        //private void DisplayOverload(int a) { }

        //private void DisplayOverload(out int a)
        //{
        //    a = 100;
        //}

        //private void DisplayOverload(ref int a) { }

        //多态中Parameter的作用

        //一个函数可包含4种类型的参数传递
        //值传递
        //引用传递
        //作为OUTPUT参数
        //使用参数数组

        //public void DisplayOverLoad(int a, string a) { }

        //相同的作用域中 参数必须统一
        //public void Display(int a )
        //{
        //    string a;
        //}
    }
}
