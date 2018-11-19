using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePatternDemo
{
    //创建业务代表
    //承载客户端请求并做相应的处理
    class BusinessDelegate
    {
        private BusinessLookUp lookupService = new BusinessLookUp();
        private BusinessService businessService;
        private string serviceType;

        public void setServiceType(string serviceType)
        {
            this.serviceType = serviceType;
        }

        public void doTask()
        {
            businessService = lookupService.getBusinessService(serviceType);
            businessService.doProccessing();
        }
    }
}
