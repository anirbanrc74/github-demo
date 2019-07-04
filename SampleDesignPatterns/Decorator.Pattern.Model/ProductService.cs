using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Model
{
    /* ProductService class coordinates the retrieval and application of trade discount & currency multiplication
     * Decorator pattern belongs to structural patterns group and allows new behavior to be added to an
     * existing object on the fly.
     * Decorator pattern is useful when extra functionality needs to be added to existing classes.
     * Decorator pattern enables new behavior to be added to an object dynamically via composition. The pattern
     * enables this by either inheriting from base class or implementing a shared interface in conjuction with
     * injecting an instance of the class to be decorated i.e. Decorator pattern wraps an existing class with a 
     * class that extends the behavior or state. Multiple decorators can be added to a class to combine extended
     * behavior.
     */
    public class ProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> products = _productRepository.FindAll();

            products.ApplyTradeDiscount();

            products.ApplyCurrencyMultiplier();

            return products;
        }
    }
}
