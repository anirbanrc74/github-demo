using System;

namespace State.Pattern.Model
{
    public class OrderShippedState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }
        public void Ship(Order order)
        {
            throw new NotImplementedException("Cannot ship a shipped order");
        }
        public bool CanCancel(Order order)
        {
            return false;
        }
        public void Cancel(Order order)
        {
            throw new NotImplementedException("Cannot cancel a shipped order!");
        }

        public OrderStatus Status
        {
            get { return OrderStatus.Shipped; }
        }
    }
}