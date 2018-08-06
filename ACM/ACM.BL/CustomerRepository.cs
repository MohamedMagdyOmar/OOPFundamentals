using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        // the method "save" takes an instance of the "customer" class
        // then uses info from this instance to save info to the DB (serialize this "customer" class).
        // this also a "collaboration" relationship, because this class
        // "uses a" instance of this class.
        public bool Save(Customer customer)
        {
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            // here we create new instance of the customer class
            // then populate it with info from DB
            // so this "Collaboration" relationship, because
            // this class "uses a" the "customer" class
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
