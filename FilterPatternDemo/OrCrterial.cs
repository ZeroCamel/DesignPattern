using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternDemo
{
    class OrCrterial : Criterial
    {
        public Criterial criterial;
        public Criterial otherCriterial;
        public OrCrterial(Criterial criterial, Criterial otherCriterial)
        {
            this.criterial = criterial;
            this.otherCriterial = otherCriterial;
        }
        public List<Person> meetCriterial(List<Person> persons)
        {
            List<Person> firstCriterialItem = criterial.meetCriterial(persons);
            List<Person> otherCriterialItem = otherCriterial.meetCriterial(persons);

            foreach (var item in persons)
            {
                if (!firstCriterialItem.Contains(item))
                {
                    firstCriterialItem.Add(item);
                }
            }
            return firstCriterialItem;
        }
    }
}
