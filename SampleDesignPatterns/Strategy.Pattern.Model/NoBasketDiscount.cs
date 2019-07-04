using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Model
{
    //Discount strategy when no discounts are set.
    public class NoBasketDiscount : IBasketDiscountStrategy
    {
        public decimal GetTotalCostAfterApplyingDiscountTo(Basket basket)
        {
            return basket.TotalCost;
        }
    }
}
