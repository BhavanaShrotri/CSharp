using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.commonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            var source = "BhavanaShrotri";
            var expected = "Bhavana Shrotri";
           

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            var source = "Bhavana Shrotri";
            var expected = "Bhavana Shrotri";
      

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
