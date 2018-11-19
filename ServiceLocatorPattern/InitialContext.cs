using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    //创建初始上下文
    //类似简单工厂动态的服务实例
    public class InitialContext
    {
        public object lookup(string jndiName)
        {
            if (string.Equals(jndiName, "Service1", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new service1 object!");
                return new Service1();
            }
            else if (string.Equals(jndiName, "Service2", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Looking up and creating a new service2 obhect!");
                return new Service2();
            }
            return null;
        }
    }
}
