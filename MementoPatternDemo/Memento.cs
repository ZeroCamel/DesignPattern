using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPatternDemo
{
    class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string getState()
        {
            return state;
        }
    }
}
