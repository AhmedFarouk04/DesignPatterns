using Facade.DP.Correct;

Console.WriteLine("=== Facade Pattern Demo ===");

var facade = new OrderFacade();
facade.PlaceOrder();
