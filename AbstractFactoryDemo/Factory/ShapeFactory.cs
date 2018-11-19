using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// 工厂类：生成基于给定实体类的对象-动态创建
    /// </summary>
    public class ShapeFactory : AbstractFactory
    {
        public override Shape getShapType(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("Circle", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            if (shapeType.Equals("Rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            if (shapeType.Equals("Square", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }
            return null;
        }

        public override Color getColor(string color)
        {
            return null;
        }
    }
}
