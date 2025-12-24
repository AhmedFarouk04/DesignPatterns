
namespace Strategy.DP.Strategies;

public class PaypalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal");
    }
}
