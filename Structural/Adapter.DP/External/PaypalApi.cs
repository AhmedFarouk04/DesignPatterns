namespace Adapter.DP.External;

public class PaypalApi
{
    public void MakePayment(decimal money)
    {
        Console.WriteLine($"Paid {money} using PayPal");
    }
}
