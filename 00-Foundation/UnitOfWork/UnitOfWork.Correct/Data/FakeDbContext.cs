using UnitOfWork.Correct.Models;

namespace UnitOfWork.Correct.Data;

public class FakeDbContext
{
    public List<Order> Orders { get; } = new();
}
