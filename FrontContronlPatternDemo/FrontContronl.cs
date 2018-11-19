using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontContronlPatternDemo
{
    class FrontContronl
    {
        private DisPatcher dispatcher;
        public FrontContronl()
        {
            dispatcher = new DisPatcher();
        }

        private Boolean IsAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully!");
            return true;
        }

        private void TrackRequest(string request)
        {
            Console.WriteLine("Page Requested:" + request);
        }

        public void DispatcherRequest(string request)
        {
            //记录每一个请求
            TrackRequest(request);
            if (IsAuthenticUser())
            {
                dispatcher.ViewDisPatcher(request);
            }
        }
    }
}
