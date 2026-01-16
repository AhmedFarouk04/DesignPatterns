using MediatR;

namespace Mediator.DP.Commands;

public record CreateOrderCommand(int OrderId) : IRequest<Unit>;
