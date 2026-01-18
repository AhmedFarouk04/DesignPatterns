using Composite.DP.Correct.Components;

namespace Composite.DP.Correct.Composite;

public class DirectoryComposite : IFileSystemItem
{
    public string Name { get; }
    private readonly List<IFileSystemItem> _children = new();

    public DirectoryComposite(string name)
    {
        Name = name;
    }

    public void Add(IFileSystemItem item)
    {
        _children.Add(item);
    }

    public int GetSize()
    {
        return _children.Sum(c => c.GetSize());
    }

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}+ {Name}");

        foreach (var child in _children)
        {
            child.Display(indent + "  ");
        }
    }
}
