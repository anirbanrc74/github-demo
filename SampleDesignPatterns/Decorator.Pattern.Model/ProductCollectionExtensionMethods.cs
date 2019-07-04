using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Model
{
    /*Applying decorating behavior to the Product class via set of extension methods. 
     * Extension methods are used so that code in product service class is kept to minimum.
     * Product service class is responsible only for coordination of a task and not the underlying logic of
     * applying decorating classes.
     */
    public static class ProductCollectionExtensionMethods
    {
        public static void ApplyCurrencyMultiplier(this IEnumerable<Product> products)
        {
            foreach (Product p in products)
                p.Price = new CurrencyPriceDecorator(p.Price, 0.78m);
        }

        public static void ApplyTradeDiscount(this IEnumerable<Product> products)
        {
            foreach (Product p in products)
                p.Price = new TradeDiscountPriceDecorator(p.Price);
        }
    }
}
