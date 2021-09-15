using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace UnitTestProject1
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveProductDisplayTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 12000,
                ProductDescription = "24 Inch",
                ProductName = "Monitor"

            };
            //Act
            var actual = productRepository.Retrieve(2);



            //Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
