using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Task_3;
using Task_3.Date;
using System;
namespace TestTask_3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            DateTime date = new DateTime(2003, 10, 5);
            Assert.Equal(DayOfWeek.Sunday, DateServices.GetDay(date));
            date = new DateTime(2022, 03, 31);
            Assert.Equal(DayOfWeek.Thursday, DateServices.GetDay(date));
            date = new DateTime(2022, 12, 12);
            Assert.Equal(DayOfWeek.Monday, DateServices.GetDay(date));
        }
        [Fact]
        public void Test2()
        {
            DateTime date = new DateTime(2022, 03, 31);
            Assert.Equal(0, DateServices.GetDaysSpan(31, 03, 2022, date));
            date = new DateTime(2022, 12, 12);
            Assert.Equal(256, DateServices.GetDaysSpan(31, 03, 2022, date));
        }
    }
}