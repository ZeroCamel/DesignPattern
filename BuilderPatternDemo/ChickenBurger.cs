using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    class ChickenBurger : Burger
    {
        public override string name()
        {
            return "Chicken Burger";
        }

        public override float price()
        {
            return 50.5f;
        }
    }
}
