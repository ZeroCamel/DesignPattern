using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternDemo
{
    class Program
    {
        //原型-一次设计、多次使用
        //意图：创建重复对象
        //优点：1、创建对象的最佳方式-克隆、动态加载
        //      java-继承Clonable-clone
        //      c#->Object 类的 MemberwiseClone() - 浅克隆（序列化深克隆）
        //      2、性能提高、逃避构造函数的约束
        //场景：资源优化/类初始化需要消耗非常多的数据、硬件资源，很少单独出现、一般和工厂模式一起出现
        //应用实例：细胞分裂
        static void Main(string[] args)
        {
            ShapeCache.loadCache();

            Shape shapeClone = ShapeCache.getShape("1");
            Console.WriteLine("shape:" + shapeClone.getType());

            Shape shapeClone1 = ShapeCache.getShape("2");
            Console.WriteLine("shape:" + shapeClone1.getType());
            Console.Read();
        }
    }
}
