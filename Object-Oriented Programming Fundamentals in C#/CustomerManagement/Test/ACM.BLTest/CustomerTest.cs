using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Bhavana",
                LastName = "Shrotri"
            };

            string expected = "Bhavana, Shrotri";
            string actual = customer.FullName;
            Assert.AreEqual(expected,actual);
        }
    }


    [TestClass]
    public class FullNameFirstNameEmpty
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                LastName = "Shrotri"
            };

            string expected = "Shrotri";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class FullNameLastNameEmpty
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Bhavana"
            };

            string expected = "Bhavana";
            string actual = customer.FullName;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bhavana";
            Customer.InstantCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Rachana";
            Customer.InstantCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Shreya";
            Customer.InstantCount += 1;

            Assert.AreEqual(3, Customer.InstantCount);

        }


    }



}
