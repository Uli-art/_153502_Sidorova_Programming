using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Hotel
    {
        string nameOfHotel;
        List<Customer> customers;
        List<Order> orders;
        List<Room> rooms;
        public void AddRoom(int num, double cost, int type) {
            Room newroom = new Room(num, cost, type);
            if (!rooms.Contains(newroom))
            {
                rooms.Add(newroom);
            }
        }
         public void Registration(string name)
        {
            Customer newCust = new Customer(name);
            if (!customers.Contains(newCust))
            {
                customers.Add(newCust);
            }
        }

        public void AddOrder(string name, int num) {
            int index = -1;
            for (int i = 0; i < rooms.Count(); ++i) {
                if(rooms[i].getNumber() == num)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1) {
                return;
            }
            if (rooms[index].isFree())
            {
                Registration(name);
                rooms[index].ChangeFree();
                Customer newcust = GetCustomer(name);
                if (newcust.getNumOfOrder() == -1)
                {
                    newcust.setNumOfOrder(num);
                    orders.Add(new Order(newcust, rooms[index]));
                }
            }
        }

        public double GetPrice(string name) {
            Customer newcust = GetCustomer(name);
            Order newOrder = GetOrder(newcust);
            if (newOrder != null) {
                return newOrder.getRoom().getCost();
            }
            return 0;   
        }

        public Order GetOrder(Customer customer) {
            for (int i = 0; i < orders.Count(); ++i) {
                if(orders[i].getCustomer() == customer)
                {
                    return orders[i];   
                }
            }
            return null;
        }

        public List<Room> getFreeRoom() {
            List<Room> roomList = new List<Room>();
            for (int i = 0; i < rooms.Count(); ++i) {
                if (rooms[i].isFree()) {
                    roomList.Add(rooms[i]);
                }
            }
            return roomList;
        }

        public Customer GetCustomer(string name) {
            int index = -1;
            for (int i = 0; i < customers.Count(); ++i)
            {
                if (customers[i].getName() == name)
                {
                    return customers[i];
                }
            }
            return null;
        }

        private Hotel(string nameOfHotel)
        {
            this.nameOfHotel = nameOfHotel;
            customers = new List<Customer>();
            orders = new List<Order>();
            rooms = new List<Room>();
        }

        private static Hotel _instance = null;
        public static Hotel GetInstance(string nameOfHotel = "")
        {
            if (_instance == null)
            {
                _instance = new Hotel(nameOfHotel);
            }
            return _instance;
        }
    }
}

