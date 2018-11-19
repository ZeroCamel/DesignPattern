using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace FilterPatternDemo
{
    class Program
    {
        //类型：结构型
        //目的：基于不同的标准过滤对象
        static void Main(string[] args)
        {
            //初始化对象
            List<Person> persons = new List<Person>();
            persons.Add(new Person("a", "male", "single"));
            persons.Add(new Person("b", "female", "married"));
            persons.Add(new Person("c", "male", "single"));
            persons.Add(new Person("d", "female", "married"));
            persons.Add(new Person("e", "male", "single"));
            persons.Add(new Person("f", "single", "single"));
            persons.Add(new Person("g", "male", "married"));
            persons.Add(new Person("h", "female", "single"));
            persons.Add(new Person("i", "male", "single"));

            //实例化对象标准
            Criterial male = new MaleCriterial();
            Criterial female = new FemaleCriterial();
            Criterial single = new SingleCriterial();
            Criterial singleMale = new AndCriterial(single, male);
            Criterial singleOrFemale = new OrCrterial(single, female);

            List<Person> p = singleMale.meetCriterial(persons);
            foreach (var item in p)
            {
                Console.WriteLine("Person : [ Name : " + item.getName()
            + ", Gender : " + item.getGender()
            + ", Marital Status : " + item.getMStatus()
            + " ]");
            }

            Console.Read();
        }
    }
}
