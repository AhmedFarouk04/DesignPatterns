using Adapter.DP.Abstractions;
using Adapter.DP.External;

namespace Adapter.DP.Adapters;

public class StripeAdapter : IPaymentGateway
{
    private readonly StripeApi _stripeApi;

    public StripeAdapter(StripeApi stripeApi)
    {
        _stripeApi = stripeApi;
    }

    public void Pay(decimal amount)
    {
        _stripeApi.Process(amount);
    }
}
