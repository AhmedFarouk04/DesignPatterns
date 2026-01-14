using Command.DP.Correct.Models;

namespace Command.DP.Correct.Commands;

public class CreateOrderCommand : ICommand
{
    public Order Order { get; }

    public CreateOrderCommand(Order order)
    {
        Order = order;
    }
}
