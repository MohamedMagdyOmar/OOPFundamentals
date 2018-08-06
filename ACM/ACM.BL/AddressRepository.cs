using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class AddressRepository
    {
        public AddressRepository()
        {

        }

        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if(addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "BagShot Row";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
                address.City = "Hobbiton";
            }

            return address;
        }

        // return "IEnumerable" is recommended way, because the result is more flexible
        // for the caller of the method
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "BagShot Row",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
                City = "Hobbiton"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
                City = "ByWater"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
