using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternDemo
{
    class AndCriterial : Criterial
    {
        public Criterial criterial;
        public Criterial otherCriterial;
        public AndCriterial(Criterial criterial, Criterial otherCriterial)
        {
            this.criterial = criterial;
            this.otherCriterial = otherCriterial;
        }
        public List<Person> meetCriterial(List<Person> persons)
        {
            List<Person> firstCriterialPersons = criterial.meetCriterial(persons);
            return otherCriterial.meetCriterial(firstCriterialPersons);
        }
    }
}
