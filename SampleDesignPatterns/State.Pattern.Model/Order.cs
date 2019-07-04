using System;

namespace State.Pattern.Model
{
    /* The State Pattern belongs to the behavioral group of design patterns and is used to represent the state
     * of an object seperate from all other behavior. State pattern allows an object to alter its behavior
     * when its internal state changes. This is achieved by swapping internal state objects that implement
     * state dependent behavior. An object defers all state based behavior to a dependent state subclass, this
     * alleviates the need for mass of case statements.
     * Order is the object that has state, whch is represented by an instance of the State interface. Client
     * code interacts against this single interface.
     * IOrderState is the interface that defines the behavior dependent on the state of the Order.
     * Order New/Canceled/Shipped States represent specific states in the lifetime of the Order. These classes
     * implement behavior specific to these states.
     * All state dependent behavior has been moved into seperate sub-classes. This way new states are easier to 
     * introduce. No need to determine the state of the object via if-else before implementing behavior.
     * This pattern is beneficial to use when the object changes behavior depending on its state.
     */
    public class Order
    {
        private IOrderState _orderState;

        public Order(IOrderState baseState)
        {
            _orderState = baseState;
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderedDate { get; set; }
        public OrderStatus Status()
        {
            return _orderState.Status;
        }

        public bool CanCancel()
        {
            return _orderState.CanCancel(this);
        }
        public void Cancel()
        {
            if (CanCancel())
                _orderState.Cancel(this);
        }
        public bool CanShip()
        {
            return _orderState.CanShip(this);
        }
        public void Ship()
        {
            if (CanShip())
                _orderState.Ship(this);
        }
        internal void Change(IOrderState orderState)
        {
            _orderState = orderState;
        }

    }
}