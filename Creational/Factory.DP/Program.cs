using Factory.DP.Correct;

namespace Factory.DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new PaymentFactory();
            var service = new PaymentService(factory);

            service.Pay("Cash", 100);
            service.Pay("Card", 250);
        }
    }
}
