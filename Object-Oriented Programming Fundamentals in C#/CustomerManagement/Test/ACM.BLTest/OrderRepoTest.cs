using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepoTest
    {
        [TestMethod]
        public void RetriveOrderDisplayTest()
        {
            var orderrepo = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                            new TimeSpan(7, 0, 0)),
        };

            var actual = orderrepo.Retrieve(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            
        }
    }
}
