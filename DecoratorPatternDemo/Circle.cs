using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class Circle:Shape
    {
        public void Draw()
        {
            Console.WriteLine("Shape:Circle");
        }
    }
}
