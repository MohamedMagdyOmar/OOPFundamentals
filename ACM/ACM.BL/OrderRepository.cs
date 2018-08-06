using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public bool Save()
        {
            return true;
        }

        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 2)
            {
                order.OrderDate = new DateTimeOffset(2018, 8, 4, 11, 19, 35, new TimeSpan(-7, 0, 0));
            }

            return order;
        }
    }
}
