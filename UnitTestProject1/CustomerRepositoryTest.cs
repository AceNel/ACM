using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrievalValid()

        {
            //Arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
               
                EmailAddress = "Kim@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //Act
            var actual = customerRepository.Retrieve(1);


            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
