using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternDemo
{
    class SingleCriterial:Criterial
    {
        public List<Person> meetCriterial(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();
            foreach (Person p in persons)
            {
                if (p.getMStatus().Equals("single", StringComparison.OrdinalIgnoreCase))
                {
                    singlePersons.Add(p);
                }
            }
            return singlePersons;
        }
    }
}
