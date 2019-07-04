using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Pattern.Model
{
    /* The ProductService class is responsible for retreieving the collection of products from the repository
     * and then applying a given discount before returning to the calling code.
     * Constructor creates dependent classes. This class is tightly coupled to the concrete implementations
     * of the repository & discount offer. Following are negative effects,-
     * Impossible to test in isolation due to the need to have a valid ChristmasProductDiscount class and
     * LinqProductRepository class.
     * If product discount strategy changes, changes need to be made to ProductService class which breaks
     * Single responsibilty principle
     * To decouple the high level module (ProductService) from the low level details (ChristmasProductDiscount &
     * LinqProductRepository) code needs to be refactored towards DIP. So, to move towards DIP, we need to 
     * ensure lower level modules are referenced by abstractions rather than concrete types.
     */
    public class ProductService
    {
        private LinqProductRepository _productRepository;
        private ChristmasProductDiscount _discountStrategy;

        public ProductService()
        {
            _productRepository = new LinqProductRepository();
            _discountStrategy = new ChristmasProductDiscount();
        }

        public IEnumerable<ProductRefactored> GetProducts()
        {
            IEnumerable<ProductRefactored> products = _productRepository.FindAll();

            foreach (ProductRefactored p in products)
                p.AdjustPriceWith(_discountStrategy);

            return products;
        }
    }
}
