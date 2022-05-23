using Xunit;
using System;
using System.Collections.Generic;
using Task_1;
using System.Linq;

namespace Task1
{
    public class UnitTest1
    {
        public bool DoubleEquals(double left, double right)
        {
            return Math.Abs(left - right) < 1E-4;
        }
        [Fact]
        public void Test1()
        {
            string name = "deew";
            Hotel hotel = Hotel.GetInstance(name);
            hotel.AddRoomWithoutDiscount(1, 34.2);
            hotel.AddRoomWithDiscount(27, 67.8, 10);
            hotel.AddRoomWithoutDiscount(2, 176.3);
            hotel.AddRoomWithDiscount(154, 98.7, 3);

            List<Room> rooms = hotel.GetRooms();
           
            Assert.True(DoubleEquals(34.2,rooms[0].GetPrice()));
            Assert.True(DoubleEquals(61.02, rooms[1].GetPrice()));
            Assert.True(DoubleEquals(176.3, rooms[2].GetPrice()));
            Assert.True(DoubleEquals(95.739, rooms[3].GetPrice()));
            Assert.True(DoubleEquals(367.259, hotel.GetAveragePrice()));
        }
    }
}