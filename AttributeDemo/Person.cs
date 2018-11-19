using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [Help("Base")]
    [Help("BaseClass")]
    public class Person
    {
        [Help("BaseString")]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
