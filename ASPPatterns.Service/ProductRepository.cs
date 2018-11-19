using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPPatterns.Service
{
    class ProductRepository : IProductRepository
    {
        public IList<Product> GetAllProductsIn(int categoryId)
        {
            //IList与List的区别：IList 是ICollection 泛型接口的子代，并且是所有泛型列表的基接口
            IList<Product> products = new List<Product>();

            //DataBase Operation to populate products;

            return products;
        }
    }
}
