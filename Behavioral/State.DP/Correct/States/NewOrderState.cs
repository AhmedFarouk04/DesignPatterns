namespace State.DP.Correct.States;

public class NewOrderState : IOrderState
{
    public void Pay(Order order)
    {
        Console.WriteLine("Order paid");
        order.SetState(new PaidOrderState());
    }

    public void Ship(Order order)
    {
        throw new Exception("Cannot ship unpaid order");
    }
}
