using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DP.External;

public class StripeApi
{
    public void Process(decimal total)
    {
        Console.WriteLine($"Paid {total} using Stripe");
    }
}

