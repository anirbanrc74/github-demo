using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Model
{
    public interface IProductRepository
    {
        IEnumerable<Product> FindAll();
    }
}
