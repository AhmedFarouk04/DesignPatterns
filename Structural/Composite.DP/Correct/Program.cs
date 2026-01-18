using System;
using Composite.DP.Correct.Composite;
using Composite.DP.Correct.Leaf;

namespace Composite.DP.Correct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Composite Pattern Demo ===");

            // Root directory
            var root = new DirectoryComposite("Root");

            // Files
            var file1 = new FileLeaf("file1.txt", 10);
            var file2 = new FileLeaf("file2.txt", 20);

            // Sub directory
            var images = new DirectoryComposite("Images");
            images.Add(new FileLeaf("img1.png", 50));
            images.Add(new FileLeaf("img2.png", 70));

            // Build tree
            root.Add(file1);
            root.Add(file2);
            root.Add(images);

            // Display structure
            root.Display("");

            // Total size
            Console.WriteLine($"\nTotal Size = {root.GetSize()} KB");
        }
    }
}
