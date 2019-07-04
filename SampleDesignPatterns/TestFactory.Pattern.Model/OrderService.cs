using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory.Pattern.Model
{
    public class OrderService
    {
        public void Dispatch(Order order)
        {
            IShippingCourier objCourier = ShippingCourierFactory.createShippingCourier(order);
            order.CourierTrackingId = objCourier.GetConsignmentLabelFor(order.DispatchAddress);
        }
    }
}
