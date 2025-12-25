using Decorator.DP.Abstractions;

namespace Decorator.DP.Decorators;

public abstract class BeverageDecorator : IBeverage
{
    //  Composition relationship(has a)
    protected readonly IBeverage _beverage;

    protected BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public virtual string GetDescription()
        => _beverage.GetDescription();

    public virtual decimal GetCost()
        => _beverage.GetCost();
}
