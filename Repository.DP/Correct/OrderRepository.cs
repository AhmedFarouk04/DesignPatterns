using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DP.Correct
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FakeDbContext _context;

        public OrderRepository(FakeDbContext context)
        {
            _context = context;
        }

        public List<Order> GetHighValueOrders()
        {
            return _context.Orders
                .Where(o => o.Price > 100)
                .OrderBy(o => o.CreatedAt)
                .ToList();
        }
    }


}
