using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemo
{
    //Shape子类圆
    class Circle : Shape
    {
        private string color;
        private int x;
        private int y;
        private int radius;

        public Circle(string color)
        {
            this.color = color;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Circle Draw()[Color:" + this.color + ",X:" + x + ",Y:" + this.y + ",Radius:" + this.radius + "]");
        }
    }
}
