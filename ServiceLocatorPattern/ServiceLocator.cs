using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    //创建服务定位器
    public class ServiceLocator
    {
        private static Cache cache;

        static ServiceLocator()
        {
            cache = new Cache();
        }

        public static Service getService(string jndiName)
        {
            Service service = cache.getService(jndiName);

            if (service != null)
            {
                return service;
            }

            InitialContext context = new InitialContext();
            Service service1 = (Service)context.lookup(jndiName);
            cache.addService(service1);
            return service1;
        }
    }
}
