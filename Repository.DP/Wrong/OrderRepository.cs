using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DP.Wrong
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FakeDbContext _context;

        public OrderRepository(FakeDbContext context)
        {
            _context = context;
        }

        public IQueryable<Order> GetAll()
        {
            return _context.Orders.AsQueryable();
        }
    }


}
