using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class OrderDisplay
    {
        // this class contains only info required to display order.
        // it doesnot refrence "customer" class or "order" class.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? orderDate { get; set; }

        // "composition" relationship with the "OrderDisplayItem" class.
        public List<OrderDisplayItem> OrderDisplayItemList { get; set; }
        public int OrderIt { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
