namespace Composite.DP.Correct.Components;

public interface IFileSystemItem
{
    string Name { get; }
    int GetSize();
    void Display(string indent);
}
