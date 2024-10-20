using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub.Sample
{
    public class OrderRepository : IOrderRepository
    {
        public Order GetOrderById(int id)
        {
            return new Order();
        }
    }
}
