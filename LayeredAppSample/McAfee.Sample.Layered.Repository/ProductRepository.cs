using McAfee.Sample.Layered.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McAfee.Sample.Layered.Repository
{
    public class ProductRepository : IProductRepository
    {
        //Querying Linq to SQL for all products to create a list of product business entities from data to return
        public IList<Model.Product> FindAll()
        {
            var products = from p in new ShopDataContext().Products
                           select new Model.Product
                           {
                               Id = p.ProductId,
                               Name = p.ProductName,
                               Price = new Model.Price(p.RRP, p.SellingPrice)
                           };

            return products.ToList();
        }

    }
}
