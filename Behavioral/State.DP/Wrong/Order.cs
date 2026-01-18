public class Order
{
    public bool IsPaid { get; set; }
    public bool IsShipped { get; set; }

    public void Pay()
    {
        if (IsPaid)
            throw new Exception("Already paid");

        IsPaid = true;
        Console.WriteLine("Order paid");
    }

    public void Ship()
    {
        if (!IsPaid)
            throw new Exception("Pay first");

        if (IsShipped)
            throw new Exception("Already shipped");

        IsShipped = true;
        Console.WriteLine("Order shipped");
    }
}
