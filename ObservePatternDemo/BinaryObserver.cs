using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternDemo
{
    class BinaryObserver:Observer
    {
        //类发生改变-构造函数初始化的时候
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override void update()
        {
            Console.WriteLine("Binary String:"+ Convert.ToString(subject.GetState(),2));
        }
    }
}
