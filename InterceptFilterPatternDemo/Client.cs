using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptFilterPatternDemo
{
    //创建客户端
    public class Client
    {
        FilterManager filterManager;

        public void setFilterManager(FilterManager filterManager)
        {
            this.filterManager = filterManager;
        }

        public void sendRequest(string request)
        {
            filterManager.filterRequest(request);
        }
    }
}
