using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property,AllowMultiple =true,Inherited =true)]
    public class HelpAttribute : Attribute
    {
        public string message;

        protected string Message
        {
            get
            {
                return message;
            }
        }

        public HelpAttribute(string message)
        {
            this.message = message;
        }
    }
}
