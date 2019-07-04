using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Model
{
    /* Factory class to determine the correct strategy class object based on discount type info supplied
     * 
     */
    public class BasketDiscountFactory
    {
        public static IBasketDiscountStrategy GetDiscount(DiscountType discountType)
        {
            switch (discountType)
            {
                case DiscountType.MoneyOff:
                    return new BasketDiscountMoneyOff();
                case DiscountType.PercentageOff:
                    return new BasketDiscountPercentageOff();
                default:
                    return new NoBasketDiscount();

            }
        }
    }
}
