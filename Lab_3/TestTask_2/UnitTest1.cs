using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Task_2.Services;
using System;
using Task_2;

namespace TestTask_2
{
    public class UnitTest1
    {
       
        public bool DoubleEquals(double left, double right)
        {
            return Math.Abs(left - right) < 1E-5;
        }
        [Fact]
        public void Test1()
        {
            Assert.True(DoubleEquals(Class1.Calculate(0.0),-0.69315));
            Assert.True(DoubleEquals(Class1.Calculate(-10.0), 29.33969));
            Assert.False(DoubleEquals(Class1.Calculate(42.4423), 45.765));
        }
    }
}