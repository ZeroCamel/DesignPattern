using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemo
{
    class Program
    {
        //创建对象不会对客户端暴露创建逻辑
        //主要解决：接口选择的问题
        static void Main(string[] args)
        {
            //ShapeFactory shadeFactory = new ShapeFactory();

            ////TODO:获取Circle的对象，并调用它的draw方法
            //Shape strShape = shadeFactory.getShapType("circle");
            //strShape.Draw();
            //Console.Read();
            Console.WriteLine(DateTime.Now.AddHours(24));

            //Console.WriteLine(ScriptEngine.Eval("javascript","1+2/3"));
            Console.Read();
        }
    }
}
