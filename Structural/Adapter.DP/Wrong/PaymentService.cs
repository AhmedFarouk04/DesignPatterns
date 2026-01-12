using Adapter.DP.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DP.Wrong
{
    public class PaymentService
    {
        public void Pay(string provider, decimal amount)
        {
            if (provider == "PayPal")
            {
                var paypal = new PaypalApi();
                paypal.MakePayment(amount);
            }
            else if (provider == "Stripe")
            {
                var stripe = new StripeApi();
                stripe.Process(amount);
            }
        }
    }

}
