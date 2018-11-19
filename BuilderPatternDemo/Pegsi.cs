using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    class Pegsi : ColdDrink
    {
        public override string name()
        {
            return "Pepsi";
        }

        public override float price()
        {
            return 60.0f;
        }
    }
}
