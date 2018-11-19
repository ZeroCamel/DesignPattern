using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpaterPatternDemo
{
    //一个表达式接口
    interface Expression
    {
        Boolean interpret(string context);
    }
}
