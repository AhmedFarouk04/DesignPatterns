using Facade.DP.Correct.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.DP.Correct
{
    public class OrderFacade
    {
        private readonly InventoryService _inventory;
        private readonly PaymentService _payment;
        private readonly ShippingService _shipping;
        private readonly NotificationService _notification;

        public OrderFacade()
        {
            _inventory = new InventoryService();
            _payment = new PaymentService();
            _shipping = new ShippingService();
            _notification = new NotificationService();
        }

        public void PlaceOrder()
        {
            _inventory.CheckStock();
            _payment.Pay();
            _shipping.Ship();
            _notification.Send();
        }
    }

}
