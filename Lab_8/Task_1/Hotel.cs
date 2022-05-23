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
        List<Room> rooms;

        public void AddRoomWithDiscount(int num, double cost, double dis)
        {
            IPrice info = new Discount(cost, dis);
            Room newroom = new Room(num, info);
            if (!rooms.Contains(newroom))
            {
                rooms.Add(newroom);
            }
        }

        public void AddRoomWithoutDiscount(int num, double cost)
        {
            IPrice info = new NoDiscount(cost);
            Room newroom = new Room(num, info);
            if (!rooms.Contains(newroom))
            {
                rooms.Add(newroom);
            }
        }

        public double GetAveragePrice()
        {
            double avgPrice = 0;
            for(int i = 0; i < rooms.Count; ++i)
            {
                avgPrice += rooms[i].GetPrice();
            }   
            return avgPrice;
        }


        public List<Room> GetRooms()
        {
            return rooms;
        }

        private Hotel(string nameOfHotel)
        {
            this.nameOfHotel = nameOfHotel;
            rooms = new List<Room>();
        }

        public static Hotel GetInstance(string nameOfHotel = "")
        {
            if (_instance == null)
            {
                _instance = new Hotel(nameOfHotel);
            }
            return _instance;
        }

        private static Hotel _instance = null;

    }

}

