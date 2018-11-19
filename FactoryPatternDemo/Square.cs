using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemo
{
    /// <summary>
    /// 实现接口的具体类：正方形
    /// </summary>
    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw().method.");
        }
    }
}
