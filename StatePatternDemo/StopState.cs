using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    //隐式接口实现，类和接口都可访问接口中方法。显式接口实现，只能通过接口访问。
    class StopState:State
    {
        //隐式接口实现
        public void doAction(Context context)
        {
            Console.WriteLine("Player is in stop state!");
            context.setState(this);
        }

        //显示接口实现
        //void State.doAction(Context context)
        //{
        //    throw new NotImplementedException();
        //}

        public override String ToString()
        {
            return "Start State";
        }
    }
}
