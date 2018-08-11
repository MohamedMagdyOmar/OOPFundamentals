using System;
using System.Collections.Generic;
using ACM.BL;
using ACME.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.CommonTest
{
    [TestClass]
    public class LoggableServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var ChangedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "mohamedmagdyomar@gmail.com",
                FirstName = "Mohamed",
                LastName = "Omar",
                AddressList = null
            };

            ChangedItems.Add(customer as ILoggable);

            var product = new Product()
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake With Steel Head",
                CurrentPrice = 6m
            };

            ChangedItems.Add(product as ILoggable);

            LoggingService.WriteToFile(ChangedItems);
        }
    }
}
