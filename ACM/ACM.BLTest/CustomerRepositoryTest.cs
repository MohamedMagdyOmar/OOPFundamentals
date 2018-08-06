using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            var expected = new Customer
            {
                FirstName = "Mohamed",
                LastName = "Magdy",
                EmailAddress = "mohamedmagdyomar@gmail.com"
            };


            var customerRepository = new CustomerRepository();
            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);


        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Mohamed",
                LastName = "Magdy",
                EmailAddress = "mohamedmagdyomar@gmail.com",
                AddressList = new System.Collections.Generic.List<Address>
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "BagShot Row",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144",
                        City = "Hobbiton"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144",
                        City = "ByWater"
                    }
                }
            };
            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);

            }


        }
    }
}
