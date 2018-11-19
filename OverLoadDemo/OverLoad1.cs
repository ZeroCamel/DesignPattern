using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadDemo
{
    class OverLoad1
    {
        private string name = "Akhil";

        public void Display()
        {
            Display2(ref name, ref name);
            Console.WriteLine(name);
        }

        //引用传值 传的是变量的内存地址 
        private void Display2(ref string x,ref string y)
        {
            Console.WriteLine(name);

            //修改X Y的值 相当于修改NAME的值
            x = "Akhil 1";
            Console.WriteLine(name);

            y = "Akhil 2";
            Console.WriteLine(name);

            name = "Akhil 3";
        }
    }
}
