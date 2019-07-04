using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McAfee.Sample.Layered.Model
{
    /*
     * Repository pattern - model cannot be concerned with the specifics of data store & query languages.
     * Repository pattern acts as an in memory collection or repository for business entities, abstracting underlying data infrastructure
     * */
    public interface IProductRepository
    {
        IList<Product> FindAll();
    }
}
