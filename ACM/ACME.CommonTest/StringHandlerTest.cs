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
            var source = "SonicScrewdriver";

            var actual = source.InsertSpaces();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var expected = "Sonic Screwdriver";
            var source = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.AreEqual(actual, expected);
        }
    }
}
