using Adapter.DP.Adapters;
using Adapter.DP.External;
using Adapter.DP.Abstractions;

Console.WriteLine("=== Adapter Pattern Demo ===");

IPaymentGateway payment = new PaypalAdapter(new PaypalApi());
payment.Pay(1000);

payment = new StripeAdapter(new StripeApi());
payment.Pay(500);
