using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DP
{
    public class Order
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }
    }

}
