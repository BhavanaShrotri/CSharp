using System;
using CustomerManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepoTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            var productRepo = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Set of 4 Bright Yellow mini Sunflowers ",
                CurrentPrice = 20.50M
        };

            var actual = productRepo.Retrieve(2);

            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }



        [TestMethod]
        public void SaveTestValid()
        {
            var productRepo = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Set of 4 Bright Yellow mini Sunflowers ",
                CurrentPrice = 20.50M,
                HasChanges=true
            };

            var actual = productRepo.Save(updatedProduct);

            Assert.AreEqual(true, actual);
          
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            var productRepo = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Sunflowers",
                ProductDescription = "Set of 4 Bright Yellow mini Sunflowers ",
                CurrentPrice = null,
                HasChanges = true
            };

            var actual = productRepo.Save(updatedProduct);

            Assert.AreEqual(false, actual);

        }





    }
}
