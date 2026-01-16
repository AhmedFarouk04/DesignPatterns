namespace Observer.DP.Correct.Domain.Events;

public class OrderCreatedEvent
{
    public int OrderId { get; }

    public OrderCreatedEvent(int orderId)
    {
        OrderId = orderId;
    }
}
