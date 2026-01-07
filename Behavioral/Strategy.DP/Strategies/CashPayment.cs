
namespace Strategy.DP.Strategies;

public class CashPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} in Cash");
    }
}
