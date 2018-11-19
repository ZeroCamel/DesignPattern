using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontContronlPatternDemo
{
    //创建一个调度器
    //工厂模型-动态创建类的实例
    class DisPatcher
    {
        private HomeView homeView;
        private StudentView studentView;

        public DisPatcher()
        {
            homeView = new HomeView();
            studentView = new StudentView();
        }

        public void ViewDisPatcher(string request)
        {
            if (string.Equals(request,"STUDENT",StringComparison.OrdinalIgnoreCase))
            {
                studentView.show();
            }
            else
            {
                homeView.show();
            }
        }
    }
}
