using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptFilterPatternDemo
{
    //创建过滤器链
    public class FilterChain
    {
        private List<Filter> filters = new List<Filter>();
        private Target target;

        public void addFilter(Filter filter)
        {
            filters.Add(filter);
        }

        public void execute(string request)
        {
            foreach (Filter filter in filters)
            {
                filter.execute(request);
            }
            target.execute(request);
        }

        public void setTarget(Target target)
        {
            this.target = target;
        }
    }
}
