using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPatternDemo
{
    class Program
    {
        //享元模式
        //目的：减少创建对象的数量来减少内存占用量、提高系统性能
        //使用场景：系统有大量相似对象、需要缓冲池的场景
        //应用实例：JAVA中的值有则返回 无则创建一个字符串保存在字符串里；数据库的数据池

        //与原型模式的区别
        //缓冲池中是否有对象，对象是否动态添加

        //static final const  java-final
        private static string[] colors = { "red", "green", "blue", "white", "black" };
        static void Main(string[] args)
        {
            //通过颜色获取类的实例

            //Console.WriteLine(getRandomColor());
            //Console.Read();

            //5种颜色画20类圆
            for (int i = 0; i < 20; i++)
            {
                Circle circle = (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.SetX(getRandomX());
                circle.SetY(getRandomY());
                circle.SetRadius(100);
                circle.Draw();

            }
            Console.Read();

        }

        private static string getRandomColor()
        {
            //随机数示例
            //Random rad = new Random();
            //double Num = rad.Next(1, 10001) / 100;
            //if (Num <= 80)
            //{
            //    return "yes";
            //}
            //return "no";

            //计算机只能产生伪随机数而不能产生绝对随机的随机数
   

            //随机数实例
            //时间短重复
            //Random ranDom = new Random();
            //return (colors)[ranDom.Next(0, 5)];

            //随机数实例2
            //种子-时钟数种子
            //Random random = new Random((int)DateTime.Now.Ticks);
            //return (colors)[random.Next(0, 5)];

            //随机数也可用线程实现 thread.sleep(1000);

            //随机数实例3
            //种子-GUID
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return (colors)[random.Next(0, 5)];
        }

        private static int getRandomX()
        {
            //使用指定的种子初始化类的实例
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(1, 11);
        }

        private static int getRandomY()
        {
            //使用指定的种子初始化类的实例
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(1, 11);
        }
    }
}
