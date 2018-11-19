using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    /// <summary>
    /// 服务定位器模式
    /// 定义：
    /// 充分利用了缓冲技术，在首次请求某个服务时，服务定位器在JNDI中查找服务，并缓存该服务对象。
    /// 当再次请求相同的服务时，服务定位器会在他的缓冲池中查找，这样可以很大程度上提高应用程序的性能
    /// 
    /// 相关实体：
    /// 服务Service-实际处理请求的服务
    /// Context/初始的Context-JNDI CONTEXT带有对要查找的服务的引用
    /// 服务定位器(Service Locator)-通过JNDI查找和缓存服务来获取服务的单点接触
    /// 缓存（Cache）-缓存服务的引用，以便复用
    /// 客户端（Client）-Client是通过ServiceLocator调用服务的对象
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Service service = ServiceLocator.getService("Service1");
            service.execute();

            service = ServiceLocator.getService("Service2");
            service.execute();
            service = ServiceLocator.getService("Service1");
            service.execute();
            service = ServiceLocator.getService("Service2");
            service.execute();

            Console.Read();
        }
    }
}
