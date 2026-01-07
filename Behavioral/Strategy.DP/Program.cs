using Strategy.DP.Context;
using Strategy.DP.Strategies;
namespace Strategy.DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("=== Strategy Pattern Demo ===");

            var context = new PaymentContext(new CreditCardPayment());
            context.ExecutePayment(1000);

            context.SetStrategy(new PaypalPayment());
            context.ExecutePayment(500);

            context.SetStrategy(new CashPayment());
            context.ExecutePayment(200);
        }
    }
}
