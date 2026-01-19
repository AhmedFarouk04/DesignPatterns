namespace Flyweight.DP.Correct.Flyweights;
public class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public byte[] Texture { get; }

    public TreeType(string name, string color, byte[] texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine(
            $"Drawing {Name} tree at ({x},{y}) with color {Color}");
    }
}
