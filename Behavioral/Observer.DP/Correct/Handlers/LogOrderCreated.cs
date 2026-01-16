using Observer.DP.Correct.Domain.Events;

namespace Observer.DP.Correct.Handlers;

public class LogOrderCreated
{
    public void Handle(OrderCreatedEvent @event)
    {
        Console.WriteLine($"Order {@event.OrderId} logged");
    }
}
