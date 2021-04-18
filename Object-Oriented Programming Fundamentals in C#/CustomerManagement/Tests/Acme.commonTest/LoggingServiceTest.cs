using System;
using System.Collections.Generic;
using Acme.Common;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.commonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changeditems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress ="bhavana@gmail.com",
                FirstName = "Bhavana",
                LastName = "Shrotri",
                AddressList = null
            };

            changeditems.Add(customer);

            var product = new Product(2)
            {
                ProductName="Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice= 6M
            };

            changeditems.Add(product);

            LoggingService.WriteToFile(changeditems);

        }

        
    }
}
