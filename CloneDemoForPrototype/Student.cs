using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneDemoForPrototype
{
    class Student : IDeepCopy, IShallowCopy
    {
        public string Name;
        public int Age;

        public ClassRoom Room = new ClassRoom();

        //公开无参构造函数（不加修饰符 默认私有）
        public Student()
        {

        }

        //含参构造函数
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public object DeepCopy()
        {
            Student s = new Student();
            s.Name = this.Name;
            s.Age = this.Age;
            s.Room = (ClassRoom)this.Room.DeepCopy();
            return s;
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Name:" + Name + "\tAge:" + Age + "\tRoom:" + Room.ToString();
        }
    }
}
