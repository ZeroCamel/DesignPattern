using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternDemo
{
    class MaleCriterial : Criterial
    {
        public List<Person> meetCriterial(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();
            foreach (Person p in persons)
            {
                if (p.getGender().Equals("male", StringComparison.OrdinalIgnoreCase))
                {
                    malePersons.Add(p);
                }
            }
            return malePersons;
        }
    }
}
