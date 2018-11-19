using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptFilterPatternDemo
{
    //过滤器接口
    public interface Filter
    {
        void execute(string request);
    }
}
