using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternDemo
{
    class ProxyImage:Image
    {
        //NOTE:依赖注入-进化——>控制反转
        private RealImage realImage;

        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }
        public void display()
        {
            if (realImage==null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.display();
        }
    }
}
