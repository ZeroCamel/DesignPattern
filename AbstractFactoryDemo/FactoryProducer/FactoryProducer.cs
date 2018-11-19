using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (choice.Equals("shape", StringComparison.OrdinalIgnoreCase))
            {
                return new ShapeFactory();
            }
            if (choice.Equals("color", StringComparison.OrdinalIgnoreCase))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
