using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemo
{
    class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, DrawAPI drawApi)
            : base(drawApi) //调用抽象类-父类的构造函数
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public override void draw()
        {
            drawApi.drawCircle(radius, x, y);
        }
    }
}
