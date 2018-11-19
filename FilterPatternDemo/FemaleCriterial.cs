using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternDemo
{
    class FemaleCriterial:Criterial
    {
        public List<Person> meetCriterial(List<Person> persons)
        {
            List<Person> fmalePersons = new List<Person>();
            foreach (Person p in persons)
            {
                if ( p.getGender().Equals("female",StringComparison.OrdinalIgnoreCase))
                {
                    fmalePersons.Add(p);
                }
            }
            return fmalePersons;
        }
    }
}
