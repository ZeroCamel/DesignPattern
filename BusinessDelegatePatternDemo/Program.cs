using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePatternDemo
{
    /// <summary>
    /// 业务代表模式
    /// 意图：表示层和业务层解耦，减少通信对表示层代码中的业务层代码的查询功能
    /// 业务层包含的实体
    /// 1、客户端:表示层可以是JSP、serverlet、或UI java代码
    /// 2、业务代表：一个为客户端实体提供的入口类，提供了对业务服务方法的访问
    /// 3、查询服务：查找服务对象获取相应的业务实现，并提供业务对象对业务代表对象的访问
    /// 4、业务服务：业务服务接口实现了该业务服务的实体类，提供了实际的业务实现逻辑
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BusinessDelegate businessDelegate = new BusinessDelegate();
            businessDelegate.setServiceType("EJB");

            Client client = new Client(businessDelegate);
            client.doTask();

            businessDelegate.setServiceType("JMS");
            client.doTask();

            Console.Read();
        }
    }
}
