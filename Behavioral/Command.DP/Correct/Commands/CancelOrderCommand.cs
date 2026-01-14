namespace Command.DP.Correct.Commands;

public class CancelOrderCommand : ICommand
{
    public int OrderId { get; }

    public CancelOrderCommand(int orderId)
    {
        OrderId = orderId;
    }
}
