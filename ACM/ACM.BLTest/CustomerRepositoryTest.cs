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
    }
}
