using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DP.Wrong
{
    public class OrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public List<Order> GetHighValueOrders()
        {
            return _repository.GetAll()
                .Where(o => o.Price > 100)
                .OrderBy(o => o.CreatedAt)
                .ToList();
        }
    }

}
