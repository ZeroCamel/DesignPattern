using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAccessDemo
{
    class Modifiers
    {
        static void AAA()
        {
            Console.WriteLine("Modifiers AAA");
        }

        public static void BBB()
        {
            Console.WriteLine("Modifiers BBB");
            AAA();
            CCC();
        }

        protected static void CCC()
        {
            Console.WriteLine("Modifiers CCC");
        }
    }
}
