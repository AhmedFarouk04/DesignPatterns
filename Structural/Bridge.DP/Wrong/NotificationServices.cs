public class EmailUrgentNotification
{
    public void Send(string message)
    {
        Console.WriteLine($"URGENT EMAIL: {message}");
    }
}

public class SmsUrgentNotification
{
    public void Send(string message)
    {
        Console.WriteLine($"URGENT SMS: {message}");
    }
}
