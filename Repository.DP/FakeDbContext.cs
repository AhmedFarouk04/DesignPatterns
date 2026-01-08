using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DP
{
    public class FakeDbContext
     {
        public List<Order> Orders { get; set; } = new()
    {
        new Order { Id = 1, Price = 50,  CreatedAt = DateTime.Now.AddDays(-2) },
        new Order { Id = 2, Price = 200, CreatedAt = DateTime.Now.AddDays(-1) },
        new Order { Id = 3, Price = 500, CreatedAt = DateTime.Now }
    };
    
    
    
    }

}
