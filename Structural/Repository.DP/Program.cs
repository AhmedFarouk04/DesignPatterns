using Repository.DP;
using Repository.DP.Correct;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Fake context
        var context = new FakeDbContext();

        IOrderRepository repository = new OrderRepository(context);

        var service = new OrderService(repository);

        var orders = service.GetOrders();

        foreach (var order in orders)
        {
            Console.WriteLine($"Order {order.Id} - Price: {order.Price}");
        }
    }
}
