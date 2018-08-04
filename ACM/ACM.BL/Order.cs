using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int OrderId { get; private set; }

        public string ShippingAddress { get; set; }

        // "DateTimeOffset" is very usefull if date is in different time zone.
        // it is easier to be used than normalizing all date to "UTC".
        // we use "nullable" time to know if the date is set or not.
        public DateTimeOffset? OrderDate { get; set; }

        public Order Retrieve(int productId)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if(OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
