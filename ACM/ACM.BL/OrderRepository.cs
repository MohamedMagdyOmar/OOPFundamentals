using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
                {
                    // call insert procedure
                }

                else
                {
                    // call update procedure
                }

            }
            return success;
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

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            if(orderId == 10)
            {
                orderDisplay.FirstName = "Mohamed";
                orderDisplay.LastName = "Magdy";
                orderDisplay.orderDate = new DateTimeOffset(2018, 8, 6, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "114"
                };
            }

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();


            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96m,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6m,
                    OrderQuantity = 1
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
            }
            return orderDisplay;
        }
    }
}
