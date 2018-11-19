using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservePatternDemo
{
    class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override void update()
        {
            int strState = subject.GetState();
            Console.WriteLine("Hexa string:" + Convert.ToString(strState, 16));

        }
    }
}
