using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Pattern.Model
{
    /* This is a simple repository that retrieves a collection of products from an underlying data store.
     * For brevity, the FindAll implementation returns an empty collection of products to avoid creating real
     * DB & LinqToSql data context.
     * Changed Product class to ProductRefactored class to introduce abstraction
     */
    public class LinqProductRepository : IProductRepository
    {
        public IEnumerable<ProductRefactored> FindAll()
        {
            return new List<ProductRefactored>();
        }
    }
}
