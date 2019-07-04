using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Pattern.Model
{
    /* ProductService class updated to ProductServiceRefactored class to refactor to code against interfaces
     * Now high level service class is referencing all the dependents or lower level classes by interfaces.
     * Next DI introduction is Constructor injection. Instead of leaving responsibility of obtaining an instance
     * of IProductRepository, we can move this up as a parameter in the constructor.
     * 2'nd DI injection will be refactoring to is known as Method Injection. Currently to alter discount 
     * strategy we need to change ProductServiceRefactored class. Obtaining correct discount should be of no 
     * concern to the ProductServiceRefactored class. To achieve this, we need to move the instantiation of the
     * discount offer out of the service constructor and onto the parameter list of the GetProductsAndApplyDiscount
     * method.
     */
    public class ProductServiceRefactored
    {
        private IProductRepository _productRepository;
        //private IProductDiscountStrategy _discountStrategy;

        public ProductServiceRefactored(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            //_discountStrategy = new ChristmasProductDiscount();
        }

        public IEnumerable<ProductRefactored> GetProductsAndApplyDiscount(IProductDiscountStrategy discount)
        {
            IEnumerable<ProductRefactored> products = _productRepository.FindAll();

            foreach (ProductRefactored p in products)
                p.AdjustPriceWith(discount);

            return products;
        }
    }
}
