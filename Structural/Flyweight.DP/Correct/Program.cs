using Flyweight.DP.Correct.Context;
using Flyweight.DP.Correct.Factory;

Console.WriteLine("=== Flyweight Pattern Demo ===");

var forest = new List<Tree>();

for (int i = 0; i < 100_000; i++)
{
    var type = TreeFactory.GetTreeType(
        "Oak", "Green", new byte[1024]);

    forest.Add(new Tree(i, i * 2, type));
}

forest[0].Draw();
forest[99999].Draw();
