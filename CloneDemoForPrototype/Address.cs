using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneDemoForPrototype
{
    [Serializable]
    public class Address
    {
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _province;
        public string province
        {
            get { return _province; }
            set { _province = value; }
        }
    }
}
