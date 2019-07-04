using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Pattern.Model
{
    /* Canceled Order State - When an order is canceled, it cannot be shipped.
     * 
     */
    public class OrderCanceledState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }
        public void Ship(Order order)
        {
            throw new NotImplementedException("You cannot ship a canceled order");
        }
        public bool CanCancel(Order order)
        {
            return false;
        }
        public void Cancel(Order order)
        {
            throw new NotImplementedException("This order is already cancelled");
        }

        public OrderStatus Status
        {
            get { return OrderStatus.Canceled; }
        }
    }
}
