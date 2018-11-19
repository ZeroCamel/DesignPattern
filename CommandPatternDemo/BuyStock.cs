using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class BuyStock:Order
    {
        private Stock abcStock;
        public BuyStock(Stock addStock)
        {
            this.abcStock = addStock;
        }
        public void execute()
        {
            abcStock.buy();
        }
    }
}
