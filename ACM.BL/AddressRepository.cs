using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            //Create an instance of the Address Class
            //Pass in the requested Id

            Address address = new Address(addressId);

            //Code that retrieves the defined address

            //Temporary hard coded values to return
            //A populated address

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bag Shot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address; 
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1);
            {
            address.AddressType = 1;
            address.StreetLine1 = "Bag End";
            address.StreetLine2 = "Bag Shot Row";
            address.City = "Hobbiton";
            address.State = "Shire";
            address.Country = "Middle Earth";
            address.PostalCode = "144";

        }

            addressList.Add(address);

            address = new Address(2);
            {
                address.AddressType = 2;
                address.StreetLine1 = "Neema Av";
                address.StreetLine2 = "Mukoma Av";
                address.City = "Cincinatti";
                address.State = "MaryLand";
                address.Country = "Venus";
                address.PostalCode = "169";
            };
            addressList.Add(address);
            return addressList;
        }


        //Saves the current address

        public bool Save(Address address)
        {
            return true;
        }

    }
}
