using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternDemo
{
    class Program
    {
        //树形结构组合对象
        //又名：部分整体模式（组合模式）
        //思路：相似的对象当作单一的对象
        //方法：树形结构组合对象，表示部分及整体层次
        static void Main(string[] args)
        {
            Employee CEO = new Employee("John", "CEO", 30000);

            Employee headSales = new Employee("Robert", "Head Sales", 20000);

            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);

            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

            CEO.add(headSales);
            CEO.add(headMarketing);

            headSales.add(salesExecutive1);
            headSales.add(salesExecutive2);

            headMarketing.add(clerk1);
            headMarketing.add(clerk2);

            Console.WriteLine(CEO);
            foreach (Employee headEmployee in CEO.getSubordinate())
            {
                Console.WriteLine(headEmployee.ToString());
                foreach (Employee employee in headEmployee.getSubordinate())
                {
                    Console.WriteLine(employee.ToString());
                }
            }
            Console.Read();
        }
    }
}
