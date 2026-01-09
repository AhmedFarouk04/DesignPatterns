using UnitOfWork.Correct.Data;

namespace UnitOfWork.Correct.Repositories;

public class ProductRepository
{
    private readonly FakeDbContext _context;

    public ProductRepository(FakeDbContext context)
    {
        _context = context;
    }

    public void UpdateStock()
    {
        Console.WriteLine("Stock updated.");
    }
}
