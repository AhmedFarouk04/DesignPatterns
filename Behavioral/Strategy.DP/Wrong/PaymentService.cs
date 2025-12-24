namespace Strategy.DP.Wrong;

// Violates Open/Closed Principle
// Uses conditional logic
public class PaymentService
{
    public void Pay(string paymentType, decimal amount)
    {
        if (paymentType == "CreditCard")
        {
            Console.WriteLine($"Paid {amount} using Credit Card");
        }
        else if (paymentType == "Paypal")
        {
            Console.WriteLine($"Paid {amount} using PayPal");
        }
        else if (paymentType == "Cash")
        {
            Console.WriteLine($"Paid {amount} using Cash");
        }
        else
        {
            throw new InvalidOperationException("Invalid payment type");
        }
    }
}
