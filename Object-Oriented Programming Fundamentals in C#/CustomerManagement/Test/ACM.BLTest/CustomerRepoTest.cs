using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepoTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            var customerRepo = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAddress = "bhavana@gmail.com",
                FirstName = "Bhavana",
                LastName = "Shrotri"
            };

            var actual = customerRepo.Retrieve(1);

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
