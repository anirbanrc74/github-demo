using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Pattern.Model
{
    public class OrderNewState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return true;
        }
        public void Ship(Order order)
        {
            order.Change(new OrderShippedState());
        }

        public bool CanCancel(Order order)
        {
            return true;
        }
        public void Cancel(Order order)
        {
            order.Change(new OrderCanceledState());
        }
        public OrderStatus Status
        {
            get { return OrderStatus.New; }
        }
    }
}
