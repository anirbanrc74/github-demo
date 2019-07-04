using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Pattern.Model
{
    /* This class takes an implementation of IPrice as constructor argument along with exchange rate and 
     * applies exchange rate to the base price. Constructor argument could be any implementation of IPrice.
     */
    public class CurrencyPriceDecorator : IPrice
    {
        private IPrice _basePrice;
        private decimal _exchangeRate;

        public CurrencyPriceDecorator(IPrice price, decimal exchangeRate)
        {
            _basePrice = price;
            _exchangeRate = exchangeRate;
        }

        public decimal Cost
        {
            get { return _basePrice.Cost * _exchangeRate; }
            set { _basePrice.Cost = value; }
        }
    }
}
