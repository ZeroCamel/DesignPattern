using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePatternDemo
{
    //业务查询服务
    //类似与工厂-动态的创建类的实例
    class BusinessLookUp
    {
        public BusinessService getBusinessService(string serviceType)
        {
            if (string.Equals("EJB",serviceType,StringComparison.OrdinalIgnoreCase))
            {
                return new EJBService();
            }
            else
            {
                return new JMSServicecs();
            }
        }
    }
}
