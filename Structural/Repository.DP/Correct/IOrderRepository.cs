using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DP.Correct
{
    public interface IOrderRepository
    {
        List<Order> GetHighValueOrders();
    }

}
