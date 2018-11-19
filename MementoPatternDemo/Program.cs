using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternDemo
{
    class Program
    {
        //备忘录模式
        //意图：保存对象的某个状态，以便在适当的时候恢复对象
        //优点：允许用户取消不确定或者错误的操作，能够恢复原先的状态-后悔药；
        //      提供了状态恢复机制
        //设计原则：迪米特原则
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.setState("State #1");
            originator.setState("State #2");

            careTaker.add(originator.saveStateToMemento());

            originator.setState("State #3");
            careTaker.add(originator.saveStateToMemento());

            originator.setState("State #4");
            Console.WriteLine("Current State:"+originator.getState());

            originator.getStateFromMemento(careTaker.get(0));
            Console.WriteLine("First State:" + originator.getState());

            originator.getStateFromMemento(careTaker.get(1));
            Console.WriteLine("Second saved State:" + originator.getState());

            Console.Read();
        }
    }
}
