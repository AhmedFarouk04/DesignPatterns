using UnitOfWork.Wrong.Models;

namespace UnitOfWork.Wrong.Data;

public class FakeDbContext
{
    public List<Order> Orders { get; } = new();

    public void Save()
    {
        Console.WriteLine("Saving changes...");
    }
}
