using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePatternDemo
{
    //创建客户端
    class Client
    {
        //依赖注入
        BusinessDelegate businessService;

        //构造函数初始化
        public Client(BusinessDelegate businessService)
        {
            this.businessService = businessService;
        }
        public void doTask()
        {
            businessService.doTask();
        }
    }
}
