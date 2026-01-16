using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DP.Wrong
{
    public class OrderService
    {
        private readonly EmailService _email;
        private readonly LoggingService _logging;

        public void CreateOrder(int orderId)
        {
            Console.WriteLine($"Order {orderId} created");

            _email.Send(orderId);
            _logging.Log(orderId);
        }
    }

}
