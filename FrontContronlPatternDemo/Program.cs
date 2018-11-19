using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontContronlPatternDemo
{
    class Program
    {
        /// <summary>
        /// 前端控制器
        /// 目的：用来处理一个集中的请求处理机制，所有的请求都有一个单一的处理程序处理
        ///       该处理程序可以做认证、授权、记录日志或者跟踪请求，然后把请求传给相应的处理程序
        /// 相关实体：
        /// 前端控制器-front contronl-处理应用程序所有请求的单个处理程序，可以是基于Web的可以是基于桌面的
        /// 调度器(任务分发)-Dispatcher-前端控制器使用一个调度器对象来调度请求到相应的具体处理程序
        /// 视图-View-为请求而创建的视图
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FrontContronl frontContronl = new FrontContronl();
            frontContronl.DispatcherRequest("student");
            frontContronl.DispatcherRequest("home");

            Console.Read();
        }
    }
}
