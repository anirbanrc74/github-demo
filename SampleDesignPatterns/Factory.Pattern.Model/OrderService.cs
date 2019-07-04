using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pattern.Model
{
    public class OrderService
    {
        /* 
         * Factory class is solely responsible for creating valid courier object based on business logic.
         * Abstracting away object creation business logic to Factory class.
         * Changes centarlized in factory class for new logic & new couriers. No impact to other classes.
         * Order Service need not know how courier objects are created
         * Codes to interface
         */
        public void Dispatch(Order order)
        {
            IShippingCourier shippingCourier = UKShippingCourierFactory.CreateShippingCourier(order);
            order.CourierTrackingId = shippingCourier.GenerateConsignmentLabelFor(order.DispatchAddress);
        }
    }
}
