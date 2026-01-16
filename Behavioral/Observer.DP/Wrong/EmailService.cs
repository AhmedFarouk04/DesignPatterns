namespace Observer.DP.Wrong;

public class EmailService
{
    public void Send(int orderId)
    {
        Console.WriteLine($"[EmailService] Email sent for order {orderId}");
    }
}
