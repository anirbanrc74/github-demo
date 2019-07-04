using System.Collections.Generic;

namespace DependencyInjection.Pattern.Model
{
    public interface IProductRepository
    {
        IEnumerable<ProductRefactored> FindAll();
    }
}