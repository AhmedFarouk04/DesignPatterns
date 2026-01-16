using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Mediator.DP.Commands;

var services = new ServiceCollection();

services.AddMediatR(typeof(Program));

var provider = services.BuildServiceProvider();
var mediator = provider.GetRequiredService<IMediator>();

Console.WriteLine("=== Mediator Pattern Demo ===");

await mediator.Send(new CreateOrderCommand(1));
