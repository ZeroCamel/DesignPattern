using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptFilterPatternDemo
{
    //创建过滤器管理
    public class FilterManager
    {
        FilterChain filterChain;

        public FilterManager(Target target)
        {
            filterChain = new FilterChain();
            filterChain.setTarget(target);
        }

        public void setFilter(Filter filter)
        {
            filterChain.addFilter(filter);
        }
        public void filterRequest(string request)
        {
            filterChain.execute(request);
        }
    }
}
