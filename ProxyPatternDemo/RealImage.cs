using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPatternDemo
{
    class RealImage : Image
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFormDisk(fileName);
        }

        public void display()
        {
            Console.WriteLine("Displaying" + fileName);
        }

        private void loadFormDisk(string fileName)
        {
            Console.WriteLine("Loading" + fileName);
        }
    }
}
