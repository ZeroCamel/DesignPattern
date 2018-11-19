using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptFilterPatternDemo
{
    class Program
    {
        //拦截过滤器模式
        //对比：前端控制器模式处理用户请求
        //定义：对应用程序的请求做一些预处理和后期处理，并在把请求传给实际应用程序目标处理器之前应用在请求上
        //     该处理程序可以做认证、授权、记录日志或者跟踪请求，然后把请求传给相应的处理程序
        //设计模式相关实体：
        //过滤器-在请求处理程序处理之前或之后
        //过滤器链-过滤器链有多个过滤器，并在Target上按照定义的顺序执行这些过滤器
        //target-Target是请求处理程序
        //过滤管理器-管理过滤器和过滤器链
        //客户端-Client向Target对象发送请求的对象
        static void Main(string[] args)
        {
            FilterManager filterManager = new FilterManager(new Target());
            filterManager.setFilter(new AuthenticationFilter());
            filterManager.setFilter(new DebugFilter());

            Client client = new Client();
            client.setFilterManager(filterManager);
            client.sendRequest("HOME");

            Console.Read();
        }
    }
}
