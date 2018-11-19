using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocatorPattern
{
    //创建缓存
    public class Cache
    {
        private List<Service> services;

        public Cache()
        {
            services = new List<Service>();
        }

        public Service getService(string serviceName)
        {
            foreach (Service service in services)
            {
                if (string.Equals(service.getName(), serviceName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Running cached" + serviceName + "object");
                    return service;
                }
            }
            return null;
        }
        public void addService(Service newService)
        {
            bool exits = false;
            foreach (Service service in services)
            {
                if (string.Equals(service.getName(), newService.getName(), StringComparison.OrdinalIgnoreCase))
                {
                    exits = true;
                }
            }
            if (!exits)
            {
                services.Add(newService);
            }
        }
    }
}
