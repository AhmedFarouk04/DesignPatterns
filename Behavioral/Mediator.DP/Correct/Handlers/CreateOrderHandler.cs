using MediatR;
using Mediator.DP.Commands;

namespace Mediator.DP.Handlers;

public class CreateOrderHandler
    : IRequestHandler<CreateOrderCommand, Unit>
{
    public Task<Unit> Handle(
        CreateOrderCommand request,
        CancellationToken cancellationToken)
    {
        Console.WriteLine($"Order {request.OrderId} created");
        return Task.FromResult(Unit.Value);
    }
}
