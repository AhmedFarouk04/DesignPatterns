using Facade.DP.Correct.Subsystems;

public class OrderService
{
    public void PlaceOrder()
    {
        var inventory = new InventoryService();
        inventory.CheckStock();

        var payment = new PaymentService();
        payment.Pay();

        var shipping = new ShippingService();
        shipping.Ship();

        var notification = new NotificationService();
        notification.Send();
    }
}
