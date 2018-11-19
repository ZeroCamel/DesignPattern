using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPatternDemo
{
    //简单工厂
    class CustomerFactory
    {
        public static string[] names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer getCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name,StringComparison.OrdinalIgnoreCase))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
