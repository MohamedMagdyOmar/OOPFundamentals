using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer();
            customer.EmailAddress = "mohamedmagdyomar@gmail.com";
            customer.LastName = "Mohamed";

            var actual = customer.Validate();

            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer();
            customer.EmailAddress = "mohamedmagdyomar@gmail.com";

            var actual = customer.Validate();

            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}
