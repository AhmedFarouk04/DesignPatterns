using Decorator.DP.Abstractions;

namespace Decorator.DP.Components;

public class Espresso : IBeverage
{
    public string GetDescription()
        => "Espresso";

    public decimal GetCost()
        => 10m;
}
