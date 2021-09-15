using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set;  }
        //Retrieve One Customer

        public Customer Retrieve(int customerId)
        {
            //Create an insatnce of the customer class
            //pass in the id

            Customer customer = new Customer(customerId);

            if(customerId == 1)
            {
                customer.EmailAddress = "Kim@gmail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        //Save Current Customer

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
  