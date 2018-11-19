using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemo
{
    /// <summary>
    /// 实现接口的实体类：矩形
    /// </summary>
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw().method.");
        }
    }
}
