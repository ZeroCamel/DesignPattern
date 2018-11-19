using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape) : base(decoratedShape) { }
        public override void Draw()
        {
            decoratedShape.Draw();
            SetRetBorder(decoratedShape);
        }

        public void SetRetBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border Color:Red");
        }
    }
}
