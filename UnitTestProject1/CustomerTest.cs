using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTEST
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()

        {
            //Arrange

            Customer customer = new Customer
            {
                FirstName = "Nelson",
                LastName = "Karanja"
            };
            string expected = "Karanja, Nelson";

            //Act

            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                LastName = "Karanja" 
            };
            string expected = "Karanja";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Nelson"
            };
            string expected = "Nelson";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Kim";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Jon";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Yu";
            Customer.InstanceCount += 1;

            //Act


            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Karanja",
                EmailAddress = "Kim@gmail.com"
            };
            var expected = true;

            //Act
            var actual = customer.Validate();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer
            {
                EmailAddress = "Kim@gmail.com"
            };

            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        

        
       
    }
}
