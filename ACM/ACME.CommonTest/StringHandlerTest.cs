using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.Common;
namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var expected = "Sonic Screwdriver";

            var actual = StringHandler.InsertSpaces("SonicScrewdriver");

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var expected = "Sonic Screwdriver";

            var actual = StringHandler.InsertSpaces("Sonic Screwdriver");

            Assert.AreEqual(actual, expected);
        }
    }
}
