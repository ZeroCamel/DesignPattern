using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    [Serializable]
    public class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }
        public override void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
