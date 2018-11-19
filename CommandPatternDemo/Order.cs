using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    //创建命令接口
    public interface Order
    {
        void execute();
    }
}
