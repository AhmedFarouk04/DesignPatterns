using Decorator.DP.Abstractions;

namespace Decorator.DP.Decorators;

public class Mocha : BeverageDecorator
{
    public Mocha(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
        => $"{base.GetDescription()}, Mocha";

    public override decimal GetCost()
        => base.GetCost() + 3m;
}
