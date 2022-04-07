using Xunit;
using Hotels;
using System;
namespace Test
{
    public class UnitTest1
    {
        public bool DoubleEquals(double left, double right)
        {
            return Math.Abs(left - right) < 1E-3;
        }
        [Fact]
        public void Test1()
        {
            Hotel hotel = Hotel.GetInstance("srgsf", 34,76,45.7);

            Assert.True(DoubleEquals(1553.8,hotel.Calculate()));

            hotel.IncreaseRate(34.8);
            Assert.True(DoubleEquals(80.5, hotel.getRate()));
            Assert.False(DoubleEquals(45.96, hotel.Calculate()));

            hotel.DecreaseRate(12.784);
            Assert.True(DoubleEquals(67.716, hotel.getRate()));
            Assert.True(DoubleEquals(2302.344, hotel.Calculate()));

            hotel.DecreaseRate(100);
            Assert.True(DoubleEquals(67.716, hotel.getRate()));

            Assert.Equal(hotel, Hotel.GetInstance("bdfbdf", 76,876,23.6));
        }
      
    }
}