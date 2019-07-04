using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pattern.Model
{
    public interface IBasketDiscountStrategy
    {
        decimal GetTotalCostAfterApplyingDiscountTo(Basket basket);
    }
}
