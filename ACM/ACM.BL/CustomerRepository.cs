using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        // the method "save" takes an instance of the "customer" class
        // then uses info from this instance to save info to the DB (serialize this "customer" class).
        // this also a "collaboration" relationship, because this class
        // "uses a" instance of this class.
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
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

        public Customer Retrieve(int customerId)
        {
            // here we create new instance of the customer class
            // then populate it with info from DB
            // so this "Collaboration" relationship, because
            // this class "uses a" the "customer" class
            var customer = new Customer(customerId);

            // due to this "composition", so this means that unit testing of "CustomerRepository" does not only
            // test this class but also it test "AddressRepository", so you will need to mock it but not now.
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
