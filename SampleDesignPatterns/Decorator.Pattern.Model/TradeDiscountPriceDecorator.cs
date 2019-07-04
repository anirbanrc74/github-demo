using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Model
{
    /* Class that decorates the default price behavior with the logic that applies trade discount. This class
     * wraps an implementation of the IPrice interface, supplied via the constuctor and reduce the cost by a
     * factor of 5%. Product class/client is referencing a price via an interface and will be unaware that they
     * are talking to TradeDiscountPriceDecorator class.
     */
    public class TradeDiscountPriceDecorator : IPrice
    {
        private IPrice _basePrice;

        public TradeDiscountPriceDecorator(IPrice price)
        {
            _basePrice = price;
        }

        public decimal Cost
        {
            get { return _basePrice.Cost * 0.95m; }
            set { _basePrice.Cost = value; }
        }
    }
}
