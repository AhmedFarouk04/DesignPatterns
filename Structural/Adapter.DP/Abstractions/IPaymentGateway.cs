using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.DP.Abstractions
{

    public interface IPaymentGateway
    {
        void Pay(decimal amount);
    }

}
