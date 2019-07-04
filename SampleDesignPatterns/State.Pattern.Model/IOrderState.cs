using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Pattern.Model
{
    public interface IOrderState
    {
        bool CanShip(Order order);
        void Ship(Order order);

        bool CanCancel(Order order);
        void Cancel(Order order);

        OrderStatus Status { get; }
    }
}
