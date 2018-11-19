using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunPolyDemo
{
    class Student : Person
    {
        public override void Eat()
        {
            Console.WriteLine("Student is Eating");
        }
    }
}
