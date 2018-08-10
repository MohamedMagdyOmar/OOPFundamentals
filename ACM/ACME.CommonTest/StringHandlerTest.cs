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
            StringHandler stringhandler = new StringHandler();

            var expected = "Sonic Screwdriver";

            var actual = stringhandler.InsertSpaces("SonicScrewdriver");

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            StringHandler stringhandler = new StringHandler();

            var expected = "Sonic Screwdriver";

            var actual = stringhandler.InsertSpaces("Sonic Screwdriver");

            Assert.AreEqual(actual, expected);
        }
    }
}
