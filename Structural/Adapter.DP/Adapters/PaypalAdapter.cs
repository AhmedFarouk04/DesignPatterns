using Adapter.DP.Abstractions;
using Adapter.DP.External;

namespace Adapter.DP.Adapters;

public class PaypalAdapter : IPaymentGateway
{
    private readonly PaypalApi _paypalApi;

    public PaypalAdapter(PaypalApi paypalApi)
    {
        _paypalApi = paypalApi;
    }

    public void Pay(decimal amount)
    {
        _paypalApi.MakePayment(amount);
    }
}
