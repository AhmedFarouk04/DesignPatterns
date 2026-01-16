using Command.DP;
using Command.DP.Correct.Commands;
using Command.DP.Handlers;
using Command.DP.Correct.Models;

Console.WriteLine("=== Command Pattern Demo ===");

var dispatcher = new CommandDispatcher();

dispatcher.Register(new CreateOrderHandler());
dispatcher.Register(new CancelOrderHandler());

dispatcher.Dispatch(new CreateOrderCommand(new Order { Id = 1 }));
dispatcher.Dispatch(new CancelOrderCommand(1));
