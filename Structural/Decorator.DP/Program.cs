using Decorator.DP.Abstractions;
using Decorator.DP.Components;
using Decorator.DP.Decorators;

Console.WriteLine("=== Decorator Pattern Demo ===");

IBeverage coffee = new Espresso();
Console.WriteLine($"{coffee.GetDescription()} = {coffee.GetCost()}");

coffee = new Milk(coffee);
coffee = new Mocha(coffee);
coffee = new Caramel(coffee);

Console.WriteLine($"{coffee.GetDescription()} = {coffee.GetCost()}");
