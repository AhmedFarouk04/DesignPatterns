using Observer.DP.Correct.Domain.Events;

namespace Observer.DP.Correct.Domain;

public class Order
{
    public int Id { get; }

    public event Action<OrderCreatedEvent>? OrderCreated;

    public Order(int id)
    {
        Id = id;
    }

    public void Create()
    {
        Console.WriteLine($"Order {Id} created");

        OrderCreated?.Invoke(new OrderCreatedEvent(Id));
    }
}
