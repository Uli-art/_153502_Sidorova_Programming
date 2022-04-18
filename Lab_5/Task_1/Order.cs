using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Order
    {
        Customer customer;
        Room room;
        public Order(Customer cust, Room r)
        {
            customer = cust;
            room = r;
        }
        public Customer getCustomer() {
            return customer;
        }

        public Room getRoom()
        {
            return room;
        }
    }
}
