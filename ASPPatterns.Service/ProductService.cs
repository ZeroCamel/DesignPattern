using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;

namespace ASPPatterns.Service
{
    //遵循单一职责原则-协调缓存或资源库中检索数据
    class ProductService
    {

        //private ProductRepository _productRepository;
        //1、提取接口-依赖倒转原则
        private IProductRepository _productRepository;

        //3、重构
        private IcacheStorage _cacheStorage;

        //public ProductService()
        //{
        //    _productRepository = new ProductRepository();
        //}
        //依赖注入原则
        //依赖注入有三种形式：构造器、方法和属性
        //1、构造注入 2、set注入 3、接口注入

        //2、构造器注入
        //public ProductService(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}

        public ProductService(IProductRepository productRepository,IcacheStorage cacheStorage)
        {
            _productRepository = productRepository;
            _cacheStorage = cacheStorage;
        }
        public IList<Product> GetAllProductsIn(int categoryId)
        {
            IList<Product> products;

            string storageKey = string.Format("products_in_category_id_{0}", categoryId);

            //products = (List<Product>)HttpContext.Current.Cache.Get(storageKey);
            //3、重构
            products = _cacheStorage.Retrieve<List<Product>>(storageKey);

            if (products==null)
            {
                products = _productRepository.GetAllProductsIn(categoryId);
                //HttpContext.Current.Cache.Insert(storageKey, products);
                //3、重构
                _cacheStorage.Store(storageKey, products);
            }
            return products;
        }
    }
}
