using Command.DP.Correct.Commands;
using Command.DP.Correct.Handlers;

namespace Command.DP.Handlers;

public class CreateOrderHandler
    : ICommandHandler<CreateOrderCommand>
{
    public void Handle(CreateOrderCommand command)
    {
        Console.WriteLine($"Order {command.Order.Id} created");
    }
}
