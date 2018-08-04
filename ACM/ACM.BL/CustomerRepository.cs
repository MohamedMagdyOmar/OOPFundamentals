using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public bool Save()
        {
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.FirstName = "Mohamed";
                customer.LastName = "Magdy";
                customer.EmailAddress = "mohamedmagdyomar@gmail.com";
            }

            return customer;
        }
    }
}
