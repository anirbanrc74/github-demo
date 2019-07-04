using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory.Pattern.Model
{
    public static class ShippingCourierFactory
    {
        public static IShippingCourier createShippingCourier(Order order)
        {
            if (order.TotalCost > 100 || order.WeightInKg > 5)
                return new DHL();
            else
                return new RoyalMail();
        }
    }
}
