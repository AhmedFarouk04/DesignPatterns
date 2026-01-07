using Decorator.DP.Abstractions;

namespace Decorator.DP.Decorators;

public class Caramel : BeverageDecorator
{
    public Caramel(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
        => $"{base.GetDescription()}, Caramel";

    public override decimal GetCost()
        => base.GetCost() + 4m;
}
