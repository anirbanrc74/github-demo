using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Model
{
    //Discount strategy to apply % off on basket's total value. Implements IBasketDiscountStrategy contract.
    public class BasketDiscountPercentageOff : IBasketDiscountStrategy
    {
        public decimal GetTotalCostAfterApplyingDiscountTo(Basket basket)
        {
            return basket.TotalCost * 0.85m;
        }
    }
}
