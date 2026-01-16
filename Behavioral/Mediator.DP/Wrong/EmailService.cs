namespace Mediator.DP.Wrong;

public class EmailService
{
    public void SendEmail(int orderId)
    {
        Console.WriteLine($"Email sent for order {orderId}");
    }
}
