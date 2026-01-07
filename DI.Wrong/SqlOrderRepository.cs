using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Wrong
{
    public class SqlOrderRepository
    {
        public void Save()
        {
            Console.WriteLine("Saving order to SQL Database");
        }
    }

}
