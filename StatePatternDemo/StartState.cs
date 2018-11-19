using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    class StartState:State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Player is a start state");
            context.setState(this);
        }
        public override String ToString()
        {
            return "Start State";
        }
    }
}
