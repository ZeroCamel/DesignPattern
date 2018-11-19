using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //装饰器模式对现有类的包装，保持类方法完整签名的前提下，提供额外的功能
            //允许向现有对象添加新功能，同时又不影响其结构
            //意图：动态给对象增加额外的职责，继承可以扩展类，但由于功能的增多，子类会膨胀
            //使用：不想增加很多类的情况下扩展类
            //优点：装饰器是继承的替代模式、可以独立发展、并不会耦合、动态扩展实例功能、动态撤销
            //缺点：多层装饰比较复杂
            Shape circle = new Circle();

            Shape redCircle = new RedShapeDecorator(new Circle());

            Shape redRectangle = new RedShapeDecorator(new Rectangle());

            Console.WriteLine("Circle with nomal border");
            circle.Draw();

            Console.WriteLine("Circle with red border");
            redCircle.Draw();

            Console.WriteLine("Circle with redTangle");
            redRectangle.Draw();

            Console.Read();
        }
    }
}
