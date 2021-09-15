using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        //Retrieve One Order

        public Order Retrieve(int orderId)
        {
            //Create an insatnce of the customer class
            //pass in the id

            Order order = new Order(orderId);

            if (orderId == 5)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }



            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }

    } 

}





