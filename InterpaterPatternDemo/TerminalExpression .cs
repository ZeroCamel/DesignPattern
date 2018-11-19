using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpaterPatternDemo
{
    //创建实现上述接口的实体类
    class TerminalExpression:Expression
    {
        private string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }
        public bool interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            return false;
        }
    }
}
