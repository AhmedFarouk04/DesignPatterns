using Decorator.DP.Abstractions;

namespace Decorator.DP.Decorators;

public class Milk : BeverageDecorator
{
    public Milk(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
        => $"{base.GetDescription()}, Milk";

    public override decimal GetCost()
        => base.GetCost() + 2m;
}
