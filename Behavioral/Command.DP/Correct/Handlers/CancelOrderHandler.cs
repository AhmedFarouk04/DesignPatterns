using Command.DP.Correct.Commands;
using Command.DP.Correct.Handlers;

namespace Command.DP.Handlers;

public class CancelOrderHandler
    : ICommandHandler<CancelOrderCommand>
{
    public void Handle(CancelOrderCommand command)
    {
        Console.WriteLine($"Order {command.OrderId} cancelled");
    }
}
