using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class SellStock:Order
    {
        private Stock abcStock;
        public SellStock(Stock sellStock)
        {
            this.abcStock = sellStock;
        }
        public void execute()
        {
            abcStock.sell();
        }
    }
}
