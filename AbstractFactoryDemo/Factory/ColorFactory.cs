using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    class ColorFactory : AbstractFactory
    {
        public override Shape getShapType(string shapeType)
        {
            return null;
        }

        public override Color getColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.Equals("red", StringComparison.OrdinalIgnoreCase))
            {
                return new Red();
            }
            if (color.Equals("gree", StringComparison.OrdinalIgnoreCase))
            {
                return new Red();
            }
            if (color.Equals("blue", StringComparison.OrdinalIgnoreCase))
            {
                return new Red();
            }
            return null;
        }
    }
}
