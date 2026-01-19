using Flyweight.DP.Correct.Flyweights;
namespace Flyweight.DP.Correct.Factory;
public static class TreeFactory
{
    private static readonly Dictionary<string, TreeType> _treeTypes
        = new();

    public static TreeType GetTreeType(
        string name, string color, byte[] texture)
    {
        var key = $"{name}_{color}";

        if (!_treeTypes.ContainsKey(key))
        {
            _treeTypes[key] =
                new TreeType(name, color, texture);
        }

        return _treeTypes[key];
    }
}
