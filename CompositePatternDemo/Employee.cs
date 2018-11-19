using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace CompositePatternDemo
{
    public class Employee
    {
        private string name;
        private string dept;
        private int salay;

        private ArrayList subordinates;

        public Employee(string name, string dept, int salay)
        {
            this.name = name;
            this.dept = dept;
            this.salay = salay;

            subordinates = new ArrayList();
        }

        public void add(Employee e)
        {
            subordinates.Add(e);
        }

        public void remove(Employee e)
        {
            subordinates.Remove(e);
        }

        public ArrayList getSubordinate()
        {
            return subordinates;
        }

        public override string  ToString()
        {
            return ("Employee :[ Name : " + name + ", dept : " + dept + ", salary :" + salay + " ]");
        }
    }
}
