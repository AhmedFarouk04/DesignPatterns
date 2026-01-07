using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Wrong
{
    public class OrderService
    {
        private readonly SqlOrderRepository _repo;

        public OrderService()
        {
            _repo = new SqlOrderRepository();
        }

        public void CreateOrder()
        {
            _repo.Save();
        }
    }

}
