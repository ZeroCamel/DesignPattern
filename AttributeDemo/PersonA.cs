using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [Help("SubClass")]
    public class PersonA : Person
    {
        public string studentID { get; set; }
    }
}
