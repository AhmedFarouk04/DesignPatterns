using Factory.DP.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.DP.Payments
{
    public class CashPayment : IPayment
    {
        public void Pay(decimal amount)
            => Console.WriteLine($"Paid {amount} in cash");
    }

}
