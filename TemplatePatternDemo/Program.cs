using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo
{
    class Program
    {
        //模板设计模式
        //定义：一个抽象类公开定义了执行它的方法的方式/模板，子类可以按需要重写方法实现
        //意图：定义一个操作中算法的骨架，将步骤延迟到子类中。
        //何时使用：有一些通用的方法
        //如何解决：将通用算法抽象出来
        //应用实例：西游记81难，顶层逻辑框架
        //优点：1、封装不变，扩展可变；2、提取公共代码，便于维护；3、行为由父类控制，子类实现
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();
            Console.WriteLine();

            Game game1 = new Football();
            game.Play();

            Console.Read();
        }
    }
}
