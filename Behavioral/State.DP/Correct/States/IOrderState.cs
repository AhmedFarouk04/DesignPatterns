using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.DP.Correct.States
{

    public interface IOrderState
    {
        void Pay(Order order);
        void Ship(Order order);
    }

}
