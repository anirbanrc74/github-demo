using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Pattern.Model
{
    /* This class represents a product in catalog & contains single method without code which demonstrates the
     * interaction between a Product & ChristmasProductDiscount.
     */
    public class Product
    {
        public void AdjustPriceWith(ChristmasProductDiscount discount)
        {

        }
    }
}
