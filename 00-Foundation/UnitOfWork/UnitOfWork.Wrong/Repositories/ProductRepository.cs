using UnitOfWork.Wrong.Data;

namespace UnitOfWork.Wrong.Repositories;

public class ProductRepository
{
    private readonly FakeDbContext _context;

    public ProductRepository(FakeDbContext context)
    {
        _context = context;
    }

    public void UpdateStock()
    {
        _context.Save(); 
    }
}
