using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CloneDemoForPrototype
{
    [Serializable]
    public class Person
    {
        public string _name;
        public string _age;
        public Address _address = new Address();

        public Person() { }

        //法一：克隆方便、但需要把类标记为可序列化
        public Person Clone()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, SeekOrigin.Begin);
            return (Person)bf.Deserialize(ms);
        }

        //法二：可以克隆任意对象、费时费力、易出错
        public Person Clone1()
        {
            Person temp = new Person();
            temp._name = "a";
            temp._age = "12";
            temp._address.province = "jiangsu";
            temp._address.City = "suzhou";
            return temp;
        }
    }
}
