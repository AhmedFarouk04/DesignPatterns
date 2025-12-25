namespace Decorator.DP.Wrong;

public class BeverageService
{
    public decimal GetCost(string type)
    {
        if (type == "Milk")
            return 12;

        if (type == "MilkMocha")
            return 15;

        if (type == "MilkMochaCaramel")
            return 19;

        return 10;
    }
}
