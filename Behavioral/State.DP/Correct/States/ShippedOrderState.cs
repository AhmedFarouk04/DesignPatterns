namespace State.DP.Correct.States;

public class ShippedOrderState : IOrderState
{
    public void Pay(Order order)
    {
        throw new Exception("Cannot pay shipped order");
    }

    public void Ship(Order order)
    {
        throw new Exception("Order already shipped");
    }
}
