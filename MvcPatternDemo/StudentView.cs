using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPatternDemo
{
    class StudentView
    {
        public void printStudentDetails(string studentName, string studentRollNum)
        {
            Console.WriteLine("Student:");
            Console.WriteLine("Name:" + studentName);
            Console.WriteLine("RollNum:" + studentRollNum);
        }
    }
}
