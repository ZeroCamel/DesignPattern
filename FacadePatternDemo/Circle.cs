using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemo
{
    /// <summary>
    /// 实现接口的实体类：圆
    /// </summary>
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw().method.");
        }
    }
}
