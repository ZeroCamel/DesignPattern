using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternDemo
{
    public interface Criterial
    {
        List<Person> meetCriterial(List<Person> persons);
    }
}
