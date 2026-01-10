using Factory.DP.Payments;
using Factory.DP.Wrong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.DP.Correct
{
    public class PaymentFactory
    {
        public IPayment Create(string method)
        {
            return method switch
            {
                "Cash" => new CashPayment(),
                "Card" => new CreditCardPayment(),
                _ => throw new Exception("Invalid payment method")
            };
        }
    }

}
