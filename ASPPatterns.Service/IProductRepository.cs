using System;
using System.Collections.Generic;
namespace ASPPatterns.Service
{
    interface IProductRepository
    {
        IList<Product> GetAllProductsIn(int categoryId);
    }
}
