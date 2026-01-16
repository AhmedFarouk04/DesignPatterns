using Observer.DP.Correct.Domain;
using Observer.DP.Correct.Handlers;

Console.WriteLine("=== Observer Pattern Demo ===");

var order = new Order(1);

var emailHandler = new SendEmailOnOrderCreated();
var logHandler = new LogOrderCreated();

// Subscribe
order.OrderCreated += emailHandler.Handle;
order.OrderCreated += logHandler.Handle;

// Action
order.Create();
