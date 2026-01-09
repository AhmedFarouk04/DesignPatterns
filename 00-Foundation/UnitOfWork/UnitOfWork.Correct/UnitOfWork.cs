using UnitOfWork.Correct.Data;
using UnitOfWork.Correct.Repositories;

namespace UnitOfWork.Correct
{
    public class UnitOfWork
    {
        private readonly FakeDbContext _context;

        public OrderRepository Orders { get; }
        public ProductRepository Products { get; }

        public UnitOfWork(FakeDbContext context)
        {
            _context = context;
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
        }

        public void Commit()
        {
            Console.WriteLine("Committing changes...");
        }
    }
}