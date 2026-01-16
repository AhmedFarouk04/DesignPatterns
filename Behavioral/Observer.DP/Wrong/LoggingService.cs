namespace Observer.DP.Wrong;

public class LoggingService
{
    public void Log(int orderId)
    {
        Console.WriteLine($"[LoggingService] Order {orderId} logged");
    }
}
