using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternDemo
{
    class OctalObserver:Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            subject.Attach(this);
        }
        public override void update()
        {
            Console.WriteLine("Octal String:"+ Convert.ToString(subject.GetState(),10));
        }
    }
}
