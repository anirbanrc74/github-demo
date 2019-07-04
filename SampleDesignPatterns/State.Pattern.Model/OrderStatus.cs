namespace State.Pattern.Model
{
    //This Enum will be used to identify which state an order is in.
    public enum OrderStatus
    {
        New = 0,
        Shipped = 1,
        Canceled = 2
    }
}