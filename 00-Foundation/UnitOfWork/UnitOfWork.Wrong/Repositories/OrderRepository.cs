using UnitOfWork.Wrong.Models;
using UnitOfWork.Wrong.Data;

namespace UnitOfWork.Wrong.Repositories;

public class OrderRepository
{
    private readonly FakeDbContext _context;

    public OrderRepository(FakeDbContext context)
    {
        _context = context;
    }

    public void Add(Order order)
    {
        _context.Orders.Add(order);
        _context.Save();
    }
}
