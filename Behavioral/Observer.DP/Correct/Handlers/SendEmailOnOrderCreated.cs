using Observer.DP.Correct.Domain.Events;

namespace Observer.DP.Correct.Handlers;

public class SendEmailOnOrderCreated
{
    public void Handle(OrderCreatedEvent @event)
    {
        Console.WriteLine($"Email sent for order {@event.OrderId}");
    }
}
