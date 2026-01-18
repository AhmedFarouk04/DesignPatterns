using Composite.DP.Correct.Components;

namespace Composite.DP.Correct.Leaf;

public class FileLeaf : IFileSystemItem
{
    public string Name { get; }
    private readonly int _size;

    public FileLeaf(string name, int size)
    {
        Name = name;
        _size = size;
    }

    public int GetSize() => _size;

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}- {Name} ({_size} KB)");
    }
}
