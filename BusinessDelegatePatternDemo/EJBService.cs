using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePatternDemo
{
    //实体服务类
    class EJBService:BusinessService
    {
        public void doProccessing()
        {
            Console.WriteLine("Processing task by invoking EJB service");
        }
    }
}
