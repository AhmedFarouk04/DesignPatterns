using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DP.Wrong
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetAll();
    }

}
