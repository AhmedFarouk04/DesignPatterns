using Factory.DP.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.DP.Wrong
{
    public class PaymentService
    {
        public void Pay(string method, decimal amount)
        {
            IPayment payment;

            if (method == "Cash")
                payment = new CashPayment();
            else if (method == "Card")
                payment = new CreditCardPayment();
            else
                throw new Exception("Invalid payment method");

            payment.Pay(amount);
        }
    }

}
