using UnitOfWork.Correct.Models;
using UnitOfWork.Correct.Data;

namespace UnitOfWork.Correct.Repositories;

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
    }
}
