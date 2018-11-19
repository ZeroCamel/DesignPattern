using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    public abstract class ColdDrink : Item
    {
        public abstract string name();

        public Packing pack()
        {
            return new Bottle();
        }

        public abstract float price();
    }
}
