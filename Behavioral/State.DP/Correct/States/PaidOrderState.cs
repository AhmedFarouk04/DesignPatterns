namespace State.DP.Correct.States;

public class PaidOrderState : IOrderState
{
    public void Pay(Order order)
    {
        throw new Exception("Order already paid");
    }

    public void Ship(Order order)
    {
        Console.WriteLine("Order shipped");
        order.SetState(new ShippedOrderState());
    }
}
