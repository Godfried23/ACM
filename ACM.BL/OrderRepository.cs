using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {
        public Order Retrieve(int orderItemId)
        {
            //Create the instance of the Order class
            //Pass in the requested Id
            Order order = new Order(orderItemId);

            //Code that retrieves the defined product

            //Temporary hard coded values to return a popluated product
            if (orderItemId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 10, 25, 12, 30, 30, TimeSpan.FromHours(5));
            }

            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
