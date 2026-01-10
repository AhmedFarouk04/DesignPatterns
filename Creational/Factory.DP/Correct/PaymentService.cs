using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.DP.Correct
{
    public class PaymentService
    {
        private readonly PaymentFactory _factory;

        public PaymentService(PaymentFactory factory)
        {
            _factory = factory;
        }

        public void Pay(string method, decimal amount)
        {
            var payment = _factory.Create(method);
            payment.Pay(amount);
        }
    }

}
