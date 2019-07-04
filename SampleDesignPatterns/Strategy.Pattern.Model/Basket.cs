using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Model
{
    /* Basket is completely unaware of the underlying algorithm that will be used to determine the total price,
     * due to the discount strategy being injected to it and referred using interface.
     * Basket defers all calculations to a concrete strategy referenced by abstract class or interface (IBasketDiscountStrategy)
     * Basket also exposes method or property so that the strategy implementation can be changed.
     * IBasketDiscountStrategy is an interface with single method for the algorithm in this case.
     * BasketDiscountMoneyOff, BasketDiscountPercentageOff & NoBasketDiscount are implementations of
     * IBasketDiscountStrategy interface (Strategy).
     */
    public class Basket
    {
        private IBasketDiscountStrategy _basketDiscount;

        public Basket(DiscountType discountType)
        {
            _basketDiscount = BasketDiscountFactory.GetDiscount(discountType);
        }
        public decimal TotalCost { get; set; }

        public decimal GetTotalCostAfterDiscount()
        {
            return _basketDiscount.GetTotalCostAfterApplyingDiscountTo(this);
        }
    }
}
