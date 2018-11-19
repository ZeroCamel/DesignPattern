using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunPolyDemo
{
    //三个类的运行时多态
    class ClassC:ClassA
    {
        public override void AAA()
        {
            Console.WriteLine("ClassC AAA");
        }

        public  void CCC()
        {
            Console.WriteLine("ClassC CCC");
        }
    }
}
