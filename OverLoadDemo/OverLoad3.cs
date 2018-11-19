using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadDemo
{
    class OverLoad3
    {
        public void Display()
        {
            DisplayOverload(200);
            DisplayOverload(200, 300);
            DisplayOverload(200, 300, 500, 600);
        }
        private void DisplayOverload(int x,int y)
        {
            Console.WriteLine("The Two integers " + x + " " + y);
        }
        private void DisplayOverload(params int[] parameterArray)
        {
            Console.WriteLine("ParameterArray");
        }
    }
}
