using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternDemo
{
    /// <summary>
    /// context类：随着状态的改变而改变
    /// 具体环境类
    /// </summary>
    class Context
    {

        private State state;

        //Prop Tab 两次按

        //依赖注入-构造函数
        public Context()
        {
            state = null;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public State getState()
        {
            return state;
        }
    }
}
