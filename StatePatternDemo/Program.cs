using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class Program
    {
        //状态模型
        //定义：与观察者模型的区别，允许对象在内部状态发生时改变它的行为
        //意图：由内而外激发类的行为,类的行为是基于它的状态而改变的
        //提示：内外类通信-行为型模式
        //应用实例：曾侯乙编钟，钟是抽象接口，钟A是具体具体状态，’曾侯乙编钟'是具体环境
        //优点：1、封装了转换规则；2、枚举可能存在的状态，在枚举状态之前可能需要确定状态种类；3、方便增加新的状态，       只需要改变对象状态即可改变对象的行为；4、允许状态转换逻辑和状态转换对象合成一体，而不是一个巨大的条      件语句块；5、可以让多个环境对象共享一个状态对象，从而减少系统中对象的个数
        //缺点：状态模式的使用必然会增加系统类和对象的个数
        //注意事项：当类的行为受到约束的时候使用，而且状态不超过5个
        static void Main(string[] args)
        {
            //外部类
            Context contex = new Context();

            //内部状态类
            StartState startState=new StartState();

            //内部行为
            startState.doAction(contex);

            //由内而外激发输出
            Console.WriteLine(contex.getState().ToString());

            StopState stopState = new StopState();
            stopState.doAction(contex);

            Console.WriteLine(contex.getState().ToString());

            Console.Read();
        }
    }
}
