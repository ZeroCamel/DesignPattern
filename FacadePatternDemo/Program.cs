using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemo
{
    class Program
    {
        //提供一组接口的高一层接口
        //接待员 定义系统的入口
        //层次化结构中定义每一层系统的入口
        //目的：为复杂的模块或子系统提供外界访问的模块
        //优点：减少系统依赖性
        static void Main(string[] args)
        {
            ShapeMaker shapemaker = new ShapeMaker();
            shapemaker.drawCircle();
            shapemaker.drawRectangle();
            shapemaker.drawSquare();

            Console.ReadKey();
        }
    }
}
