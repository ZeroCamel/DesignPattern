using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunPolyDemo
{
    class ClassA : ClassB
    {
        public override void AAA()
        {
            Console.WriteLine("ClassA AAA");
        }
        public new void BBB()
        {
            Console.WriteLine("ClassA BBB");
        }
        public new void CCC()
        {
            Console.WriteLine("ClassA CCC");
        }
    }
}
