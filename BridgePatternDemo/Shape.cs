using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternDemo
{
    public abstract class Shape
    {
        protected DrawAPI drawApi;
        protected Shape(DrawAPI drawApi)
        {
            this.drawApi = drawApi;
        }
        public abstract void draw();
    }
}
