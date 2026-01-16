namespace Mediator.DP.Wrong;

public class OrderService
{
    private readonly EmailService _emailService;

    public OrderService()
    {
        _emailService = new EmailService();
    }

    public void CreateOrder(int orderId)
    {
        Console.WriteLine($"Order {orderId} created");

        // ❌ Direct dependency
        _emailService.SendEmail(orderId);
    }
}
